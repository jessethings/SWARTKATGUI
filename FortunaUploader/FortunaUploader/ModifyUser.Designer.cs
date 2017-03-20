namespace FortunaUploader
{
    partial class ModifyUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUser));
            this.panTitlebar = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cboFarmID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.butApply = new System.Windows.Forms.Button();
            this.panTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTitlebar
            // 
            this.panTitlebar.BackColor = System.Drawing.Color.White;
            this.panTitlebar.Controls.Add(this.labTitle);
            this.panTitlebar.Controls.Add(this.butExit);
            this.panTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTitlebar.Location = new System.Drawing.Point(0, 0);
            this.panTitlebar.Margin = new System.Windows.Forms.Padding(2);
            this.panTitlebar.Name = "panTitlebar";
            this.panTitlebar.Size = new System.Drawing.Size(275, 26);
            this.panTitlebar.TabIndex = 2;
            this.panTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.White;
            this.labTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labTitle.Location = new System.Drawing.Point(0, 5);
            this.labTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(96, 17);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Create a User";
            this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // butExit
            // 
            this.butExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.butExit.FlatAppearance.BorderSize = 0;
            this.butExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(250, 0);
            this.butExit.Margin = new System.Windows.Forms.Padding(2);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(25, 26);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "X";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(12, 61);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 22);
            this.txtUsername.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(12, 119);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 22);
            this.txtPassword.TabIndex = 18;
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.cboRole.FormattingEnabled = true;
            this.cboRole.IntegralHeight = false;
            this.cboRole.ItemHeight = 24;
            this.cboRole.Location = new System.Drawing.Point(12, 177);
            this.cboRole.MaxDropDownItems = 10;
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(250, 32);
            this.cboRole.TabIndex = 19;
            // 
            // cboFarmID
            // 
            this.cboFarmID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFarmID.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.cboFarmID.FormattingEnabled = true;
            this.cboFarmID.IntegralHeight = false;
            this.cboFarmID.ItemHeight = 24;
            this.cboFarmID.Location = new System.Drawing.Point(12, 245);
            this.cboFarmID.MaxDropDownItems = 10;
            this.cboFarmID.Name = "cboFarmID";
            this.cboFarmID.Size = new System.Drawing.Size(250, 32);
            this.cboFarmID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Role";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Farm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butApply
            // 
            this.butApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(195)))), ((int)(((byte)(64)))));
            this.butApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butApply.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.butApply.FlatAppearance.BorderSize = 0;
            this.butApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(165)))), ((int)(((byte)(45)))));
            this.butApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.butApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butApply.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butApply.ForeColor = System.Drawing.Color.White;
            this.butApply.Location = new System.Drawing.Point(12, 283);
            this.butApply.Name = "butApply";
            this.butApply.Size = new System.Drawing.Size(250, 36);
            this.butApply.TabIndex = 25;
            this.butApply.UseVisualStyleBackColor = false;
            this.butApply.Click += new System.EventHandler(this.butApply_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(275, 331);
            this.Controls.Add(this.butApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFarmID);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyUser";
            this.Text = "Modify User";
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            this.panTitlebar.ResumeLayout(false);
            this.panTitlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panTitlebar;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.ComboBox cboFarmID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butApply;
    }
}