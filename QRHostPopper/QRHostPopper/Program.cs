using System;
using System.Windows.Forms;

namespace QRHostPopper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new MainForm();

            // Add the message filter here
            Application.AddMessageFilter(new ShortcutKeysMessageFilter(mainForm));

            Application.Run(mainForm);
        }
    }
}
