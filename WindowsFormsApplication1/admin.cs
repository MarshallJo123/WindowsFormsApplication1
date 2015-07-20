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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        stepEntities db = new stepEntities(); //USED TO CONNECT TO DATABASE

        string username; //USED TO STORE USERNAME FOR THE CURRENT USER
        int a_level; //USED TO STORE THE ACCESS LEVEL FOR THE USER

        private void admin_Load(object sender, EventArgs e)
        {
            //START DEFINE USERNAME FOR PROGRAM
            if (Properties.Settings.Default.username != null)
            {
                labelUsername.Text = Properties.Settings.Default.username;
                username = Properties.Settings.Default.username;
            }
            //START DEFINE USERNAME FOR PROGRAM
            //START QUERY FOR USER ACCESS LEVEL
            var query = from staffs in db.staff1 where staffs.username == labelUsername.Text select staffs;
            foreach (var pulllevel in query)
            {
                a_level = pulllevel.a_level;
                Properties.Settings.Default.a_level = pulllevel.a_level;
            }
            //END QUERY FOR USER ACCESS LEVEL
            //START SHOW USER ACCESS LEVEL
            if (a_level == 1)
            {
                labelaccesslevel.Text = "Administrator";
            }
            else
            {
                labelaccesslevel.Text = "User";
            }
            //END SHOW USER ACCESS LEVEL
            //START ENABLE ADMIN AREA DEPENDING ON USER
            if (a_level == 1)
            {
                buttonAdminArea.Enabled = true;
            }
            else
            {
                buttonAdminArea.Enabled = false;
            }
            //END ENABLE ADMIN AREA DEPENDING ON USER
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            addclient adcli = new addclient();
            adcli.Show();
            this.Hide();
            //END SHOW ADD CLIENT FORM
        }

        private void ButtonClientList_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            clientlist clilst = new clientlist();
            clilst.Show();
            this.Hide();
            //END SHOW ADD CLIENT FORM
        }

        private void ButtonMyAccount_Click(object sender, EventArgs e)
        {
            //START SHOW ACCOUNT FORM
            account account = new account();
            account.Show();
            this.Hide();
            //END SHOW ACCOUNT FORM
        }

        private void buttonAdminArea_Click(object sender, EventArgs e)
        {
            //START SHOW ACCOUNT FORM
            adminAreacs adminarea = new adminAreacs();
            adminarea.Show();
            this.Hide();
            //END SHOW ACCOUNT FORM
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //START SHOW start test FORM
            starttest starttest = new starttest();
            starttest.Show();
            this.Hide();
            //END SHOW start test FORM
        }

        private void ButtonClientTests_Click(object sender, EventArgs e)
        {
            //START SHOW start test FORM
            clienttests clienttests = new clienttests();
            clienttests.Show();
            this.Hide();
            //END SHOW start test FORM
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void howToUseThisAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW SIGN IN FORM
            login login = new login();
            login.Show();
            //END SHOW SIGN IN FORM
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
