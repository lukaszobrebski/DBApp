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
    public partial class Form1 : Form
    {
        public DBConnector myConnector = new DBConnector("localhost", "bicyclerentalsystem", "root", "");
        public UserDataStorage myDataStorage = new UserDataStorage();

        public Form1()
        {
            InitializeComponent();
        }

        bool legal(string s)
        {
            if (s.Contains("\"") || s.Contains("*") || s.Contains("'") || s.Contains(";") || s.Count() == 0)
                return false;
            else return true;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
           if(!legal(loginTextBox.Text) || !legal(passwordTextBox.Text))
            {
                incorrectLoginDataLabel.Text = "Podany login i/lub haslo naruszaja zasady dot. wprowadzania danych";
            }
            else if(!myConnector.checkIfLoginAndPasswordAreCorrect(loginTextBox.Text, passwordTextBox.Text) )
            {
                incorrectLoginDataLabel.Text = "Podany login i/lub hasło są nieprawidłowe";
            }
            else
            {
                myDataStorage = myConnector.LoadUserData(loginTextBox.Text);

                Form3 f = new Form3(myConnector, myDataStorage);
                f.Show();              
                this.Hide();

            }



        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(myConnector, myDataStorage);
            f.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
