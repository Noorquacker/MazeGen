namespace HypermazeGen {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BitmapDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.LengthNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.HeightNum = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.InvertCheck = new System.Windows.Forms.CheckBox();
            this.invertList = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.LayerHeight = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LayerWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LengthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // BitmapDialog
            // 
            this.BitmapDialog.DefaultExt = "bmp";
            this.BitmapDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg *.jpeg|Windows Bitmap File|*.bmp|All Files|*.*";
            this.BitmapDialog.FilterIndex = 3;
            this.BitmapDialog.Title = "Import a bitmap...";
            this.BitmapDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.BitmapDialog_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Import a maze bitmap(Daedalus preferred) here...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LengthNum
            // 
            this.LengthNum.Location = new System.Drawing.Point(51, 39);
            this.LengthNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.LengthNum.Name = "LengthNum";
            this.LengthNum.Size = new System.Drawing.Size(43, 20);
            this.LengthNum.TabIndex = 1;
            this.LengthNum.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // WidthNum
            // 
            this.WidthNum.Location = new System.Drawing.Point(141, 39);
            this.WidthNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.WidthNum.Name = "WidthNum";
            this.WidthNum.Size = new System.Drawing.Size(43, 20);
            this.WidthNum.TabIndex = 3;
            this.WidthNum.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // HeightNum
            // 
            this.HeightNum.Location = new System.Drawing.Point(229, 39);
            this.HeightNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.HeightNum.Name = "HeightNum";
            this.HeightNum.Size = new System.Drawing.Size(43, 20);
            this.HeightNum.TabIndex = 5;
            this.HeightNum.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Location = new System.Drawing.Point(103, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "C&onvert!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SaveDialog
            // 
            this.SaveDialog.DefaultExt = "schematic";
            this.SaveDialog.Filter = "Minecraft Schematic|*.schematic|Named Binary Tag|*.nbt|All Files|*.*";
            this.SaveDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveDialog_FileOk_1);
            // 
            // InvertCheck
            // 
            this.InvertCheck.AutoSize = true;
            this.InvertCheck.Location = new System.Drawing.Point(13, 65);
            this.InvertCheck.Name = "InvertCheck";
            this.InvertCheck.Size = new System.Drawing.Size(129, 17);
            this.InvertCheck.TabIndex = 8;
            this.InvertCheck.Text = "Inverted Image Colors";
            this.InvertCheck.UseVisualStyleBackColor = true;
            this.InvertCheck.CheckedChanged += new System.EventHandler(this.InvertCheck_CheckedChanged);
            // 
            // invertList
            // 
            this.invertList.AutoSize = true;
            this.invertList.Location = new System.Drawing.Point(173, 66);
            this.invertList.Name = "invertList";
            this.invertList.Size = new System.Drawing.Size(90, 13);
            this.invertList.TabIndex = 9;
            this.invertList.Text = "Walls are WHITE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Progress: no file selected";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Layer Height Thickness";
            // 
            // LayerHeight
            // 
            this.LayerHeight.Location = new System.Drawing.Point(137, 95);
            this.LayerHeight.Name = "LayerHeight";
            this.LayerHeight.Size = new System.Drawing.Size(43, 20);
            this.LayerHeight.TabIndex = 13;
            this.LayerHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Layer Space Width";
            // 
            // LayerWidth
            // 
            this.LayerWidth.Location = new System.Drawing.Point(137, 122);
            this.LayerWidth.Name = "LayerWidth";
            this.LayerWidth.Size = new System.Drawing.Size(43, 20);
            this.LayerWidth.TabIndex = 15;
            this.LayerWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LayerWidth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LayerHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.invertList);
            this.Controls.Add(this.InvertCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WidthNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthNum);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Maze Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LengthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LayerWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog BitmapDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown LengthNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown WidthNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown HeightNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog SaveDialog;
        private System.Windows.Forms.CheckBox InvertCheck;
        private System.Windows.Forms.Label invertList;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown LayerHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown LayerWidth;
    }
}

