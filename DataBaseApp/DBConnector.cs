using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApp
{
    public class DBConnector
    {
        public MySqlConnection connection;
        string serverName;
        string dataBaseName;
        string userName;
        string password;
        string connectionString;

        /*                                               BASIC SQL OPERATION METHODS                                                                                   */


        public List<Object> sendCustomReaderQuery(string query)
        {

            List<Object> returnableList = new List<Object>();
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, this.connection))
            {
                using (MySqlDataReader dataReader = command.ExecuteReader())
                {
                    if (dataReader != null)
                    {
                        while (dataReader.Read())
                        {
                            for(int i=0; i<  dataReader.FieldCount; i++)
                            returnableList.Add(dataReader[i]);
                            
                        }
                    }
                } 

            }
            connection.Close();

            return returnableList;

        }

        public void sendCustomInsertOrUpdateQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, this.connection);

            this.connection.Open();
            command.ExecuteNonQuery();
            this.connection.Close();

        }


        /*                                               USER DATA-RELATED METHODS                                                                                     */


        public bool checkIfUserExists(string PESEL, string login)
        {
            string query = "SELECT pesel, login FROM users WHERE pesel = \"" + PESEL + "\" OR login = \"" + login + "\";";
            List<Object> tempReader = sendCustomReaderQuery(query);

            if (tempReader.Count == 0)
                return false;
            else
                return true;
        }

        public bool checkIfLoginAndPasswordAreCorrect(string login, string password)
        {
            string query = "SELECT pesel, login FROM users WHERE password = \"" + password + "\" AND login = \"" + login + "\";";
            List<Object> tempReader = sendCustomReaderQuery(query);

            if (tempReader.Count == 0)
                return false;
            else
                return true;
        }

        public UserDataStorage LoadUserData(long PESEL)
        {
            UserDataStorage dataStorage = new UserDataStorage();
            List<Object> tempReader;

            string query = "SELECT * FROM users WHERE pesel = \"" + PESEL;
            tempReader = sendCustomReaderQuery(query);

            dataStorage.PESEL = PESEL;
            dataStorage.login = (string)tempReader[1];
            dataStorage.password = (string)tempReader[2];
            dataStorage.name = (string)tempReader[3];
            dataStorage.surName = (string)tempReader[4];

            query = "SELECT BicycleID FROM RentsActive WHERE PESEL = \"" + PESEL + "\" ;";
            tempReader = sendCustomReaderQuery(query);

            if(tempReader.Count>0)
            {
                dataStorage.hasRentedBike = true;
                dataStorage.BicycleID = (int)tempReader[0];
            }

            return dataStorage;

        }

        public UserDataStorage LoadUserData(string login)
        {
            UserDataStorage dataStorage = new UserDataStorage();
            List<Object> tempReader;

            string query = "SELECT * FROM users WHERE login =\"" + login + "\" ;";
            tempReader = sendCustomReaderQuery(query);

            dataStorage.PESEL = (long)tempReader[0];
            dataStorage.name = (string)tempReader[1];
            dataStorage.surName = (string)tempReader[2];
            dataStorage.login = (string)tempReader[3];
            dataStorage.password = (string)tempReader[4];

            query = "SELECT BicycleID FROM rentsactive WHERE PESEL = \"" + (long)tempReader[0] + "\" ;";
            tempReader = sendCustomReaderQuery(query);

            if (tempReader.Count>0)
            {
                dataStorage.hasRentedBike = true;
                dataStorage.BicycleID = (int)tempReader[0];
            }

            return dataStorage;

        }

        public void AddNewUser(UserDataStorage dataStorage)
        {
            string query = "INSERT INTO Users VALUES (\"" + dataStorage.PESEL + "\",\"" + dataStorage.name + "\", \"" + dataStorage.surName + "\", \"" + dataStorage.login + "\", \"" + dataStorage.password + "\", \"" + 0 + "\") ;";
            sendCustomInsertOrUpdateQuery(query);

        }


        /*                                               BICYCLE RENTING-RELATED METHODS                                                                                    */


        public int checkIfBicycleIsAvailable(string streetName)
        {
            string query = "SELECT BicycleCount FROM Stations WHERE StreetName = \"" + streetName + "\";";
            List<Object> tempReader = sendCustomReaderQuery(query);
            if((int)tempReader[0] == 0)
            {
                return 0;
            }

            query = "SELECT BicycleID FROM Bicycles WHERE StationID = (SELECT StationID FROM Stations WHERE StreetName = \"" + streetName + "\" ) ;";
            tempReader = sendCustomReaderQuery(query);

            return (int)tempReader[0];
        }

        public int checkIfStationHasSpace(string streetName)
        {
            string query;
            List<Object> tempReader;

            query = "SELECT BicycleCount, MaxBicycleCount FROM Stations WHERE StreetName = \"" + streetName + "\" ;";
            tempReader = sendCustomReaderQuery(query);


            int space = (int)tempReader[1] - (int)tempReader[0];
            return space;
        }

        public UserDataStorage rentBike(UserDataStorage dataStorage, int bicycleID)
        {
            UserDataStorage tempStorage = dataStorage;
            tempStorage.hasRentedBike = true;
            tempStorage.BicycleID = bicycleID;

            string query;

            query = "UPDATE Stations SET BicycleCount = BicycleCount - 1 WHERE StationID = (SELECT StationID FROM Bicycles WHERE BicycleID = \"" + bicycleID + "\");";
            sendCustomInsertOrUpdateQuery(query);
            query = "UPDATE Bicycles SET StationID = 0 WHERE BicycleID = \"" + bicycleID + "\" ;";
            sendCustomInsertOrUpdateQuery(query);
            query = "INSERT INTO RentsActive VALUES (NULL, \"" + tempStorage.PESEL + "\", \"" + tempStorage.BicycleID + "\", DEFAULT );";
            sendCustomInsertOrUpdateQuery(query);

            return tempStorage;
        }

        public UserDataStorage returnBicycleToStation(UserDataStorage dataStorage,string streetName, bool brokeReport)
        {
            List<Object> tempReader;
            UserDataStorage tempStorage = dataStorage;
            tempStorage.hasRentedBike = false;
            string query;
            string tempFirstDate, tempSecondDate;
            string []dateFormat = new string[2];
            long minutes;
            const double ratio = 0.3;
            double cost;


            tempFirstDate = "SELECT DateOfRent FROM rentsactive WHERE PESEL = \"" + tempStorage.PESEL + "\"";
            tempSecondDate = "SELECT NOW()";
            query = "SELECT TIMESTAMPDIFF(MINUTE,(" + tempFirstDate + "),(" + tempSecondDate + ") );";
            tempReader = sendCustomReaderQuery(query);
            minutes = (long)tempReader[0];

            cost = (minutes - 15) * ratio;
            if (cost < 0) cost = 0;

            query = "SELECT DATE_FORMAT(DateOfRent, '%Y-%m-%d %T') FROM rentsactive WHERE PESEL = \"" + tempStorage.PESEL + "\";";
            tempReader = sendCustomReaderQuery(query);

           
            query = "INSERT INTO rentsarchive VALUES (NULL, \"" + tempStorage.PESEL + "\", \"" + tempStorage.BicycleID + "\", (\'" + tempReader[0].ToString() +  " \') , DEFAULT," + cost + " , " + brokeReport + " );";
            sendCustomInsertOrUpdateQuery(query);

            query = "DELETE FROM rentsactive WHERE PESEL = \"" + tempStorage.PESEL + "\";";
            sendCustomInsertOrUpdateQuery(query);

            query = "UPDATE Bicycles SET StationID = (SELECT StationID FROM Stations WHERE StreetName = \"" + streetName + "\"), IsReportedBroken = " + brokeReport + "  WHERE BicycleID = \"" + tempStorage.BicycleID + "\";";
            sendCustomInsertOrUpdateQuery(query);

            query = "UPDATE Stations SET BicycleCount = BicycleCount + 1 WHERE StreetName = \"" + streetName + "\" ;";
            sendCustomInsertOrUpdateQuery(query);

            return tempStorage;

        }

        public DBConnector(string serverName, string dataBaseName, string userName, string password)
        {
            this.serverName = serverName;
            this.dataBaseName = dataBaseName;
            this.userName = userName;
            this.password = password;
            this.connectionString = "SERVER=" + serverName + ";" + "DATABASE=" + dataBaseName + ";" + "UID=" + userName + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);     
        }
    }
}
