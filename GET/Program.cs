using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace GET
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.ThreadExit += new EventHandler((object sender,EventArgs e) => {Process.Start(Application.ExecutablePath);});
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
