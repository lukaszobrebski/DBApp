using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class Form2 : Form
    {

        public DBConnector myConnector;
        public UserDataStorage myDataStorage;

        public Form2(DBConnector myConnector, UserDataStorage myDataStorage)
        {
            this.myConnector = myConnector;
            this.myDataStorage = myDataStorage;

            InitializeComponent();

        }
        bool legal(string s)
        {
            if (s.Contains("\"") || s.Contains("*") || s.Contains("'") || s.Contains(";") || s.Count() == 0)
                return false;
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( !legal(peselTextBox.Text) || !legal(loginTextBox.Text) || !legal(passwordTextBox.Text) || !legal(nameTextBox.Text) || !legal(surnameTextBox.Text) || peselTextBox.Text.Length != 11)
            {
                incorrectRegisterDataLabel.Text = "Nieprawidlowe znaki";
            }
            else if(myConnector.checkIfUserExists(peselTextBox.Text, loginTextBox.Text))
            {
                incorrectRegisterDataLabel.Text = "Podane dane są już w użyciu";
            }
            else
            {
                myDataStorage.PESEL = long.Parse(peselTextBox.Text);
                myDataStorage.login = loginTextBox.Text;
                myDataStorage.password = passwordTextBox.Text;
                myDataStorage.name = nameTextBox.Text;
                myDataStorage.surName = surnameTextBox.Text;
                myDataStorage.hasRentedBike = false;
                myDataStorage.BicycleID = 0;

                myConnector.AddNewUser(myDataStorage);

                Form3 f = new Form3(myConnector, myDataStorage);
                f.Show();
                this.Hide();


            }


        }
    }
}
