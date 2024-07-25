using System;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;

namespace QRHostPopper
{
    partial class MainForm
    {
        private PictureBox qrCodePictureBox;
        private Label hostnameLabel;
        private Button button1;

        private void InitializeComponent()
        {
            qrCodePictureBox = new PictureBox();
            hostnameLabel = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)qrCodePictureBox).BeginInit();
            SuspendLayout();
            // 
            // qrCodePictureBox
            // 
            qrCodePictureBox.Location = new Point(12, 12);
            qrCodePictureBox.Name = "qrCodePictureBox";
            qrCodePictureBox.Size = new Size(323, 279);
            qrCodePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            qrCodePictureBox.TabIndex = 0;
            qrCodePictureBox.TabStop = false;
            // 
            // hostnameLabel
            // 
            hostnameLabel.AutoSize = true;
            hostnameLabel.Location = new Point(12, 303);
            hostnameLabel.Name = "hostnameLabel";
            hostnameLabel.Size = new Size(38, 15);
            hostnameLabel.TabIndex = 1;
            hostnameLabel.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(116, 334);
            button1.Name = "button1";
            button1.Size = new Size(113, 36);
            button1.TabIndex = 2;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += closeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 374);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(hostnameLabel);
            Controls.Add(qrCodePictureBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QRHostPopper";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)qrCodePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
