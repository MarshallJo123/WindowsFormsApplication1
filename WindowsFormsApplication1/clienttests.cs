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
    public partial class clienttests : Form
    {
        public clienttests()
        {
            InitializeComponent();
        }
        //DATABASE INFO FOR PROGRAM
        string firstname, lastname;
        int id;
        int test_number;
        //END DATABASE INFO FOR PROGRAM

        stepEntities db = new stepEntities();

        private void clienttests_Load(object sender, EventArgs e)
        {
            //START SELECT CLIENT FULL NAME
            var query = from clients in db.clients
                        select clients; // create query

            foreach (var client in query)
            {
                comboBoxChooseClient.Items.Add(client.firstname + " " + client.lastname);
            }
            //END SELECT CLIENT FULL NAME
        }

        private void comboBoxChooseClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //START FIND SELECTED CLIENT'S ID FROM DATABASE
            string[] names = comboBoxChooseClient.Text.Split(' ');
            firstname = names[0];
            lastname = names[1];

            var query = from clients in db.clients
                        where clients.firstname == firstname && clients.lastname == lastname
                        select clients; // create query

            foreach (var client in query)//DEFINE CLIENT ID TO LOCAL INT
            {
                id = client.client_id;

            }
            textBoxClientID.Text = id.ToString();
            //END FIND SELECTED CLIENT'S ID FROM DATABASE
        }
        
        private void buttonTestNumbers_Click(object sender, EventArgs e)
        {
            //START FIND TEST NUMBERS
            var query1 = from test in db.tests where test.client_id == id select test;

            foreach (var testno in query1)
            {
                comboBoxTestNo.Items.Add(testno.test_number);
            }
            //START FIND TEST NUMBERS

            comboBoxChooseClient.Enabled = false; //disable field
        }     

        private void buttonFind_Click(object sender, EventArgs e)
        {
            test_number = int.Parse(comboBoxTestNo.Text);
            // START FIND TEST RESULTS FROM DROPDOWN
            var query2 = from test in db.tests where test.test_number == test_number select test;

            foreach (var testno in query2)
            {
                textBoxTD.Text = testno.test_date;
                textBoxAC.Text = testno.ac.ToString();
                textBoxFR.Text = testno.fitnessrating;
                richTextBoxNotes.Text = testno.notes;
            }
            //END FIND TEST RESULTS FROM DROPDOWN
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW SIGN IN FORM
            admin admin = new admin();
            admin.Show();
            //END SHOW SIGN IN FORM
            this.Close();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            addclient adcli = new addclient();
            adcli.Show();
            //END SHOW ADD CLIENT FORM
        }           
    }
}
