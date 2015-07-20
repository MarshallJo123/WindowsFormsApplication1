namespace WindowsFormsApplication1
{
    partial class adminAreacs
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
            this.LabelHeader = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControladmin = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBoxDis = new System.Windows.Forms.RichTextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.comboBoxALevel = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelA_Level = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.comboBoxSelectClient = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControladmin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.Location = new System.Drawing.Point(11, 24);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(110, 24);
            this.LabelHeader.TabIndex = 11;
            this.LabelHeader.Text = "Admin Area";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 328);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(273, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(273, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // tabControladmin
            // 
            this.tabControladmin.Controls.Add(this.tabPage2);
            this.tabControladmin.Controls.Add(this.tabPage1);
            this.tabControladmin.Controls.Add(this.tabPage3);
            this.tabControladmin.Location = new System.Drawing.Point(12, 51);
            this.tabControladmin.Name = "tabControladmin";
            this.tabControladmin.SelectedIndex = 0;
            this.tabControladmin.Size = new System.Drawing.Size(258, 274);
            this.tabControladmin.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBoxDis);
            this.tabPage2.Controls.Add(this.buttonAddUser);
            this.tabPage2.Controls.Add(this.comboBoxALevel);
            this.tabPage2.Controls.Add(this.textBoxPassword);
            this.tabPage2.Controls.Add(this.textBoxUsername);
            this.tabPage2.Controls.Add(this.labelA_Level);
            this.tabPage2.Controls.Add(this.labelPassword);
            this.tabPage2.Controls.Add(this.labelUsername);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDis
            // 
            this.richTextBoxDis.Enabled = false;
            this.richTextBoxDis.Location = new System.Drawing.Point(6, 115);
            this.richTextBoxDis.Name = "richTextBoxDis";
            this.richTextBoxDis.Size = new System.Drawing.Size(231, 127);
            this.richTextBoxDis.TabIndex = 7;
            this.richTextBoxDis.Text = "The Different Account Types:\n\nAdministrator: Can Access All Tabs In The Admin Pan" +
    "el\n\nStandard User: Can Access All Tabs Except the Admin Area\n";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(6, 86);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(231, 23);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // comboBoxALevel
            // 
            this.comboBoxALevel.FormattingEnabled = true;
            this.comboBoxALevel.Items.AddRange(new object[] {
            "Administrator",
            "Standard User"});
            this.comboBoxALevel.Location = new System.Drawing.Point(116, 59);
            this.comboBoxALevel.Name = "comboBoxALevel";
            this.comboBoxALevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxALevel.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(96, 32);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(141, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(97, 6);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(140, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelA_Level
            // 
            this.labelA_Level.AutoSize = true;
            this.labelA_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA_Level.Location = new System.Drawing.Point(7, 57);
            this.labelA_Level.Name = "labelA_Level";
            this.labelA_Level.Size = new System.Drawing.Size(102, 20);
            this.labelA_Level.TabIndex = 2;
            this.labelA_Level.Text = "Access Level";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(7, 32);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(7, 7);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.comboBoxUsers);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 248);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Delete User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(13, 100);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(215, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(87, 73);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(141, 21);
            this.comboBoxUsers.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select a User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 60);
            this.label4.TabIndex = 0;
            this.label4.Text = "Please Note: \r\nThis action cannot be undone.\r\n\r\n";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteClient);
            this.tabPage3.Controls.Add(this.comboBoxSelectClient);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.labelWarning);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(250, 248);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Delete Client";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Location = new System.Drawing.Point(13, 79);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(218, 23);
            this.buttonDeleteClient.TabIndex = 6;
            this.buttonDeleteClient.Text = "Delete";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // comboBoxSelectClient
            // 
            this.comboBoxSelectClient.FormattingEnabled = true;
            this.comboBoxSelectClient.Location = new System.Drawing.Point(90, 52);
            this.comboBoxSelectClient.Name = "comboBoxSelectClient";
            this.comboBoxSelectClient.Size = new System.Drawing.Size(141, 21);
            this.comboBoxSelectClient.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Select a Client";
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.Location = new System.Drawing.Point(6, 3);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(222, 60);
            this.labelWarning.TabIndex = 1;
            this.labelWarning.Text = "Please Note: \r\nThis action cannot be undone.\r\n\r\n";
            // 
            // adminAreacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 350);
            this.Controls.Add(this.tabControladmin);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "adminAreacs";
            this.Text = "Administration Area";
            this.Load += new System.EventHandler(this.adminAreacs_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControladmin.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControladmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxALevel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelA_Level;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.RichTextBox richTextBoxDis;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.ComboBox comboBoxSelectClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}