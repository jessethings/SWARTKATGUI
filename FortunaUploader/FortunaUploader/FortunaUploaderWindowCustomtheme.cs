using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FortunaUploader
{
    public partial class FortunaUploaderWindowCustomtheme : Form
    {
        public FortunaUploaderWindowCustomtheme()
        {
            InitializeComponent();
        }

        private void MenuButtonMouseEnter(object sender, EventArgs e)
        {
            ChangeButtonTextColour(sender as Button, Color.Black);
        }

        private void MenuButtonMouseLeave(object sender, EventArgs e)
        {
            ChangeButtonTextColour(sender as Button, Color.White);
        }

        private void ChangeButtonTextColour(Button btn, Color clr)
        {
            btn.ForeColor = clr;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butShowLoginMenu_Click(object sender, EventArgs e)
        {
            butShowLoginMenu.Hide();
            panLogin.Location = new Point(200, 200);
            panLogin.Show();
        }

        private void butLoginCancel_Click(object sender, EventArgs e)
        {
            panLogin.Hide();
            butShowLoginMenu.Show();
            panLogin.Location = new Point(200, 500);
        }

        private void butLoginCancel_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeButtonTextColour(sender as Button, Color.Red);
        }

        private void butLoginCancel_MouseUp(object sender, MouseEventArgs e)
        {
            ChangeButtonTextColour(sender as Button, Color.FromArgb(43,43,43));
        }

        private void butLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ChangeButtonTextColour(sender as Button, Color.LimeGreen);
        }

        private bool isLoggedIn = false;

        private void AttemptLogin()
        {
            if (!isLoggedIn)
            {
                int id;
                if (txtUsername.Text != "" && txtPassword.Text != "")
                    id = Scripts.Login.AttemptLogin(txtUsername.Text, txtPassword.Text);
                else
                    id = 0;

                if (id != 0)
                {
                    this.Tag = id;
                    this.Text = Scripts.Login.GetFarmName(id);
                    this.Text = string.Format("{0} [{1}]", this.Text, this.Text);

                    labLoginError.Text = " ";
                    isLoggedIn = true;

                    AccessLevel tmp = Scripts.Login.GetAccessLevel(id, AccessLevel.Admin);
                    if (tmp >= AccessLevel.User)
                    {
                        //butUploadMenu.Show();
                        panLogin.Hide();
                        //panRight.Show();
                        //SetActiveButton(butUploadMenu);
                    }
                    if (tmp >= AccessLevel.Admin)
                    {
                        //butAdminMenu.Show();
                    }
                }
                else
                {
                    labLoginError.Show();
                    labLoginError.Text = "Uh Oh, it would appear there was an issue logging you in.";
                }
            }
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

        private void FortunaUploaderWindowCustomtheme_Load(object sender, EventArgs e)
        {

        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        private void FortunaUploaderWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                AttemptLogin();
        }
    }
}
