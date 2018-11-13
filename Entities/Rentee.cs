using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rentee
    {
        private string name;
        private string address;
        private string phoneNumber;
        private DateTime registerDate;
        private int id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public DateTime RegisterDate
        {
            get { return registerDate; }
            set { registerDate = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Rentee(string n, string a, string pN, DateTime rD, int id)
        {
            n = Name;
            a = Address;
            pN = PhoneNumber;
            rD = RegisterDate;
            id = Id;
        }

        public override string ToString()
        {
            return $"{name} {address} {phoneNumber} {registerDate} {id}";
        }
    }
}
