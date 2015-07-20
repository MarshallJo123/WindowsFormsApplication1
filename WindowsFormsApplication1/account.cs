using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            //START PULL USER INFO FROM PROPERTIES FILE
            textBoxUsername.Text = Properties.Settings.Default.username;
            textBoxAccessLevel.Text = Properties.Settings.Default.a_level.ToString();
            //END PULL USER INFO FROM PROPERTIES FILE

            //START INDETIFY USER LEVEL AND ASSIGN WORDED ROLE
            if (textBoxAccessLevel.Text == "0")
            {
                textBoxAccessType.Text = "Standard User";
            }
            else if (textBoxAccessLevel.Text == "1")
            {
                textBoxAccessType.Text = "Administrator Account";
            }
            //END INDETIFY USER LEVEL AND ASSIGN WORDED ROLE
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            stepEntities db = new stepEntities(); //PULL EF
            
            //START UPDATE USER PASSWORD 
            var query = from staff in db.staff1 where staff.username == textBoxUsername.Text select staff;

            foreach (var tables in query)
            {
                tables.password = textBoxChangePassword.Text;
            }
            db.SaveChanges();
            //END UPDATE USER PASSWORD
            MessageBox.Show("Your Password Has Been Changed, These Settings Will Take Impact The Next Time You Logon"); //START MESSAGE BOX CONFIRMING CHANGE

            textBoxChangePassword.Text = "";//START CLEAR PASSWORD BOX
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            admin admin = new admin();
            admin.Show();
            this.Hide();
            //END SHOW ADD CLIENT FORM
        }
    }
}
