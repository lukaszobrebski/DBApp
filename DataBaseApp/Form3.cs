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
    public partial class Form3 : Form
    {
        public DBConnector myConnector;
        public UserDataStorage myDataStorage;

        public Form3(DBConnector myConnector, UserDataStorage myDataStorage)
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


        private void rentButton_Click(object sender, EventArgs e)
        {
            if (!legal(streetNameTextBox.Text))
            {
                infoLabel.Text = "Nieprawidłowe Dane";
                infoLabel.Update();
            }
            else
            {
                int bicycleID = myConnector.checkIfBicycleIsAvailable(streetNameTextBox.Text);

                if (bicycleID > 0)
                {
                    myDataStorage = myConnector.rentBike(myDataStorage, bicycleID);
                    rentButton.Enabled = false;
                    returnButton.Enabled = true;
                }
                else
                {
                    infoLabel.Text = "Nie mamy roweru na tej ulicy";
                    infoLabel.Update();
                }
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (!legal(streetNameTextBox.Text) || streetNameTextBox.Text.Count() <= 0)
            {
                infoLabel.Text = "Nieprawidłowe Dane";
                infoLabel.Update();
            }
            else
            {
                if(myConnector.checkIfStationHasSpace(streetNameTextBox.Text) > 0)
                {
                    myConnector.returnBicycleToStation(myDataStorage, streetNameTextBox.Text, reportBrokenCheckBox.Checked);
                    rentButton.Enabled = true;
                    returnButton.Enabled = false;
                }
                else
                {
                    this.infoLabel.Text = "Nie ma miejsca w tej stacji";
                    infoLabel.Update();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            if (myDataStorage.hasRentedBike)
            {
                rentButton.Enabled = false;
            }
            else
            {
                returnButton.Enabled = false;
            }
        }
    }
}
