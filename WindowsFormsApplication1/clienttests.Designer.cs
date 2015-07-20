namespace WindowsFormsApplication1
{
    partial class clienttests
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelTestNo = new System.Windows.Forms.Label();
            this.comboBoxChooseClient = new System.Windows.Forms.ComboBox();
            this.comboBoxTestNo = new System.Windows.Forms.ComboBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.labelAC = new System.Windows.Forms.Label();
            this.labelFR = new System.Windows.Forms.Label();
            this.textBoxAC = new System.Windows.Forms.TextBox();
            this.textBoxFR = new System.Windows.Forms.TextBox();
            this.textBoxTD = new System.Windows.Forms.TextBox();
            this.labelTD = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelNotes = new System.Windows.Forms.Label();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.buttonTestNumbers = new System.Windows.Forms.Button();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client Tests";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(15, 52);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(72, 13);
            this.labelClientName.TabIndex = 9;
            this.labelClientName.Text = "Choose Client";
            // 
            // labelTestNo
            // 
            this.labelTestNo.AutoSize = true;
            this.labelTestNo.Location = new System.Drawing.Point(15, 129);
            this.labelTestNo.Name = "labelTestNo";
            this.labelTestNo.Size = new System.Drawing.Size(107, 13);
            this.labelTestNo.TabIndex = 11;
            this.labelTestNo.Text = "Choose Test Number";
            // 
            // comboBoxChooseClient
            // 
            this.comboBoxChooseClient.FormattingEnabled = true;
            this.comboBoxChooseClient.Location = new System.Drawing.Point(93, 49);
            this.comboBoxChooseClient.Name = "comboBoxChooseClient";
            this.comboBoxChooseClient.Size = new System.Drawing.Size(206, 21);
            this.comboBoxChooseClient.TabIndex = 10;
            this.comboBoxChooseClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseClient_SelectedIndexChanged);
            // 
            // comboBoxTestNo
            // 
            this.comboBoxTestNo.FormattingEnabled = true;
            this.comboBoxTestNo.Location = new System.Drawing.Point(128, 129);
            this.comboBoxTestNo.Name = "comboBoxTestNo";
            this.comboBoxTestNo.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTestNo.TabIndex = 12;
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Location = new System.Drawing.Point(15, 76);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(97, 13);
            this.labelClientID.TabIndex = 13;
            this.labelClientID.Text = "Choosen Clients ID";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Enabled = false;
            this.textBoxClientID.Location = new System.Drawing.Point(118, 73);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(181, 20);
            this.textBoxClientID.TabIndex = 14;
            this.textBoxClientID.Text = "Client ID Displays Here";
            // 
            // labelAC
            // 
            this.labelAC.AutoSize = true;
            this.labelAC.Location = new System.Drawing.Point(15, 206);
            this.labelAC.Name = "labelAC";
            this.labelAC.Size = new System.Drawing.Size(90, 26);
            this.labelAC.TabIndex = 15;
            this.labelAC.Text = "Aerobic Capacity \r\n   (mlsO2/kg/min)";
            // 
            // labelFR
            // 
            this.labelFR.AutoSize = true;
            this.labelFR.Location = new System.Drawing.Point(15, 244);
            this.labelFR.Name = "labelFR";
            this.labelFR.Size = new System.Drawing.Size(74, 13);
            this.labelFR.TabIndex = 16;
            this.labelFR.Text = "Fitness Rating";
            // 
            // textBoxAC
            // 
            this.textBoxAC.Enabled = false;
            this.textBoxAC.Location = new System.Drawing.Point(111, 209);
            this.textBoxAC.Name = "textBoxAC";
            this.textBoxAC.Size = new System.Drawing.Size(188, 20);
            this.textBoxAC.TabIndex = 17;
            this.textBoxAC.Text = "Aerobic Capacity Display Here";
            // 
            // textBoxFR
            // 
            this.textBoxFR.Enabled = false;
            this.textBoxFR.Location = new System.Drawing.Point(111, 241);
            this.textBoxFR.Name = "textBoxFR";
            this.textBoxFR.Size = new System.Drawing.Size(188, 20);
            this.textBoxFR.TabIndex = 18;
            this.textBoxFR.Text = "Fitness Rating Display Here";
            // 
            // textBoxTD
            // 
            this.textBoxTD.Enabled = false;
            this.textBoxTD.Location = new System.Drawing.Point(111, 179);
            this.textBoxTD.Name = "textBoxTD";
            this.textBoxTD.Size = new System.Drawing.Size(188, 20);
            this.textBoxTD.TabIndex = 20;
            this.textBoxTD.Text = "Test Date Display Here";
            // 
            // labelTD
            // 
            this.labelTD.AutoSize = true;
            this.labelTD.Location = new System.Drawing.Point(15, 182);
            this.labelTD.Name = "labelTD";
            this.labelTD.Size = new System.Drawing.Size(54, 13);
            this.labelTD.TabIndex = 19;
            this.labelTD.Text = "Test Date";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(18, 150);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(281, 23);
            this.buttonFind.TabIndex = 21;
            this.buttonFind.Text = "Find Record";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(15, 272);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(38, 13);
            this.labelNotes.TabIndex = 22;
            this.labelNotes.Text = "Notes:";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Enabled = false;
            this.richTextBoxNotes.Location = new System.Drawing.Point(18, 289);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(281, 149);
            this.richTextBoxNotes.TabIndex = 23;
            this.richTextBoxNotes.Text = "Clients test Notes Will Display Here";
            // 
            // buttonTestNumbers
            // 
            this.buttonTestNumbers.Location = new System.Drawing.Point(18, 98);
            this.buttonTestNumbers.Name = "buttonTestNumbers";
            this.buttonTestNumbers.Size = new System.Drawing.Size(281, 23);
            this.buttonTestNumbers.TabIndex = 24;
            this.buttonTestNumbers.Text = "Find Test Numbers";
            this.buttonTestNumbers.UseVisualStyleBackColor = true;
            this.buttonTestNumbers.Click += new System.EventHandler(this.buttonTestNumbers_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // clienttests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 463);
            this.Controls.Add(this.buttonTestNumbers);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.textBoxTD);
            this.Controls.Add(this.labelTD);
            this.Controls.Add(this.textBoxFR);
            this.Controls.Add(this.textBoxAC);
            this.Controls.Add(this.labelFR);
            this.Controls.Add(this.labelAC);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.comboBoxTestNo);
            this.Controls.Add(this.labelTestNo);
            this.Controls.Add(this.comboBoxChooseClient);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "clienttests";
            this.Text = "Client Tests";
            this.Load += new System.EventHandler(this.clienttests_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelTestNo;
        private System.Windows.Forms.ComboBox comboBoxChooseClient;
        private System.Windows.Forms.ComboBox comboBoxTestNo;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label labelAC;
        private System.Windows.Forms.Label labelFR;
        private System.Windows.Forms.TextBox textBoxAC;
        private System.Windows.Forms.TextBox textBoxFR;
        private System.Windows.Forms.TextBox textBoxTD;
        private System.Windows.Forms.Label labelTD;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Button buttonTestNumbers;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
    }
}