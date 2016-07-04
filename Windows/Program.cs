using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemPass
{
    static class Program
    {
        public static NotifyIcon notifyIcon;
        public static Form form;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new Form1();

            notifyIcon = new NotifyIcon();
            notifyIcon.BalloonTipTitle = "MemPass";
            notifyIcon.Icon = form.Icon;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            Program.notifyIcon.Visible = true;

            Application.Run();
        }

        private static void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            form.Show();
        }
    }
}
