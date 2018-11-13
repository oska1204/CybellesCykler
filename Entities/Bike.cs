using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum BikeKind
    {
    }
    public class Bike
    {

        private decimal pricePerDay;
        private string bikeDescription;
        private BikeKind kind;
        private int id;

        public decimal PricePerDay
        {
            get { return pricePerDay; }
            set { pricePerDay = value; }
        }

        public string BikeDescription
        {
            get { return bikeDescription; }
            set { bikeDescription = value; }
        }

        public BikeKind Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Bike(decimal pPerDay, string desc, BikeKind kind, int id)
        {
            PricePerDay = pPerDay;
            BikeDescription = desc;
            Kind = kind;
            Id = id;
        }
    }
}
