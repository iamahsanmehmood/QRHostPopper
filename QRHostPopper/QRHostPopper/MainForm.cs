using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using QRCoder;

namespace QRHostPopper
{
    public partial class MainForm : Form
    {
        private const int HOTKEY_ID = 9000;

        public MainForm()
        {
            InitializeComponent();
            ShowQRCodePopup();
            this.Visible = false; // Hide the form on startup
            InitializeHotkey(); // Initialize the global hotkey
            this.Shown += (sender, e) => this.Hide();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                UnregisterHotKey(this.Handle, HOTKEY_ID);
            }
            base.Dispose(disposing);
        }

        private void InitializeHotkey()
        {
            if (!RegisterHotKey(this.Handle, HOTKEY_ID, (int)KeyModifier.Control | (int)KeyModifier.Alt | (int)KeyModifier.Windows, (int)Keys.D))
            {
                // Handle error if hotkey registration fails
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    if (m.WParam.ToInt32() == HOTKEY_ID)
                    {
                        ShowQRCodePopup();
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        internal void ShowQRCodePopup()
        {
            // Generate the QR code based on the computer's hostname
            string hostname = Environment.MachineName;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(hostname, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10);

            // Display the QR code and hostname
            qrCodePictureBox.Image = qrCodeImage;
            hostnameLabel.Text = "Hostname: " + hostname;

            // Show the form
            this.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }
    }
}
