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
    public partial class addclient : Form
    {
        public addclient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                stepEntities db = new stepEntities();//PULL EF

                var add = new client // START ADD NEW CLIENT COMMAND AND DEFINE DATA
                {
                    firstname = textBoxFirst.Text,
                    lastname = textBoxLast.Text,
                    phonenumber = textBoxMobile.Text,
                    housenumber = textBoxHome.Text,
                    age = int.Parse(textBoxAge.Text)
                };

                db.clients.Add(add);
                db.SaveChanges();//SAVE CHNAGES

                MessageBox.Show("Client Has Been Added");//SHOW MESSAGE BOX BASED ON IF IT HAS WORKED

                //START BLANK MESSAGE BOXES
                textBoxFirst.Text = "";
                textBoxLast.Text = "";
                textBoxAge.Text = "";
                textBoxMobile.Text = "";
                textBoxHome.Text = "";
                //END BLANK MESSAGE BOXES
            }
            catch (Exception)
            {

                MessageBox.Show("Addtion was unsucessfull, please contact System Administrator");//IF UNABLE TO ADD SHOW MESSAGE
            } 
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
