﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortunaUploader
{
    public partial class AlertWindow : Form
    {
        public string title;
        public string message;

        public AlertWindow()
        {
            InitializeComponent();
        }

        private void AlertWindow_Load(object sender, EventArgs e)
        {
            labTitle.Text = "Alert: " + title;
            this.Text = labTitle.Text;
            labHeader.Text = title;
            txtMessage.Text = message;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region draggableWindow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}
