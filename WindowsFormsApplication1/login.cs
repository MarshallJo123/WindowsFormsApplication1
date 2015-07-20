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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        stepEntities db = new stepEntities(); // PULL EF
       
        private void login_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = Properties.Settings.Default.username;
            textBoxPassword.Text = Properties.Settings.Default.password;
        }

        private bool validUser(string UserName, string PassWord)
        {
            var querylogins = from staff in db.staff1 where staff.username == textBoxUsername.Text && staff.password == textBoxPassword.Text select staff;

            if (querylogins.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validUser(textBoxUsername.Text, textBoxPassword.Text))
            {
                Properties.Settings.Default.username = textBoxUsername.Text;

                //START SHOW ADMIN FORM
                admin frm = new admin();
                frm.Show();
                //END SHOW ADMIN FORM
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, Please Try Again");
            }
        }

        private void CheckBoxRemeber_CheckedChanged(object sender, EventArgs e)
        {
            //START SAVE USER INFO BASED ON IF CHECKBOX IS EQUAL TO TRUE
            if (CheckBoxRemeber.Checked == true)
            {
                Properties.Settings.Default.username = textBoxUsername.Text;
                Properties.Settings.Default.password = textBoxPassword.Text;
                Properties.Settings.Default.Save();
            }
            else //IF IS NOT ERASE SETTINGS
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }
            //END SAVE USER INFO BASED ON IF CHECKBOX IS EQUAL TO TRUE
        }
    }
}
