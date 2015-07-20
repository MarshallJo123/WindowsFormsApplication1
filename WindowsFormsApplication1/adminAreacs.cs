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
    public partial class adminAreacs : Form
    {
        public adminAreacs()
        {
            InitializeComponent();
        }
        //START DEFINE USED INTS AND STRINGS
        int a_level;
        int id;
        string username;
        string username_del;

        string firstname, lastname;
        //END DEFINE USED INTS AND STRINGS
        stepEntities db = new stepEntities();//PULL EF

        private void adminAreacs_Load(object sender, EventArgs e)
        {
            //START PULL STAFF USERNAMES FROM DATABASE
            var query = from staffs in db.staff1 select staffs;
            
            foreach (var staff in query)
            {
                comboBoxUsers.Items.Add(staff.username);
            }
            //END PULL STAFF USERNAMES FROM DATABASE
            //START PULL CLIENT FIRST AND LAST NAMES FROM DATABASE
            var query1 = from clients in db.clients
                        select clients; // create query

            foreach (var clients in query1)
            {
                comboBoxSelectClient.Items.Add(clients.firstname + " " + clients.lastname);

            }
            //END PULL CLIENT FIRST AND LAST NAMES FROM DATABASE
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            //START DEFINE STAFF LEVEL BASED ON USER LEVEL
            if (comboBoxALevel.SelectedText == "Administrator")
            {
                a_level = 1;
            }
            else if (comboBoxALevel.SelectedText== "Standard User")
            { 
                a_level = 0;
            }
            //END DEFINE USER LEVEL BASED ON USER LEVEL
            //START ADD NEW STAFF MEMBER
            try
            {
                var register = new staff1
                {
                    username = textBoxUsername.Text,
                    password = textBoxPassword.Text,
                    a_level = a_level

                };

                db.staff1.Add(register);
                db.SaveChanges();
                //END ADD NEW STAFF MEMBER
                MessageBox.Show("Account Created"); //SHOW ACCOUNT HAS BEEN CREATED
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to create account, this account might be taken"); //SHOW ACCOUNT HAS NOT BEEN CREATED
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            } 

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //START MAKE IT UNABLE TO DELETE THE ADMIN USERNAME AND DELETE CHOSEN STAFF USERNAME
            if (comboBoxUsers.Text == "admin")
            {
                MessageBox.Show("You are unable to delete this user");
                buttonDelete.Enabled = false;
            }
            else
            {
                username = comboBoxUsers.Text;

                var rows = from staffs in db.staff1 where staffs.username == username select staffs;

                foreach (var row in rows)
                {
                    db.staff1.Remove(row);
                }
                db.SaveChanges();
                MessageBox.Show("User Has Been Deleted"); // SHOW USER HAS BEEN DELETED
            }
            //END MAKE IT UNABLE TO DELETE THE ADMIN USERNAME AND DELETE CHOSEN STAFF USERNAME
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            admin admin = new admin();
            admin.Show();
            this.Hide();
            //END SHOW ADD CLIENT FORM
        }

        private void buttonDeleteClient_Click(object sender, EventArgs e) //USED FOR DEL OF CLIENT
        {
            //START DEFINE STRING PARTS
            string[] names = comboBoxSelectClient.Text.Split(' ');
            firstname = names[0];
            lastname = names[1];
            //END DEFINE STRING PARTS

            //START QUERY BASED ON CHOSEN USER  TO FIND ID
            var delcli = from clients in db.clients where clients.firstname == firstname && clients.lastname == lastname select clients;

            foreach (var client in delcli) // ADD CLIENT ID TO THE INT
            {
                id = client.client_id;
            }
            //END QUERY BASED ON CHOSEN USER  TO FIND ID

            //START DEL CLIENT BASED ON CLIENT ID
            var clidelrow = from clients in db.clients where clients.client_id == id select clients;

            foreach (var row in clidelrow)
            {
                db.clients.Remove(row);
            }
            db.SaveChanges();
            MessageBox.Show("User Has Been Deleted"); // SHOW USER HAS BEEN DELETED
            //END DEL CLIENT BASED ON CLIENT ID
        } 
    }
}
