namespace WindowsFormsApplication1
{
    partial class admin
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonClientList = new System.Windows.Forms.Button();
            this.ButtonAddClient = new System.Windows.Forms.Button();
            this.ButtonClientTests = new System.Windows.Forms.Button();
            this.ButtonMyAccount = new System.Windows.Forms.Button();
            this.buttonAdminArea = new System.Windows.Forms.Button();
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.labelaccesslevel = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 107);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(587, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // generalHelpToolStripMenuItem
            // 
            this.generalHelpToolStripMenuItem.Name = "generalHelpToolStripMenuItem";
            this.generalHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.generalHelpToolStripMenuItem.Text = "General Help";
            // 
            // ButtonClientList
            // 
            this.ButtonClientList.Location = new System.Drawing.Point(12, 27);
            this.ButtonClientList.Name = "ButtonClientList";
            this.ButtonClientList.Size = new System.Drawing.Size(75, 68);
            this.ButtonClientList.TabIndex = 2;
            this.ButtonClientList.Text = "Client List";
            this.ButtonClientList.UseVisualStyleBackColor = true;
            this.ButtonClientList.Click += new System.EventHandler(this.ButtonClientList_Click);
            // 
            // ButtonAddClient
            // 
            this.ButtonAddClient.Location = new System.Drawing.Point(93, 27);
            this.ButtonAddClient.Name = "ButtonAddClient";
            this.ButtonAddClient.Size = new System.Drawing.Size(75, 68);
            this.ButtonAddClient.TabIndex = 3;
            this.ButtonAddClient.Text = "Add Client";
            this.ButtonAddClient.UseVisualStyleBackColor = true;
            this.ButtonAddClient.Click += new System.EventHandler(this.ButtonAddClient_Click);
            // 
            // ButtonClientTests
            // 
            this.ButtonClientTests.Location = new System.Drawing.Point(174, 27);
            this.ButtonClientTests.Name = "ButtonClientTests";
            this.ButtonClientTests.Size = new System.Drawing.Size(75, 68);
            this.ButtonClientTests.TabIndex = 4;
            this.ButtonClientTests.Text = "Client Tests";
            this.ButtonClientTests.UseVisualStyleBackColor = true;
            this.ButtonClientTests.Click += new System.EventHandler(this.ButtonClientTests_Click);
            // 
            // ButtonMyAccount
            // 
            this.ButtonMyAccount.Location = new System.Drawing.Point(336, 27);
            this.ButtonMyAccount.Name = "ButtonMyAccount";
            this.ButtonMyAccount.Size = new System.Drawing.Size(75, 68);
            this.ButtonMyAccount.TabIndex = 5;
            this.ButtonMyAccount.Text = "My Account";
            this.ButtonMyAccount.UseVisualStyleBackColor = true;
            this.ButtonMyAccount.Click += new System.EventHandler(this.ButtonMyAccount_Click);
            // 
            // buttonAdminArea
            // 
            this.buttonAdminArea.Enabled = false;
            this.buttonAdminArea.Location = new System.Drawing.Point(417, 27);
            this.buttonAdminArea.Name = "buttonAdminArea";
            this.buttonAdminArea.Size = new System.Drawing.Size(75, 68);
            this.buttonAdminArea.TabIndex = 6;
            this.buttonAdminArea.Text = "Admin Area";
            this.buttonAdminArea.UseVisualStyleBackColor = true;
            this.buttonAdminArea.Click += new System.EventHandler(this.buttonAdminArea_Click);
            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.labelaccesslevel);
            this.groupBoxUserInfo.Controls.Add(this.labelUsername);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(498, 27);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(82, 68);
            this.groupBoxUserInfo.TabIndex = 7;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "Who Am I?";
            // 
            // labelaccesslevel
            // 
            this.labelaccesslevel.AutoSize = true;
            this.labelaccesslevel.Location = new System.Drawing.Point(7, 43);
            this.labelaccesslevel.Name = "labelaccesslevel";
            this.labelaccesslevel.Size = new System.Drawing.Size(71, 13);
            this.labelaccesslevel.TabIndex = 1;
            this.labelaccesslevel.Text = "Access Level";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(7, 20);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.webHelpToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            // 
            // webHelpToolStripMenuItem
            // 
            this.webHelpToolStripMenuItem.Name = "webHelpToolStripMenuItem";
            this.webHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.webHelpToolStripMenuItem.Text = "Web Help";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 129);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxUserInfo);
            this.Controls.Add(this.buttonAdminArea);
            this.Controls.Add(this.ButtonMyAccount);
            this.Controls.Add(this.ButtonClientTests);
            this.Controls.Add(this.ButtonAddClient);
            this.Controls.Add(this.ButtonClientList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin";
            this.Text = "Control Center";
            this.Load += new System.EventHandler(this.admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxUserInfo.ResumeLayout(false);
            this.groupBoxUserInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button ButtonClientList;
        private System.Windows.Forms.Button ButtonAddClient;
        private System.Windows.Forms.Button ButtonClientTests;
        private System.Windows.Forms.Button ButtonMyAccount;
        private System.Windows.Forms.Button buttonAdminArea;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.Label labelaccesslevel;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webHelpToolStripMenuItem;
    }
}