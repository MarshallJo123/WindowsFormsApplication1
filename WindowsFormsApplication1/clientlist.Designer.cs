namespace WindowsFormsApplication1
{
    partial class clientlist
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxHome = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.textBoxFirst = new System.Windows.Forms.TextBox();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.comboBoxSelClient = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client List";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(259, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 24);
            this.menuStrip1.TabIndex = 3;
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
            // textBoxHome
            // 
            this.textBoxHome.Enabled = false;
            this.textBoxHome.Location = new System.Drawing.Point(83, 165);
            this.textBoxHome.Name = "textBoxHome";
            this.textBoxHome.Size = new System.Drawing.Size(164, 20);
            this.textBoxHome.TabIndex = 22;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(11, 122);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 21;
            this.labelAge.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Enabled = false;
            this.textBoxAge.Location = new System.Drawing.Point(83, 119);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(164, 20);
            this.textBoxAge.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Home No";
            // 
            // textBoxMobile
            // 
            this.textBoxMobile.Enabled = false;
            this.textBoxMobile.Location = new System.Drawing.Point(83, 143);
            this.textBoxMobile.Name = "textBoxMobile";
            this.textBoxMobile.Size = new System.Drawing.Size(164, 20);
            this.textBoxMobile.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mobile No";
            // 
            // textBoxLast
            // 
            this.textBoxLast.Enabled = false;
            this.textBoxLast.Location = new System.Drawing.Point(83, 93);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(164, 20);
            this.textBoxLast.TabIndex = 16;
            // 
            // textBoxFirst
            // 
            this.textBoxFirst.Enabled = false;
            this.textBoxFirst.Location = new System.Drawing.Point(83, 72);
            this.textBoxFirst.Name = "textBoxFirst";
            this.textBoxFirst.Size = new System.Drawing.Size(164, 20);
            this.textBoxFirst.TabIndex = 15;
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(11, 96);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(58, 13);
            this.LabelLastName.TabIndex = 14;
            this.LabelLastName.Text = "Last Name";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(11, 72);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(57, 13);
            this.LabelFirstName.TabIndex = 13;
            this.LabelFirstName.Text = "First Name";
            // 
            // comboBoxSelClient
            // 
            this.comboBoxSelClient.FormattingEnabled = true;
            this.comboBoxSelClient.Location = new System.Drawing.Point(84, 45);
            this.comboBoxSelClient.Name = "comboBoxSelClient";
            this.comboBoxSelClient.Size = new System.Drawing.Size(164, 21);
            this.comboBoxSelClient.TabIndex = 23;
            this.comboBoxSelClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Select Client";
            // 
            // clientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 218);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSelClient);
            this.Controls.Add(this.textBoxHome);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLast);
            this.Controls.Add(this.textBoxFirst);
            this.Controls.Add(this.LabelLastName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "clientlist";
            this.Text = "Client List";
            this.Load += new System.EventHandler(this.clientlist_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxHome;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.TextBox textBoxFirst;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.ComboBox comboBoxSelClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        //private stepDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}