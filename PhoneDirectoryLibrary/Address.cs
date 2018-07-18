using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectoryLibrary
{
    public struct Address
    {
        public string street;
        public string houseNum;
        public string city;
        public string zip;
        public string Pid;

        public Address(string street, string houseNum, string city, string zip) : this()
        {
            this.street = street ?? throw new ArgumentNullException(nameof(street));
            this.houseNum = houseNum ?? throw new ArgumentNullException(nameof(houseNum));
            this.city = city ?? throw new ArgumentNullException(nameof(city));
            this.zip = zip ?? throw new ArgumentNullException(nameof(zip));
            Pid = System.Guid.NewGuid().ToString();
        }
    }
}
