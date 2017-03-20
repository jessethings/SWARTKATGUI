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
using System.Drawing.Text;
using System.Runtime.InteropServices;
using FortunaExcelProcessing;

namespace FortunaUploader
{
    public partial class FortunaUploaderWindowWebsitetheme : Form
    {
        bool isLoggedIn = false;

        public FortunaUploaderWindowWebsitetheme()
        {
            InitializeComponent();
            //InitCustomLabelFont();
        }

        private void InitCustomLabelFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            int fontLength = Properties.Resources.OpenSans_Regular.Length;
            byte[] fontdata = Properties.Resources.OpenSans_Regular;
            IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);

            labPassword.Font = new Font(pfc.Families[0], labPassword.Font.Size);
            labUsername.Font = new Font(pfc.Families[0], labUsername.Font.Size);
            chkRememberUsername.Font = new Font(pfc.Families[0], chkRememberUsername.Font.Size);
            chkRememberPassword.Font = new Font(pfc.Families[0], chkRememberPassword.Font.Size);
            labLoginError.Font = new Font(pfc.Families[0], labLoginError.Font.Size);
            labFarmName.Font = new Font(pfc.Families[0], labFarmName.Font.Size);
            labDate.Font = new Font(pfc.Families[0], labDate.Font.Size);
            labUploadError.Font = new Font(pfc.Families[0], labUploadError.Font.Size);
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

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    labFarmName.Text = "FARM: " + Scripts.Login.GetFarmName((int)this.Tag).ToUpper();
                    this.Text = string.Format("{0} [{1}]", this.Text, labFarmName.Text);

                    labLoginError.Text = " ";
                    isLoggedIn = true;

                    AccessLevel tmp = Scripts.Login.GetAccessLevel(id, AccessLevel.Admin);
                    if (tmp >= AccessLevel.User)
                    {
                        butShowUploadMenu.Show();
                        panLogin.Hide();
                        SetActiveButton(butShowUploadMenu);
                        butShowNewsMenu.Show();
                        panUploadReport.Show();
                    }
                    if (tmp >= AccessLevel.Admin)
                    {
                        butShowAdminMenu.Show();
                        //panUploadReport.Hide();
                        //panRight.Show();
                    }
                }
                else
                {
                    labLoginError.Show();
                    labLoginError.Text = "Uh Oh, it would appear there was an issue logging you in.";
                }
            }
        }

        private void SetActiveButton(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 164, 228);
            btn.ForeColor = Color.White;
        }

        private void SetUnactiveButton(Button btn, bool all = false)
        {
            if (all)
            {
                SetUnactiveButton(butShowAdminMenu);
                SetUnactiveButton(butShowNewsMenu);
                SetUnactiveButton(butShowUploadMenu);
            }
            btn.BackColor = Color.FromArgb(255, 255, 255);
            //btn.ForeColor = Color.FromArgb(232, 232, 232);
            btn.ForeColor = Color.Black;
        }

        private void butSelectReportFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtReportFileLocation.Text = openFileDialog.FileName;
                butUploadSelectedReportFile.Enabled = true;
            }
        }

        private void butUploadSelectedReportFile_Click(object sender, EventArgs e)
        {
            string tmp = txtReportFileLocation.Text;
            if (string.IsNullOrEmpty(tmp) || tmp.Substring(tmp.Length - 5) == ".xlsx")
            {
                try
                {
                    progressBar.MarqueeAnimationSpeed = 100;
                    Thread thread = new Thread(AttemptUpload);
                    thread.Start();
                }
                catch
                {
                    AlertWindow aw = new AlertWindow();
                    aw.title = "Incorrect File Format";
                    aw.message = string.Format("This file has a formating issue.\nPlease contact your nearest administrator for assistance.");
                    aw.ShowDialog();
                    labUploadError.Show();
                    labUploadError.Text = aw.message;
                }
            }
            else
            {
                AlertWindow aw = new AlertWindow();
                aw.message = "Incorrect File";
                aw.ShowDialog();
                labUploadError.Show();
                labUploadError.Text = aw.message;
            }
        }

        private void AttemptUpload()
        {
            try {
                ProcessData f = new ProcessData(txtReportFileLocation.Text);
                f.createSQLiteDB();
                f.CreateWorkBook();
                f.processSheet("Input Page");
                f.processSheet("Weekly Comments");
                f.processSheet("Weekly Data");
                f.processSheet("paddocks");
                try
                {
                    progressBar.BeginInvoke(new Action(() =>
                    {
                        progressBar.MarqueeAnimationSpeed = 0;
                    }));
                }
                catch
                {}
            }
            catch
            {
                AlertWindow aw = new AlertWindow();
                aw.title = "Incorrect File Format";
                aw.message = string.Format("This file has a formating issue.\nPlease contact your nearest administrator for assistance.");
                aw.ShowDialog();
            }
            try
            {
                progressBar.BeginInvoke(new Action(() =>
                {
                    progressBar.MarqueeAnimationSpeed = 0;
                }));
            }
            catch
            {}
        }

        private void butShowUploadMenu_Click(object sender, EventArgs e)
        {
            SetUnactiveButton(butShowNewsMenu);
            SetUnactiveButton(butShowAdminMenu);
            SetActiveButton(butShowUploadMenu);
            panAdminMenu.Visible = false;
            panUploadReport.Visible = true;
        }

        private void LoadDateCombobox(DateTime start, DateTime end, int periods)
        {
            for (DateTime date = start; date < end; date = date.AddDays(periods))
            {
                cboDate.Items.Add(date.ToString("dd MMM"));
            }
        }

        private void FortunaUploaderWindowWebsitetheme_Load(object sender, EventArgs e)
        {
            LoadDateCombobox(new DateTime(2017, 6, 6), new DateTime(2018, 6, 6), 7);
        }

        private void butCreateNewUser_Click(object sender, EventArgs e)
        {
            ModifyUser mu = new ModifyUser();
            mu.isCreating = true;
            mu.ShowDialog();
        }

        private void butShowNewsMenu_Click(object sender, EventArgs e)
        {
            SetUnactiveButton(butShowAdminMenu);
            SetUnactiveButton(butShowUploadMenu);
            SetActiveButton(butShowNewsMenu);
            panAdminMenu.Visible = false;
            panUploadReport.Visible = false;
        }

        private void butShowAdminMenu_Click(object sender, EventArgs e)
        {
            SetUnactiveButton(butShowNewsMenu);
            SetUnactiveButton(butShowUploadMenu);
            SetActiveButton(butShowAdminMenu);
            panAdminMenu.Visible = true;
            panUploadReport.Visible = false;
        }

        private void butCreateFarm_Click(object sender, EventArgs e)
        {

        }

        private void butGenerateWeeklyReport_Click(object sender, EventArgs e)
        {
            processConsolidated p = new processConsolidated();
            p.createWorkBook();
        }
    }
}
