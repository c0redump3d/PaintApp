using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    static class Program
    {
        public static bool KeepRunning { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            KeepRunning = true;
            while (KeepRunning)
            {
                Application.Run(args.Length == 0 ? new Form1(string.Empty) : new Form1(args[0]));
                if(args.Length != 0)
                    args[0] = string.Empty;
            }
        }
    }
}
