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
    public partial class clientlist : Form
    {
        public clientlist()
        {
            InitializeComponent();
        }
        //START DEFINE USED STRINGS
        string firstname, lastname;
        int id;
        //END DEFINE USED STRINGS

        stepEntities db = new stepEntities();//PULL EF

        private void clientlist_Load(object sender, EventArgs e)
        {
            //START QUERY FOR CLIENT NAMES
            var query = from clients in db.clients
                        select clients; // create query

            foreach (var client in query) //DISPLAY IN DROPDOWN
            {
                comboBoxSelClient.Items.Add(client.firstname + " " + client.lastname);

            }
            //END QUERY FOR CLIENT NAMES
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //START DEFINE STRING PARTS
            string[] names = comboBoxSelClient.Text.Split(' ');
            firstname = names[0];
            lastname = names[1];
            //END DEFINE STRING PARTS
            //START QUERY BASED ON CHOSEN USER  TO FIND ID
            var query = from clients in db.clients
                        where clients.firstname == firstname && clients.lastname == lastname
                        select clients; // create query

            foreach (var client in query) // ADD CLIENT ID TO THE INT
            {
                id = client.client_id;
             
            }
            //END QUERY BASED ON CHOSEN USER  TO FIND ID
            //START QUERY FOR CLIENT INFORMATION BASED ON CLIENT ID
            var query1 = from clients in db.clients
                        where clients.client_id == id
                        select clients; // create query

            foreach (var client in query1) //ADD CLIENT INFO TO TEXT BOXES
            {
                textBoxFirst.Text = client.firstname;
                textBoxLast.Text = client.lastname;
                textBoxAge.Text = client.age.ToString();
                textBoxMobile.Text = client.phonenumber;
                textBoxHome.Text = client.housenumber;
            }
            //END QUERY FOR CLIENT INFORMATION BASED ON CLIENT ID
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //START QUERY FOR CLIENT INFORMATION BASED ON CLIENT ID
            var query = from clients in db.clients
                        where clients.client_id == id
                        select clients; // create query

            foreach (var client in query) //ADD CLIENT INFO TO TEXT BOXES
            {
                textBoxFirst.Text = client.firstname;
                textBoxLast.Text = client.lastname;
                textBoxAge.Text = client.age.ToString();
                textBoxMobile.Text = client.phonenumber;
                textBoxHome.Text = client.housenumber;
            }
            //END QUERY FOR CLIENT INFORMATION BASED ON CLIENT ID
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
