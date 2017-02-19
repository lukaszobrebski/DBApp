using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApp
{
    public class UserDataStorage
    {
        public long PESEL { get; set; }
        public string name { get; set; }
        public string surName { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int debt { get; set; }
        public bool hasRentedBike;
        public int BicycleID;
    }
}
