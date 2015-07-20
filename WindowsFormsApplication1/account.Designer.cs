namespace WindowsFormsApplication1
{
    partial class account
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxAccessLevel = new System.Windows.Forms.TextBox();
            this.labelALevel = new System.Windows.Forms.Label();
            this.textBoxAccessType = new System.Windows.Forms.TextBox();
            this.labelAccessType = new System.Windows.Forms.Label();
            this.textBoxChangePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Admin";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 296);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(210, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 6;
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
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(12, 61);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 20);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Enabled = false;
            this.textBoxUsername.Location = new System.Drawing.Point(16, 84);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(183, 20);
            this.textBoxUsername.TabIndex = 10;
            // 
            // textBoxAccessLevel
            // 
            this.textBoxAccessLevel.Enabled = false;
            this.textBoxAccessLevel.Location = new System.Drawing.Point(16, 130);
            this.textBoxAccessLevel.Name = "textBoxAccessLevel";
            this.textBoxAccessLevel.Size = new System.Drawing.Size(183, 20);
            this.textBoxAccessLevel.TabIndex = 12;
            // 
            // labelALevel
            // 
            this.labelALevel.AutoSize = true;
            this.labelALevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelALevel.Location = new System.Drawing.Point(12, 107);
            this.labelALevel.Name = "labelALevel";
            this.labelALevel.Size = new System.Drawing.Size(102, 20);
            this.labelALevel.TabIndex = 11;
            this.labelALevel.Text = "Access Level";
            // 
            // textBoxAccessType
            // 
            this.textBoxAccessType.Enabled = false;
            this.textBoxAccessType.Location = new System.Drawing.Point(16, 176);
            this.textBoxAccessType.Name = "textBoxAccessType";
            this.textBoxAccessType.Size = new System.Drawing.Size(183, 20);
            this.textBoxAccessType.TabIndex = 14;
            // 
            // labelAccessType
            // 
            this.labelAccessType.AutoSize = true;
            this.labelAccessType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccessType.Location = new System.Drawing.Point(12, 153);
            this.labelAccessType.Name = "labelAccessType";
            this.labelAccessType.Size = new System.Drawing.Size(99, 20);
            this.labelAccessType.TabIndex = 13;
            this.labelAccessType.Text = "Access Type";
            // 
            // textBoxChangePassword
            // 
            this.textBoxChangePassword.Location = new System.Drawing.Point(16, 235);
            this.textBoxChangePassword.Name = "textBoxChangePassword";
            this.textBoxChangePassword.Size = new System.Drawing.Size(183, 20);
            this.textBoxChangePassword.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Change Password";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(17, 261);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(181, 23);
            this.buttonChangePassword.TabIndex = 18;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(210, 318);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 196;
            this.lineShape1.Y1 = 200;
            this.lineShape1.Y2 = 200;
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 318);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxChangePassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAccessType);
            this.Controls.Add(this.labelAccessType);
            this.Controls.Add(this.textBoxAccessLevel);
            this.Controls.Add(this.labelALevel);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "account";
            this.Text = "Account Management";
            this.Load += new System.EventHandler(this.account_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxAccessLevel;
        private System.Windows.Forms.Label labelALevel;
        private System.Windows.Forms.TextBox textBoxAccessType;
        private System.Windows.Forms.Label labelAccessType;
        private System.Windows.Forms.TextBox textBoxChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}