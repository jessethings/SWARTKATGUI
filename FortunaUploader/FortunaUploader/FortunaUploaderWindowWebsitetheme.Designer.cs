namespace FortunaUploader
{
    partial class FortunaUploaderWindowWebsitetheme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FortunaUploaderWindowWebsitetheme));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panTop = new System.Windows.Forms.Panel();
            this.butShowNewsMenu = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butShowAdminMenu = new System.Windows.Forms.Button();
            this.butShowUploadMenu = new System.Windows.Forms.Button();
            this.panLogin = new System.Windows.Forms.Panel();
            this.labLoginError = new System.Windows.Forms.Label();
            this.chkRememberPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.chkRememberUsername = new System.Windows.Forms.CheckBox();
            this.labUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panAdminMenu = new System.Windows.Forms.Panel();
            this.butCreateFarm = new System.Windows.Forms.Button();
            this.butGenerateWeeklyReport = new System.Windows.Forms.Button();
            this.butCreateNewUser = new System.Windows.Forms.Button();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.labDate = new System.Windows.Forms.Label();
            this.labFarmName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panUploadReport = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labUploadError = new System.Windows.Forms.Label();
            this.txtReportFileLocation = new System.Windows.Forms.TextBox();
            this.butUploadSelectedReportFile = new System.Windows.Forms.Button();
            this.butSelectReportFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panTop.SuspendLayout();
            this.panLogin.SuspendLayout();
            this.panAdminMenu.SuspendLayout();
            this.panUploadReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(373, 94);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.White;
            this.panTop.Controls.Add(this.butShowNewsMenu);
            this.panTop.Controls.Add(this.butClose);
            this.panTop.Controls.Add(this.butShowAdminMenu);
            this.panTop.Controls.Add(this.butShowUploadMenu);
            this.panTop.Controls.Add(this.picLogo);
            this.panTop.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 10);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(900, 100);
            this.panTop.TabIndex = 2;
            this.panTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // butShowNewsMenu
            // 
            this.butShowNewsMenu.BackColor = System.Drawing.Color.White;
            this.butShowNewsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowNewsMenu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butShowNewsMenu.FlatAppearance.BorderSize = 0;
            this.butShowNewsMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butShowNewsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butShowNewsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowNewsMenu.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowNewsMenu.ForeColor = System.Drawing.Color.Black;
            this.butShowNewsMenu.Location = new System.Drawing.Point(725, 0);
            this.butShowNewsMenu.Name = "butShowNewsMenu";
            this.butShowNewsMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.butShowNewsMenu.Size = new System.Drawing.Size(85, 100);
            this.butShowNewsMenu.TabIndex = 9;
            this.butShowNewsMenu.Text = "NEWS";
            this.butShowNewsMenu.UseVisualStyleBackColor = false;
            this.butShowNewsMenu.Visible = false;
            this.butShowNewsMenu.Click += new System.EventHandler(this.butShowNewsMenu_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.White;
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.ForeColor = System.Drawing.Color.Black;
            this.butClose.Location = new System.Drawing.Point(810, 0);
            this.butClose.Name = "butClose";
            this.butClose.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.butClose.Size = new System.Drawing.Size(75, 100);
            this.butClose.TabIndex = 7;
            this.butClose.Text = "EXIT";
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butShowAdminMenu
            // 
            this.butShowAdminMenu.BackColor = System.Drawing.Color.White;
            this.butShowAdminMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowAdminMenu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butShowAdminMenu.FlatAppearance.BorderSize = 0;
            this.butShowAdminMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butShowAdminMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butShowAdminMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowAdminMenu.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowAdminMenu.ForeColor = System.Drawing.Color.Black;
            this.butShowAdminMenu.Location = new System.Drawing.Point(545, 0);
            this.butShowAdminMenu.Name = "butShowAdminMenu";
            this.butShowAdminMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.butShowAdminMenu.Size = new System.Drawing.Size(85, 100);
            this.butShowAdminMenu.TabIndex = 6;
            this.butShowAdminMenu.Text = "ADMIN";
            this.butShowAdminMenu.UseVisualStyleBackColor = false;
            this.butShowAdminMenu.Visible = false;
            this.butShowAdminMenu.Click += new System.EventHandler(this.butShowAdminMenu_Click);
            // 
            // butShowUploadMenu
            // 
            this.butShowUploadMenu.BackColor = System.Drawing.Color.White;
            this.butShowUploadMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowUploadMenu.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butShowUploadMenu.FlatAppearance.BorderSize = 0;
            this.butShowUploadMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butShowUploadMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.butShowUploadMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShowUploadMenu.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowUploadMenu.ForeColor = System.Drawing.Color.Black;
            this.butShowUploadMenu.Location = new System.Drawing.Point(630, 0);
            this.butShowUploadMenu.Name = "butShowUploadMenu";
            this.butShowUploadMenu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.butShowUploadMenu.Size = new System.Drawing.Size(95, 100);
            this.butShowUploadMenu.TabIndex = 5;
            this.butShowUploadMenu.Text = "UPLOAD REPORT";
            this.butShowUploadMenu.UseVisualStyleBackColor = false;
            this.butShowUploadMenu.Visible = false;
            this.butShowUploadMenu.Click += new System.EventHandler(this.butShowUploadMenu_Click);
            // 
            // panLogin
            // 
            this.panLogin.BackColor = System.Drawing.Color.White;
            this.panLogin.Controls.Add(this.labLoginError);
            this.panLogin.Controls.Add(this.chkRememberPassword);
            this.panLogin.Controls.Add(this.txtPassword);
            this.panLogin.Controls.Add(this.labPassword);
            this.panLogin.Controls.Add(this.butLogin);
            this.panLogin.Controls.Add(this.chkRememberUsername);
            this.panLogin.Controls.Add(this.labUsername);
            this.panLogin.Controls.Add(this.txtUsername);
            this.panLogin.Location = new System.Drawing.Point(10, 240);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(373, 250);
            this.panLogin.TabIndex = 0;
            // 
            // labLoginError
            // 
            this.labLoginError.AutoSize = true;
            this.labLoginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLoginError.ForeColor = System.Drawing.Color.Red;
            this.labLoginError.Location = new System.Drawing.Point(10, 184);
            this.labLoginError.Name = "labLoginError";
            this.labLoginError.Size = new System.Drawing.Size(45, 17);
            this.labLoginError.TabIndex = 7;
            this.labLoginError.Text = "ERROR";
            this.labLoginError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labLoginError.UseCompatibleTextRendering = true;
            this.labLoginError.Visible = false;
            // 
            // chkRememberPassword
            // 
            this.chkRememberPassword.AutoSize = true;
            this.chkRememberPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberPassword.Location = new System.Drawing.Point(10, 164);
            this.chkRememberPassword.Name = "chkRememberPassword";
            this.chkRememberPassword.Size = new System.Drawing.Size(126, 17);
            this.chkRememberPassword.TabIndex = 3;
            this.chkRememberPassword.Text = "Remember Password";
            this.chkRememberPassword.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(10, 114);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(353, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FortunaUploaderWindow_KeyUp);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.ForeColor = System.Drawing.Color.Navy;
            this.labPassword.Location = new System.Drawing.Point(8, 79);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(134, 30);
            this.labPassword.TabIndex = 4;
            this.labPassword.Text = "PASSWORD";
            this.labPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labPassword.UseCompatibleTextRendering = true;
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(64)))));
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butLogin.FlatAppearance.BorderSize = 0;
            this.butLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(165)))), ((int)(((byte)(45)))));
            this.butLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(10, 204);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(353, 36);
            this.butLogin.TabIndex = 4;
            this.butLogin.Text = "LOG IN";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            this.butLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FortunaUploaderWindow_KeyUp);
            // 
            // chkRememberUsername
            // 
            this.chkRememberUsername.AutoSize = true;
            this.chkRememberUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRememberUsername.Location = new System.Drawing.Point(10, 149);
            this.chkRememberUsername.Name = "chkRememberUsername";
            this.chkRememberUsername.Size = new System.Drawing.Size(134, 17);
            this.chkRememberUsername.TabIndex = 2;
            this.chkRememberUsername.Text = "Remember Farm Name";
            this.chkRememberUsername.UseVisualStyleBackColor = true;
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.Navy;
            this.labUsername.Location = new System.Drawing.Point(8, 10);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(280, 30);
            this.labUsername.TabIndex = 1;
            this.labUsername.Text = "FARM NAME (USERNAME)";
            this.labUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labUsername.UseCompatibleTextRendering = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(10, 45);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(353, 29);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FortunaUploaderWindow_KeyUp);
            // 
            // panAdminMenu
            // 
            this.panAdminMenu.BackColor = System.Drawing.Color.White;
            this.panAdminMenu.Controls.Add(this.butCreateFarm);
            this.panAdminMenu.Controls.Add(this.butGenerateWeeklyReport);
            this.panAdminMenu.Controls.Add(this.butCreateNewUser);
            this.panAdminMenu.Controls.Add(this.cboDate);
            this.panAdminMenu.Controls.Add(this.labDate);
            this.panAdminMenu.Location = new System.Drawing.Point(10, 240);
            this.panAdminMenu.Name = "panAdminMenu";
            this.panAdminMenu.Size = new System.Drawing.Size(373, 250);
            this.panAdminMenu.TabIndex = 3;
            this.panAdminMenu.Visible = false;
            // 
            // butCreateFarm
            // 
            this.butCreateFarm.BackColor = System.Drawing.Color.DodgerBlue;
            this.butCreateFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCreateFarm.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butCreateFarm.FlatAppearance.BorderSize = 0;
            this.butCreateFarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.butCreateFarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.butCreateFarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCreateFarm.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateFarm.ForeColor = System.Drawing.Color.White;
            this.butCreateFarm.Location = new System.Drawing.Point(10, 59);
            this.butCreateFarm.Name = "butCreateFarm";
            this.butCreateFarm.Size = new System.Drawing.Size(353, 36);
            this.butCreateFarm.TabIndex = 13;
            this.butCreateFarm.Text = "CREATE FARM";
            this.butCreateFarm.UseVisualStyleBackColor = false;
            this.butCreateFarm.Click += new System.EventHandler(this.butCreateFarm_Click);
            // 
            // butGenerateWeeklyReport
            // 
            this.butGenerateWeeklyReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(64)))));
            this.butGenerateWeeklyReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butGenerateWeeklyReport.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butGenerateWeeklyReport.FlatAppearance.BorderSize = 0;
            this.butGenerateWeeklyReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(165)))), ((int)(((byte)(45)))));
            this.butGenerateWeeklyReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.butGenerateWeeklyReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGenerateWeeklyReport.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butGenerateWeeklyReport.ForeColor = System.Drawing.Color.White;
            this.butGenerateWeeklyReport.Location = new System.Drawing.Point(10, 204);
            this.butGenerateWeeklyReport.Name = "butGenerateWeeklyReport";
            this.butGenerateWeeklyReport.Size = new System.Drawing.Size(353, 36);
            this.butGenerateWeeklyReport.TabIndex = 12;
            this.butGenerateWeeklyReport.Text = "GENERATE REPORT";
            this.butGenerateWeeklyReport.UseVisualStyleBackColor = false;
            this.butGenerateWeeklyReport.Click += new System.EventHandler(this.butGenerateWeeklyReport_Click);
            // 
            // butCreateNewUser
            // 
            this.butCreateNewUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.butCreateNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCreateNewUser.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butCreateNewUser.FlatAppearance.BorderSize = 0;
            this.butCreateNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.butCreateNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.butCreateNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCreateNewUser.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateNewUser.ForeColor = System.Drawing.Color.White;
            this.butCreateNewUser.Location = new System.Drawing.Point(10, 14);
            this.butCreateNewUser.Name = "butCreateNewUser";
            this.butCreateNewUser.Size = new System.Drawing.Size(353, 36);
            this.butCreateNewUser.TabIndex = 10;
            this.butCreateNewUser.Text = "CREATE USER";
            this.butCreateNewUser.UseVisualStyleBackColor = false;
            this.butCreateNewUser.Click += new System.EventHandler(this.butCreateNewUser_Click);
            // 
            // cboDate
            // 
            this.cboDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDate.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.cboDate.FormattingEnabled = true;
            this.cboDate.IntegralHeight = false;
            this.cboDate.ItemHeight = 24;
            this.cboDate.Location = new System.Drawing.Point(87, 164);
            this.cboDate.MaxDropDownItems = 10;
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(276, 32);
            this.cboDate.TabIndex = 9;
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDate.ForeColor = System.Drawing.Color.Navy;
            this.labDate.Location = new System.Drawing.Point(10, 166);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(71, 30);
            this.labDate.TabIndex = 6;
            this.labDate.Text = "DATE:";
            this.labDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDate.UseCompatibleTextRendering = true;
            // 
            // labFarmName
            // 
            this.labFarmName.AutoSize = true;
            this.labFarmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFarmName.ForeColor = System.Drawing.Color.Navy;
            this.labFarmName.Location = new System.Drawing.Point(8, 10);
            this.labFarmName.Name = "labFarmName";
            this.labFarmName.Size = new System.Drawing.Size(75, 30);
            this.labFarmName.TabIndex = 2;
            this.labFarmName.Text = "FARM:";
            this.labFarmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labFarmName.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 10);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 10);
            this.panel2.TabIndex = 4;
            // 
            // panUploadReport
            // 
            this.panUploadReport.BackColor = System.Drawing.Color.White;
            this.panUploadReport.Controls.Add(this.progressBar);
            this.panUploadReport.Controls.Add(this.labUploadError);
            this.panUploadReport.Controls.Add(this.txtReportFileLocation);
            this.panUploadReport.Controls.Add(this.butUploadSelectedReportFile);
            this.panUploadReport.Controls.Add(this.butSelectReportFile);
            this.panUploadReport.Controls.Add(this.labFarmName);
            this.panUploadReport.Location = new System.Drawing.Point(10, 240);
            this.panUploadReport.Name = "panUploadReport";
            this.panUploadReport.Size = new System.Drawing.Size(373, 250);
            this.panUploadReport.TabIndex = 3;
            this.panUploadReport.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 143);
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(353, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 12;
            // 
            // labUploadError
            // 
            this.labUploadError.AutoSize = true;
            this.labUploadError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUploadError.ForeColor = System.Drawing.Color.Red;
            this.labUploadError.Location = new System.Drawing.Point(10, 184);
            this.labUploadError.Name = "labUploadError";
            this.labUploadError.Size = new System.Drawing.Size(45, 17);
            this.labUploadError.TabIndex = 8;
            this.labUploadError.Text = "ERROR";
            this.labUploadError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labUploadError.UseCompatibleTextRendering = true;
            this.labUploadError.Visible = false;
            // 
            // txtReportFileLocation
            // 
            this.txtReportFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReportFileLocation.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportFileLocation.ForeColor = System.Drawing.Color.DimGray;
            this.txtReportFileLocation.Location = new System.Drawing.Point(8, 74);
            this.txtReportFileLocation.MaxLength = 2555;
            this.txtReportFileLocation.Name = "txtReportFileLocation";
            this.txtReportFileLocation.ReadOnly = true;
            this.txtReportFileLocation.Size = new System.Drawing.Size(353, 22);
            this.txtReportFileLocation.TabIndex = 8;
            // 
            // butUploadSelectedReportFile
            // 
            this.butUploadSelectedReportFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(64)))));
            this.butUploadSelectedReportFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butUploadSelectedReportFile.Enabled = false;
            this.butUploadSelectedReportFile.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butUploadSelectedReportFile.FlatAppearance.BorderSize = 0;
            this.butUploadSelectedReportFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(165)))), ((int)(((byte)(45)))));
            this.butUploadSelectedReportFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.butUploadSelectedReportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUploadSelectedReportFile.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUploadSelectedReportFile.ForeColor = System.Drawing.Color.White;
            this.butUploadSelectedReportFile.Location = new System.Drawing.Point(8, 204);
            this.butUploadSelectedReportFile.Name = "butUploadSelectedReportFile";
            this.butUploadSelectedReportFile.Size = new System.Drawing.Size(353, 36);
            this.butUploadSelectedReportFile.TabIndex = 11;
            this.butUploadSelectedReportFile.Text = "UPLOAD";
            this.butUploadSelectedReportFile.UseVisualStyleBackColor = false;
            this.butUploadSelectedReportFile.Click += new System.EventHandler(this.butUploadSelectedReportFile_Click);
            // 
            // butSelectReportFile
            // 
            this.butSelectReportFile.BackColor = System.Drawing.Color.DodgerBlue;
            this.butSelectReportFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSelectReportFile.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.butSelectReportFile.FlatAppearance.BorderSize = 0;
            this.butSelectReportFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.butSelectReportFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.butSelectReportFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSelectReportFile.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelectReportFile.ForeColor = System.Drawing.Color.White;
            this.butSelectReportFile.Location = new System.Drawing.Point(8, 102);
            this.butSelectReportFile.Name = "butSelectReportFile";
            this.butSelectReportFile.Size = new System.Drawing.Size(353, 36);
            this.butSelectReportFile.TabIndex = 7;
            this.butSelectReportFile.Text = "SELECT FILE";
            this.butSelectReportFile.UseVisualStyleBackColor = false;
            this.butSelectReportFile.Click += new System.EventHandler(this.butSelectReportFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Weekly Farm Report";
            this.openFileDialog.Filter = "Excel Workbooks|*.xlsx";
            // 
            // FortunaUploaderWindowWebsitetheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panAdminMenu);
            this.Controls.Add(this.panUploadReport);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FortunaUploaderWindowWebsitetheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortuna Uploader";
            this.Load += new System.EventHandler(this.FortunaUploaderWindowWebsitetheme_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FortunaUploaderWindow_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panTop.ResumeLayout(false);
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.panAdminMenu.ResumeLayout(false);
            this.panAdminMenu.PerformLayout();
            this.panUploadReport.ResumeLayout(false);
            this.panUploadReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panLogin;
        private System.Windows.Forms.Panel panAdminMenu;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.CheckBox chkRememberUsername;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkRememberPassword;
        private System.Windows.Forms.Label labLoginError;
        private System.Windows.Forms.Button butShowUploadMenu;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butShowAdminMenu;
        private System.Windows.Forms.Label labFarmName;
        private System.Windows.Forms.Button butShowNewsMenu;
        private System.Windows.Forms.Panel panUploadReport;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Button butSelectReportFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button butUploadSelectedReportFile;
        private System.Windows.Forms.TextBox txtReportFileLocation;
        private System.Windows.Forms.Label labUploadError;
        private System.Windows.Forms.Button butGenerateWeeklyReport;
        private System.Windows.Forms.Button butCreateNewUser;
        private System.Windows.Forms.Button butCreateFarm;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}