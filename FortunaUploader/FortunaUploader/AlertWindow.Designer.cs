namespace FortunaUploader
{
    partial class AlertWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertWindow));
            this.panTitlebar = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.labHeader = new System.Windows.Forms.Label();
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
            this.panTitlebar.Size = new System.Drawing.Size(300, 26);
            this.panTitlebar.TabIndex = 1;
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
            this.labTitle.Size = new System.Drawing.Size(37, 17);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "Alert";
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
            this.butExit.Location = new System.Drawing.Point(275, 0);
            this.butExit.Margin = new System.Windows.Forms.Padding(2);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(25, 26);
            this.butExit.TabIndex = 2;
            this.butExit.Text = "X";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.Location = new System.Drawing.Point(0, 75);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMessage.Size = new System.Drawing.Size(300, 100);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.Text = "";
            // 
            // labHeader
            // 
            this.labHeader.BackColor = System.Drawing.Color.Transparent;
            this.labHeader.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHeader.ForeColor = System.Drawing.Color.Black;
            this.labHeader.Location = new System.Drawing.Point(0, 35);
            this.labHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labHeader.Name = "labHeader";
            this.labHeader.Size = new System.Drawing.Size(300, 30);
            this.labHeader.TabIndex = 15;
            this.labHeader.Text = "Title";
            this.labHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlertWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(300, 175);
            this.Controls.Add(this.labHeader);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panTitlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlertWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.AlertWindow_Load);
            this.panTitlebar.ResumeLayout(false);
            this.panTitlebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTitlebar;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Label labHeader;
    }
}