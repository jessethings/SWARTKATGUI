using System;
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
    public partial class ModifyUser : Form
    {
        public bool isCreating = true;
        public int userID = 0;

        public ModifyUser()
        {
            InitializeComponent();
        }

        private void ModifyUser_Load(object sender, EventArgs e)
        {
            if (isCreating)
            {
                butApply.Text = "Create User";
                this.Text = "Fortuna: " + butApply.Text;
            }
            else
            {
                butApply.Text = "Modify User";
                if (userID > 0)
                {
                    //things
                }
            }
            this.Text = "Fortuna: " + butApply.Text;

            for (AccessLevel al = AccessLevel.Guest; al <= AccessLevel.Admin; al += 1)
            {
                cboRole.Items.Add(al.ToString());
            }

            cboFarmID.Items.Add("None");
            cboFarmID.Items.Add("Kounga");
        }

        private void butApply_Click(object sender, EventArgs e)
        {
            //do stuff
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
