using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        private Bike bike;
        private Rentee rentee;
        private DateTime rentDate;
        private DateTime deliveryDate;
        private int id;

        public Bike Bike
        {
            get { return bike; }
            set { bike = value; }
        }

        public Rentee Rentee
        {
            get { return rentee; }
            set { rentee = value; }
        }

        public DateTime RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }

        public DateTime DeliveryDate
        {
            get { return deliveryDate; }
            set { deliveryDate = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Order(Bike b, Rentee r, DateTime rD, DateTime dD, int id)
        {
            Bike = b;
            Rentee = r;
            RentDate = rD;
            DeliveryDate = dD;
            Id = id;
        }

        public decimal GetPrice()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{bike} {rentee} {rentDate} {deliveryDate} {id}";
        }
    }
}
