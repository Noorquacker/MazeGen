using System;
using System.Windows.Forms;

namespace HypermazeGen {
    static class Program {
        [STAThread]
        static void Main(String[] args) {
            Form1 form;
            if (args.Length < 1) {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(form = new Form1());
            }
            else {
                Console.WriteLine("Yeah, we don't have quite the support for command line args yet.");
                Console.WriteLine("So, um...enjoy this nice useless message.");
            }
        }
    }
}
