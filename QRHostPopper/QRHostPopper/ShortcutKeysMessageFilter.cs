using System;
using System.Windows.Forms;

namespace QRHostPopper
{
    public class ShortcutKeysMessageFilter : IMessageFilter
    {
        private MainForm mainForm;

        public ShortcutKeysMessageFilter(MainForm form)
        {
            mainForm = form;
        }

        public bool PreFilterMessage(ref Message m)
        {
            const int WM_KEYDOWN = 0x0100;
            Keys keyData = (Keys)(int)m.WParam;

            // Check for the desired shortcut keys (CTRL + ALT + WINDOWS + D)
            if (m.Msg == WM_KEYDOWN && keyData == (Keys.Control | Keys.Alt | Keys.Shift | Keys.LWin | Keys.RWin | Keys.D))
            {
                mainForm.ShowQRCodePopup();
                return true; // Signal that we handled the key event
            }

            return false; // Let the message pass to other controls
        }
    }
}
