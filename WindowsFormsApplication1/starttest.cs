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
    public partial class starttest : Form
    {
        public starttest()
        {
            InitializeComponent();
        }
        //DATABASE INFO
        string firstname, lastname;
        int id;
        int maxtestnumber;
        //END DATABASE INFO

        //START MATH INFO
        string fitnessrating;
        string testdate;
        string fullname;
        string notes;
        string gender;
        int countid = 0;
        private int[][] store = new int[2][];

        int maxhr;
        int maxhr80;
        int age;
        int maxhr50;
        int counter = 1;

        double testcomplete = 0, sumofx = 0, sumofy = 0, sumofxy = 0, sumofx2 = 0, x = 0, y = 0, intersect = 0;
        double Result;
        //END MATH INFO

        stepEntities db = new stepEntities();

        private void starttest_Load(object sender, EventArgs e)
        {
            //START SELECT CLIENT FULL NAME
            var query = from clients in db.clients
                        select clients; // create query

            foreach (var client in query)
            {
                comboBoxChooseClient.Items.Add(client.firstname + " " + client.lastname);
            }
            //END SELECT CLIENT FULL NAME

            //START DEFINE THE TWO ARRAYS
            store[0] = new int[5]; 
            store[1] = new int[5];
            //END DEFINE THE TWO ARRAYS
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

            foreach (var client in query)
            {
                id = client.client_id;
                age = (int)client.age;
                gender = client.Gender;
            }
            textBoxClientID.Text = id.ToString();
            //END FIND SELECTED CLIENT'S ID FROM DATABASE
            //START MAX HR CALCULATIONS
            textBoxAge.Text = age.ToString();

            maxhr = (220 - age);
            textBoxMaxHR.Text = maxhr.ToString();

            maxhr80 = (maxhr / 10) * 8;
            maxhr50 = (maxhr / 10) * 5;
            textBoxMaxHR80.Text = maxhr80.ToString();

            textBoxGender.Text = gender;
            //END MAX HR CALCULATIONS
        }

        public void buttonCheckComplete_Click(object sender, EventArgs e)
        {
            //START DISABLE STEPHEIGHT AND TESTDATE
            dateTimePickerTestDate.Enabled = false;
            radioButton15cm.Enabled = false;
            radioButton20cm.Enabled = false;
            radioButton25cm.Enabled = false;
            radioButton30cm.Enabled = false;
            //END DISABLE STEPHEIGHT AND TESTDATE

            //START STORE SELECTED STEPHEIGHT IN THE ARRAY
                if (radioButton15cm.Checked)
                {
                    store[0][0] = 11;
                    store[0][1] = 14;
                    store[0][2] = 18;
                    store[0][3] = 21;
                    store[0][4] = 25;
                }
                else if (radioButton20cm.Checked)
                {
                    store[0][0] = 12;
                    store[0][1] = 17;
                    store[0][2] = 21;
                    store[0][3] = 25;
                    store[0][4] = 29;
                }
                else if (radioButton25cm.Checked)
                {
                    store[0][0] = 14;
                    store[0][1] = 19;
                    store[0][2] = 24;
                    store[0][3] = 28;
                    store[0][4] = 33;
                }
                else
                {
                    store[0][0] = 16;
                    store[0][1] = 21;
                    store[0][2] = 27;
                    store[0][3] = 32;
                    store[0][4] = 37;
                }            
            //END STORE SELECTED STEPHEIGHT
        }

        private void buttonAddResult_Click(object sender, EventArgs e)
        {
            //START 
            if (int.Parse(textBoxResult.Text) < maxhr80)
            {
                Int32.TryParse(textBoxResult.Text, out store[1][counter]);
            }
            else
            {
                MessageBox.Show("END TEST");
            }

            counter++;
            ListViewItem hrList = new ListViewItem(store[0][counter - 1].ToString());
            hrList.SubItems.Add(store[1][counter - 1].ToString());
            listViewStoredInfo.Items.Add(hrList);

            if (counter > 4)
            {
                MessageBox.Show("Complete");
                buttonAddResult.Enabled = false;
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //START DISABLE RESULTS BOX
            textBoxResult.Enabled = false;
            //END DISABLE RESULTS BOX

            //START SAVE CLIENTS NOTES
            notes = richTextBoxNotes.Text;
            //END SAVE CLIENTS NOTES

            //START COMPLEX MATH
            for (int i = 0; i <= counter - 1; i++) //create a loop until i less than equals counter
            {
                if (store[1][i] > maxhr50 && store[1][i] < maxhr80) //if element in array is greater than 50% and lower than 80% 
                {

                    testcomplete++; //increment complete counter by 1
                    sumofx = sumofx + store[0][i]; //calculate the sum of x buy using sum of x + number of element in array
                    sumofy = sumofy + store[1][i]; //calculate the sum of y buy using sum ofy + number of element in array
                    sumofxy = sumofxy + (store[0][i] * store[1][i]); //calculate sum XY
                    sumofx2 = sumofx2 + (store[0][i] * store[0][i]); //calculate sum X squared

                    x = Math.Round((sumofy * sumofx2 - sumofx * sumofxy) / (testcomplete * sumofx2 - sumofx * sumofx), 3); //calculate intersect of X
                    y = Math.Round((testcomplete * sumofxy - sumofx * sumofy) / (testcomplete * sumofx2 - sumofx * sumofx), 3); //calculate intersect of y
                    intersect = Math.Round((x - maxhr) / -y, 1); //display the intersect where line of best fit hits the the max heart rate

                    textBoxACP.Text = intersect.ToString();
                }
            }
            //save result to the double
            Result = intersect;
            //END COMPLEX MATH

            //START GENDER QUERY
            if (textBoxGender.Text == "Male")                                       //if radio button male is checked
            {
                if (age >= 15 && age <= 19)                            // if age is greater than or equal to 15 and less than equal to 19
                {
                    if (Result < 30.0)                                  //if intercept is less than 30
                    {
                        textBoxFR.Text = "Poor";                            //display poor
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 30.0 && Result <= 38.9)          //if intercept is great than 30 and less than 38.9
                    {
                        textBoxFR.Text = "Below Average";                 //display below average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 39.0 && Result <= 47.9)        //if intercept great that 39 and lower than 47.9
                    {
                        textBoxFR.Text = "Average";                         //display average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 48.0 && Result <= 59.9)       //if greater than 48 and less than 59.9
                    {
                        textBoxFR.Text = "Good";                         //display good
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 60.0)                          //if greater than 60
                    {
                        textBoxFR.Text = "Excellent";                   //display exellent
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";                      //display error
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 20 && age <= 29)                      // if age is greater than or equal to 20 and less than equal to 29
                {
                    if (Result < 28.0)                               //if less than 28
                    {
                        textBoxFR.Text = "Poor";                         //display poor
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 28.0 && Result <= 34.9)       //if greater than 28 and less than 34.9
                    {
                        textBoxFR.Text = "Below Average";                 //display below average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 35.0 && Result <= 43.9)          //if greater than 35 and less than 43.9
                    {
                        textBoxFR.Text = "Average";                        //display average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 44.0 && Result <= 54.9)          // if greater than 44 and less than 54.9
                    {
                        textBoxFR.Text = "Good";                           //display good
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 55.0)                           //if greater than 55
                    {
                        textBoxFR.Text = "Excellent";             //display exellent
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";                       //other wise display error
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 30 && age <= 39)                    //if age greater than 30 and less than 39
                {
                    if (Result < 26.0)                               //if result less than 26
                    {
                        textBoxFR.Text = "Poor";                        //display poor
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 26.0 && Result <= 33.9)       //if greater than 26 and less than 33.9
                    {
                        textBoxFR.Text = "Below Average";               //display below average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 34.0 && Result <= 39.9)        //if greater than 34 and lower than 39.9
                    {
                        textBoxFR.Text = "Average";                      //display everage
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 40.0 && Result <= 49.9)       //if greater than 40 and less than 49.9
                    {
                        textBoxFR.Text = "Good";                         //display good
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 50.0)                       //if greater than 50
                    {
                        textBoxFR.Text = "Excellent";                     //display excellent
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";                  //display error      
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 40 && age <= 49)                    //if age greater than 40 and less than 49
                {
                    if (Result < 25.0)                                //if less than 25
                    {
                        textBoxFR.Text = "Poor";                           //display poor
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 25.0 && Result <= 31.9)       //if greater than 25 and less than 31.9
                    {
                        textBoxFR.Text = "Below Average";              //display below average  
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 32.0 && Result <= 36.9)        //if greater than 32 and lower than 36.9
                    {
                        textBoxFR.Text = "Average ";                   //display average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 37.0 && Result <= 45.9)          //if greater than 37 and less than 45.9
                    {
                        textBoxFR.Text = "Good";                        //display good
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 46.0)                          //if greater than 46.0
                    {
                        textBoxFR.Text = "Excellent";                     //display excellent
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";                        //display error
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 50 && age <= 59)                     //if age is greater than 50 and less than 59
                {
                    if (Result < 23.0)                                //if less than 23
                    {
                        textBoxFR.Text = "Poor";                        //display poor
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 23.0 && Result <= 28.9)         //if greater than 23 and less than 28.9
                    {
                        textBoxFR.Text = "Below Average";                //display below average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 29.0 && Result <= 34.9)        //if greater than 29 and less than 34.9
                    {
                        textBoxFR.Text = "Average";                       //display average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 35.0 && Result <= 43.9)         //greater than 35 and less than 43.9
                    {
                        textBoxFR.Text = "Good";                        //display good
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 44.0)                          //if higher than 44
                    {
                        textBoxFR.Text = "Excellent";                  //display excellent
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";                        //display error
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 60 && age <= 65)                       //if age is greater than 60 and less than 65
                {
                    if (Result < 20.0)                            //if less than 30
                    {
                        textBoxFR.Text = "Poor";                    //diplay poor
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 20.0 && Result <= 24.9)       //greater than 20 and less than 24.9
                    {
                        textBoxFR.Text = "Below Average";                 //display below average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 25.0 && Result <= 32.9)       //greater than 25 and less than 32.9
                    {
                        textBoxFR.Text = "Average";                      //display average
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 33.0 && Result <= 39.9)       //greater than 33 less than 39.9
                    {
                        textBoxFR.Text = "Good";                       //display good
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 40.0)                          //greater than 40
                    {
                        textBoxFR.Text = "Excellent";                   //display excellent
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";                           //display error
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else
                {
                    textBoxFR.Text = "age outside of tested range";        //other wise age range is outside boundaries display error
                    fitnessrating = textBoxFR.Text;
                }
            }

            else                                                       // else gender equals female and follow the same process
            {
                if (age >= 15 && age <= 19)
                {
                    if (Result < 29.0)
                    {
                        textBoxFR.Text = "Poor";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 29.0 && Result <= 35.9)
                    {
                        textBoxFR.Text = "Below Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 36.0 && Result <= 43.9)
                    {
                        textBoxFR.Text = "Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 44.0 && Result <= 54.9)
                    {
                        textBoxFR.Text = "Good";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 55.0)
                    {
                        textBoxFR.Text = "Excellent";
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 20 && age <= 29)
                {
                    if (Result < 27.0)
                    {
                        textBoxFR.Text = "Poor";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 27.0 && Result <= 31.9)
                    {
                        textBoxFR.Text = "Below Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 32.0 && Result <= 39.9)
                    {
                        textBoxFR.Text = "Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 40.0 && Result <= 49.9)
                    {
                        textBoxFR.Text = "Good";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 50.0)
                    {
                        textBoxFR.Text = "Excellent";
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else if (age >= 30 && age <= 39)
                {
                    if (Result < 25.0)
                    {
                        textBoxFR.Text = "Poor";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 25.0 && Result <= 29.9)
                    {
                        textBoxFR.Text = "Below Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 30.0 && Result <= 35.9)
                    {
                        textBoxFR.Text = "Average";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 36.0 && Result <= 45.9)
                    {
                        textBoxFR.Text = "Good";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 46.0)
                    {
                        textBoxFR.Text = "Excellent";
                        fitnessrating = textBoxFR.Text;

                    }
                    else
                    {
                        textBoxFR.Text = "Error";
                        fitnessrating = textBoxFR.Text;

                    }
                }
                else if (age >= 40 && age <= 49)
                {
                    if (Result < 22.0)
                    {
                        textBoxFR.Text = "Poor";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 22.0 && Result <= 27.9)
                    {
                        textBoxFR.Text = "Below Average";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 28.0 && Result <= 33.9)
                    {
                        textBoxFR.Text = "Average";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 34.0 && Result <= 42.9)
                    {
                        textBoxFR.Text = "Good";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 43.0)
                    {
                        textBoxFR.Text = "Excellent";
                        fitnessrating = textBoxFR.Text;

                    }
                    else
                    {
                        textBoxFR.Text = "Error";
                        fitnessrating = textBoxFR.Text;

                    }
                }
                else if (age >= 50 && age <= 59)
                {
                    if (Result < 21.0)
                    {
                        textBoxFR.Text = "Poor";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 21.0 && Result <= 25.9)
                    {
                        textBoxFR.Text = "Below Average";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 26.0 && Result <= 32.9)
                    {
                        textBoxFR.Text = "Average";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 33.0 && Result <= 40.9)
                    {
                        textBoxFR.Text = "Good";
                        fitnessrating = textBoxFR.Text;

                    }
                    else if (Result >= 41.0)
                    {
                        textBoxFR.Text = "Excellent";
                        fitnessrating = textBoxFR.Text;

                    }
                    else
                    {
                        textBoxFR.Text = "Error";
                        fitnessrating = textBoxFR.Text;

                    }
                }
                else if (age >= 60 && age <= 65)
                {
                    if (Result < 19.0)
                    {
                        textBoxFR.Text = "Poor";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 19.0 && Result <= 23.9)
                    {
                        textBoxFR.Text = "Below Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 24.0 && Result <= 30.9)
                    {
                        textBoxFR.Text = "Average";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 31.0 && Result <= 38.9)
                    {
                        textBoxFR.Text = "Good";
                        fitnessrating = textBoxFR.Text;
                    }
                    else if (Result >= 39.0)
                    {
                        textBoxFR.Text = "Excellent";
                        fitnessrating = textBoxFR.Text;
                    }
                    else
                    {
                        textBoxFR.Text = "Error";
                        fitnessrating = textBoxFR.Text;
                    }
                }
                else
                {
                    textBoxFR.Text = "age outside of tested range";
                    fitnessrating = textBoxFR.Text;
                }
            }
            //END GENDER QUERY

            //START UPLOAD TO DATABASE
                //START QUERY FOR LAST TEST NUMBER
                var testno = from test in db.tests where test.client_id == id select test.test_number;

                foreach (var testid in testno)
                {
                    countid++; 
                }
                maxtestnumber = countid + 1;
                //END QUERY FOR LAST TEST NUMBER
                
                var add = new test // START ADD NEW CLIENT COMMAND AND DEFINE DATA
                {
                    username = Properties.Settings.Default.username,
                    client_id = int.Parse(textBoxClientID.Text),
                    test_date = dateTimePickerTestDate.Value.ToShortDateString(),
                    max_hr = int.Parse(textBoxMaxHR.Text),
                    max_hr_80 = int.Parse(textBoxMaxHR80.Text),
                    ac = decimal.Parse(textBoxACP.Text),
                    fitnessrating = textBoxFR.Text,
                    test_number = maxtestnumber,
                    notes = richTextBoxNotes.Text
                };

                db.tests.Add(add);
                db.SaveChanges();//SAVE CHNAGES

                MessageBox.Show("Your Information Has Been Saved To the Database");
            //END UPLOAD TO DATABASE

        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            addclient adcli = new addclient();
            adcli.Show();
            //END SHOW ADD CLIENT FORM
        }

        private void viewResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //START SHOW ADD CLIENT FORM
            clienttests clienttests = new clienttests();
            clienttests.Show();
            //END SHOW ADD CLIENT FORM
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
