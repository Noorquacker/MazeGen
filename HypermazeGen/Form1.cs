/*
copy rice noorquacker industries 2018 or something
just put it under the unilicense and be done with it
aight so I made this thing when I was into hypermazes and stuff
and it's a pile of poorly threaded garbage, I know
after all, it's made by me, Noorquacker, and all I do is make Garry's Mod Wiremod Expression 2 chip thingys
so have fun
do whatever
make it 12 thread please
because I now have the 8700K
or make it cuda
wait no make it opencl
*/
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using fNbt;
using System.Threading;

namespace HypermazeGen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        public Bitmap mazeBmp;
        public byte[] mazeBytes;
        public byte[] schBytes;
        public NbtCompound schRoot;                               //Variable stuff
        public int progress = 0;
        public int progressPercent = 0;
        public System.Windows.Forms.Timer loopTimer = new System.Windows.Forms.Timer();
        

        private void Form1_Load(object sender, EventArgs e) {
            loopTimer.Tick += new EventHandler(TimerClk);
            loopTimer.Interval = 100;
            loopTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e) {
            BitmapDialog.ShowDialog();
        }

        private void BitmapDialog_FileOk(object sender, CancelEventArgs e) {
            //Turn all of the image data to hex binary junk
            Image imgIn = Image.FromFile(BitmapDialog.FileName);
            mazeBmp = new Bitmap(imgIn);
            mazeBytes = new byte[mazeBmp.Height * mazeBmp.Width];
            Console.WriteLine("starting thread");
            Thread parseThread = new Thread(() => ParseImg());
            parseThread.Start(); //Spent half an hour debugging when I realized I forgot this line.

            //At this point, you can File.Write(mazeBytes) and look at it with a hex editor with line wrapping set
            //to whatever the image width was and it'll show a really trashy representation of the image in hex.
        }

        private void ParseImg() {
            progress = 1;
            Console.WriteLine("parsing");
            for (int x = 0; x < mazeBmp.Width; x++) {
                for (int y = 0; y < mazeBmp.Height; y++) {
                    Color pixCol = mazeBmp.GetPixel(x, y);
                    mazeBytes[y * mazeBmp.Width + x] = (byte)((Math.Sign(pixCol.R) & Math.Sign(pixCol.G) & Math.Sign(pixCol.B)));
                    progressPercent = (int)Math.Floor((y * mazeBmp.Width + x) / (mazeBmp.Height * (decimal)mazeBmp.Width) * 100m);  //m means decimal, like 100d = double and 100f = float
                }
            }
            Console.WriteLine("done");
            progress = 2;
        }

        private void InvertCheck_CheckedChanged(object sender, EventArgs e) {
            invertList.Text = "Walls are " + (InvertCheck.Checked ? "BLACK" : "WHITE");
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                if (mazeBmp.Width * mazeBmp.Height == LengthNum.Value * WidthNum.Value * HeightNum.Value) {
                    //Set up an evniroman-thingy-environment to convert the image's hex bin junk to a YZX-formatted schematic
                    byte[] schBytes = new byte[mazeBmp.Width * mazeBmp.Height * 2];
                    Console.WriteLine("Converting raw bitmap to YZX schematic...");
                    Thread convertThread = new Thread(() => ConvertImg(mazeBytes, (int)HeightNum.Value, (int)LengthNum.Value, (int)WidthNum.Value, mazeBmp.Width, mazeBmp.Height, InvertCheck.Checked));
                    convertThread.Start();
                }
                else {
                    if (BitmapDialog.FileName != "") {
                        MessageBox.Show("Incorrect dimensions. Did you input incorrect dimensions?", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        MessageBox.Show("Did you specify a file?");
                    }
                }
            }
            catch(DivideByZeroException) {
                MessageBox.Show("Attempted to divide by 0. Did you switch X/Y/Z dimensions?", "Exception thrown(DivideByZeroException)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(NullReferenceException) {
                MessageBox.Show("Attempted to reference a null value." + (BitmapDialog.FileName=="" ? "\nBecause you didn't specify a file." : " I don't know what happened."), "Exception thrown(NullReferenceException)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertImg(byte[] mazeBytes, int HeightNum, int LengthNum, int WidthNum, int imgWidth, int imgHeight, bool InvertCheck) {
            progress = 3;
            int layerWidth;
            int layerHeight;
            layerWidth = (int)LayerWidth.Value;
            layerHeight = (int)LayerHeight.Value;
            byte[] FULLDANGBYTEARRAY = new byte[(LengthNum - 0) * HeightNum * (WidthNum - 0) * layerWidth * layerHeight];
            for (int ya = 0; ya < HeightNum * layerHeight; ya++) {
                int y = (int)Math.Floor(ya / (decimal)layerHeight);
                for (int za = 0; za < LengthNum * layerWidth; za++) {  //As you can see, we go in YZX order because .schematic
                    int z = (int)Math.Floor(za / (decimal)layerWidth); //uses YZX order, and it's gonna save a heck of a lot of time
                    for (int xa = 0; xa < WidthNum * layerWidth; xa++) {
                        int x = (int)Math.Floor(xa / (decimal)layerWidth);
                        FULLDANGBYTEARRAY[(ya * LengthNum * WidthNum) + (z * WidthNum) + x] = (byte)(
                            mazeBytes[
                            x +                                                                                    //normal x value
                            z * imgWidth +                                                                         //1 down on Z axis is (imgWidth) pixels down
                            (y % (int)Math.Floor(imgWidth / (decimal)WidthNum)) * WidthNum +                       //Y has to go 1 layer's height down, but when Y exceeds the layers per column,
                            (int)Math.Floor(y / Math.Floor(imgWidth / (decimal)WidthNum)) * imgWidth * LengthNum   //it must shift 1 row of layers down. Then we use modulus up above to make sure that it resets.
                            ]
                            * (InvertCheck ? -1 : 1) + (InvertCheck ? 1 : 0));
                        progressPercent = (int)Math.Floor((y * WidthNum * LengthNum + z * WidthNum + x) / (decimal)mazeBytes.Length * 100m);
                        //Did You Know? this draws the maze mirrored on a flat plane(aka upside down),
                        //which normally doesn't do anything unless you want it not upside down.
                    }
                }
            }
            schBytes = FULLDANGBYTEARRAY;
            schRoot = new NbtCompound("Schematic");
            schRoot.Add(new NbtList("Entities", NbtTagType.Compound));
            schRoot.Add(new NbtList("TileEntities", NbtTagType.Compound));
            schRoot.Add(new NbtShort("Height", (short)(HeightNum * layerHeight)));
            schRoot.Add(new NbtShort("Length", (short)(LengthNum * layerWidth)));
            schRoot.Add(new NbtShort("Width", (short)(WidthNum * layerWidth)));
            schRoot.Add(new NbtString("Materials", "Alpha"));
            schRoot.Add(new NbtByteArray("Data", new byte[HeightNum * LengthNum * WidthNum * layerHeight * layerWidth]));
            schRoot.Add(new NbtByteArray("Blocks", schBytes));
            progress = 4;
        }

        private void SaveDialog_FileOk_1(object sender, CancelEventArgs e) {
            NbtFile file = new NbtFile(schRoot);
            file.SaveToFile(SaveDialog.FileName, NbtCompression.GZip);
            MessageBox.Show("Successfully saved to file!");
        }


        
        private void TimerClk(object sender, EventArgs e) {
            progressBar1.Value = progressPercent;
            switch(progress) {
                case 0:
                    button2.Enabled = false;
                    progressBar1.Visible = false;
                    label4.Text = "Progress: Please select a file";
                    break;
                case 1:
                    button2.Enabled = false;
                    progressBar1.Visible = true;
                    label4.Text = "Progress: Parsing image, please wait...";
                    break;
                case 2:
                    button2.Enabled = true;
                    progressBar1.Visible = false;
                    label4.Text = "Progress: Standby, ready to convert";
                    break;
                case 3:
                    progressBar1.Visible = true;
                    button2.Enabled = false;
                    label4.Text = "Progress: Converting to schematic, please wait...";
                    break;
                case 4:
                    progress = 0;
                    progressBar1.Visible = false;
                    button2.Enabled = false;
                    label4.Text = "Progress: Finished!";
                    SaveDialog.ShowDialog();
                    break;
                default:
                    //honey, where is my super suit?
                    loopTimer.Stop();
                    DialogResult result = MessageBox.Show("Current conversion progress is invalid(" + progress.ToString() + ")", "HELP WHAT THE HECK IS HAPPENING TO ME", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    Application.Exit();
                    break;
            }
        }
    }
}
