namespace WindowsFormsApplication1
{
    partial class starttest
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
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxChooseClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaxHR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMaxHR80 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTestDate = new System.Windows.Forms.Label();
            this.dateTimePickerTestDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton15cm = new System.Windows.Forms.RadioButton();
            this.radioButton20cm = new System.Windows.Forms.RadioButton();
            this.radioButton25cm = new System.Windows.Forms.RadioButton();
            this.radioButton30cm = new System.Windows.Forms.RadioButton();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonCheckComplete = new System.Windows.Forms.Button();
            this.listViewStoredInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddResult = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.richTextBoxNotes = new System.Windows.Forms.RichTextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxACP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabelSyncStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Start Client Test";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSyncStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(324, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.otherToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(324, 24);
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
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.viewResultsToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addClientToolStripMenuItem.Text = "Add Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // viewResultsToolStripMenuItem
            // 
            this.viewResultsToolStripMenuItem.Name = "viewResultsToolStripMenuItem";
            this.viewResultsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.viewResultsToolStripMenuItem.Text = "View Results";
            this.viewResultsToolStripMenuItem.Click += new System.EventHandler(this.viewResultsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Enabled = false;
            this.textBoxClientID.Location = new System.Drawing.Point(123, 71);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(189, 20);
            this.textBoxClientID.TabIndex = 18;
            this.textBoxClientID.Text = "Client ID Displays Here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Choosen Clients ID";
            // 
            // comboBoxChooseClient
            // 
            this.comboBoxChooseClient.FormattingEnabled = true;
            this.comboBoxChooseClient.Location = new System.Drawing.Point(90, 47);
            this.comboBoxChooseClient.Name = "comboBoxChooseClient";
            this.comboBoxChooseClient.Size = new System.Drawing.Size(222, 21);
            this.comboBoxChooseClient.TabIndex = 16;
            this.comboBoxChooseClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseClient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose Client";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Enabled = false;
            this.textBoxAge.Location = new System.Drawing.Point(123, 97);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(189, 20);
            this.textBoxAge.TabIndex = 20;
            this.textBoxAge.Text = "Client Age Displays Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Choosen Clients Age";
            // 
            // textBoxMaxHR
            // 
            this.textBoxMaxHR.Enabled = false;
            this.textBoxMaxHR.Location = new System.Drawing.Point(123, 149);
            this.textBoxMaxHR.Name = "textBoxMaxHR";
            this.textBoxMaxHR.Size = new System.Drawing.Size(189, 20);
            this.textBoxMaxHR.TabIndex = 22;
            this.textBoxMaxHR.Text = "Client MaxHR Displays Here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Clients MaxHr";
            // 
            // textBoxMaxHR80
            // 
            this.textBoxMaxHR80.Enabled = false;
            this.textBoxMaxHR80.Location = new System.Drawing.Point(123, 175);
            this.textBoxMaxHR80.Name = "textBoxMaxHR80";
            this.textBoxMaxHR80.Size = new System.Drawing.Size(189, 20);
            this.textBoxMaxHR80.TabIndex = 24;
            this.textBoxMaxHR80.Text = "Client 80% MaxHR Displays Here";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Clients MaxHr 80%";
            // 
            // labelTestDate
            // 
            this.labelTestDate.AutoSize = true;
            this.labelTestDate.Location = new System.Drawing.Point(12, 204);
            this.labelTestDate.Name = "labelTestDate";
            this.labelTestDate.Size = new System.Drawing.Size(80, 13);
            this.labelTestDate.TabIndex = 25;
            this.labelTestDate.Text = "Client TestDate";
            // 
            // dateTimePickerTestDate
            // 
            this.dateTimePickerTestDate.Location = new System.Drawing.Point(123, 202);
            this.dateTimePickerTestDate.Name = "dateTimePickerTestDate";
            this.dateTimePickerTestDate.Size = new System.Drawing.Size(189, 20);
            this.dateTimePickerTestDate.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Step Height (CM)";
            // 
            // radioButton15cm
            // 
            this.radioButton15cm.AutoSize = true;
            this.radioButton15cm.Location = new System.Drawing.Point(123, 230);
            this.radioButton15cm.Name = "radioButton15cm";
            this.radioButton15cm.Size = new System.Drawing.Size(37, 17);
            this.radioButton15cm.TabIndex = 28;
            this.radioButton15cm.TabStop = true;
            this.radioButton15cm.Text = "15";
            this.radioButton15cm.UseVisualStyleBackColor = true;
            // 
            // radioButton20cm
            // 
            this.radioButton20cm.AutoSize = true;
            this.radioButton20cm.Location = new System.Drawing.Point(166, 230);
            this.radioButton20cm.Name = "radioButton20cm";
            this.radioButton20cm.Size = new System.Drawing.Size(37, 17);
            this.radioButton20cm.TabIndex = 29;
            this.radioButton20cm.TabStop = true;
            this.radioButton20cm.Text = "20";
            this.radioButton20cm.UseVisualStyleBackColor = true;
            // 
            // radioButton25cm
            // 
            this.radioButton25cm.AutoSize = true;
            this.radioButton25cm.Location = new System.Drawing.Point(209, 230);
            this.radioButton25cm.Name = "radioButton25cm";
            this.radioButton25cm.Size = new System.Drawing.Size(37, 17);
            this.radioButton25cm.TabIndex = 30;
            this.radioButton25cm.TabStop = true;
            this.radioButton25cm.Text = "25";
            this.radioButton25cm.UseVisualStyleBackColor = true;
            // 
            // radioButton30cm
            // 
            this.radioButton30cm.AutoSize = true;
            this.radioButton30cm.Location = new System.Drawing.Point(252, 230);
            this.radioButton30cm.Name = "radioButton30cm";
            this.radioButton30cm.Size = new System.Drawing.Size(37, 17);
            this.radioButton30cm.TabIndex = 31;
            this.radioButton30cm.TabStop = true;
            this.radioButton30cm.Text = "30";
            this.radioButton30cm.UseVisualStyleBackColor = true;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Enabled = false;
            this.textBoxGender.Location = new System.Drawing.Point(123, 123);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(189, 20);
            this.textBoxGender.TabIndex = 33;
            this.textBoxGender.Text = "Client Gender Displays Here";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Clients Gender";
            // 
            // buttonCheckComplete
            // 
            this.buttonCheckComplete.Location = new System.Drawing.Point(15, 253);
            this.buttonCheckComplete.Name = "buttonCheckComplete";
            this.buttonCheckComplete.Size = new System.Drawing.Size(297, 23);
            this.buttonCheckComplete.TabIndex = 34;
            this.buttonCheckComplete.Text = "Client Checks Complete?";
            this.buttonCheckComplete.UseVisualStyleBackColor = true;
            this.buttonCheckComplete.Click += new System.EventHandler(this.buttonCheckComplete_Click);
            // 
            // listViewStoredInfo
            // 
            this.listViewStoredInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewStoredInfo.Location = new System.Drawing.Point(15, 282);
            this.listViewStoredInfo.Name = "listViewStoredInfo";
            this.listViewStoredInfo.Size = new System.Drawing.Size(171, 97);
            this.listViewStoredInfo.TabIndex = 37;
            this.listViewStoredInfo.UseCompatibleStateImageBehavior = false;
            this.listViewStoredInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Step Level";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Heart Rate";
            // 
            // buttonAddResult
            // 
            this.buttonAddResult.Location = new System.Drawing.Point(192, 308);
            this.buttonAddResult.Name = "buttonAddResult";
            this.buttonAddResult.Size = new System.Drawing.Size(120, 23);
            this.buttonAddResult.TabIndex = 36;
            this.buttonAddResult.Text = "Add Result";
            this.buttonAddResult.UseVisualStyleBackColor = true;
            this.buttonAddResult.Click += new System.EventHandler(this.buttonAddResult_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.AcceptsReturn = true;
            this.textBoxResult.Location = new System.Drawing.Point(192, 282);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(120, 20);
            this.textBoxResult.TabIndex = 35;
            this.textBoxResult.Tag = "";
            this.textBoxResult.Text = "Results";
            // 
            // richTextBoxNotes
            // 
            this.richTextBoxNotes.Location = new System.Drawing.Point(15, 385);
            this.richTextBoxNotes.Name = "richTextBoxNotes";
            this.richTextBoxNotes.Size = new System.Drawing.Size(297, 161);
            this.richTextBoxNotes.TabIndex = 38;
            this.richTextBoxNotes.Text = "Notes:";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(15, 552);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(297, 23);
            this.buttonCalc.TabIndex = 39;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(194, 338);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(106, 26);
            this.labelInfo.TabIndex = 40;
            this.labelInfo.Text = "Enter Fitness Results\r\nHere";
            // 
            // textBoxACP
            // 
            this.textBoxACP.Enabled = false;
            this.textBoxACP.Location = new System.Drawing.Point(123, 581);
            this.textBoxACP.Name = "textBoxACP";
            this.textBoxACP.Size = new System.Drawing.Size(189, 20);
            this.textBoxACP.TabIndex = 42;
            this.textBoxACP.Text = "Aerobic Capacity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 26);
            this.label9.TabIndex = 41;
            this.label9.Text = "Aerobic Capacity\r\n  (mlsO2/kg/min)";
            // 
            // textBoxFR
            // 
            this.textBoxFR.Enabled = false;
            this.textBoxFR.Location = new System.Drawing.Point(123, 614);
            this.textBoxFR.Name = "textBoxFR";
            this.textBoxFR.Size = new System.Drawing.Size(189, 20);
            this.textBoxFR.TabIndex = 44;
            this.textBoxFR.Text = "Fitness Rating";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 617);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Fitness Rating";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripStatusLabelSyncStatus
            // 
            this.toolStripStatusLabelSyncStatus.Name = "toolStripStatusLabelSyncStatus";
            this.toolStripStatusLabelSyncStatus.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabelSyncStatus.Text = "Sync Status";
            // 
            // starttest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 676);
            this.Controls.Add(this.textBoxFR);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxACP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.richTextBoxNotes);
            this.Controls.Add(this.listViewStoredInfo);
            this.Controls.Add(this.buttonAddResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCheckComplete);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButton30cm);
            this.Controls.Add(this.radioButton25cm);
            this.Controls.Add(this.radioButton20cm);
            this.Controls.Add(this.radioButton15cm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerTestDate);
            this.Controls.Add(this.labelTestDate);
            this.Controls.Add(this.textBoxMaxHR80);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMaxHR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxChooseClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "starttest";
            this.Text = "Start A New Test";
            this.Load += new System.EventHandler(this.starttest_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxChooseClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaxHR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMaxHR80;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTestDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTestDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton15cm;
        private System.Windows.Forms.RadioButton radioButton20cm;
        private System.Windows.Forms.RadioButton radioButton25cm;
        private System.Windows.Forms.RadioButton radioButton30cm;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonCheckComplete;
        private System.Windows.Forms.ListView listViewStoredInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonAddResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.RichTextBox richTextBoxNotes;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxACP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSyncStatus;
    }
}