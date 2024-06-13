using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolin.models
{
    public class Refuel
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Liters { get; set; }
        public int CurrentKm { get; set; }
        public decimal AmountEuro { get; set; }
        public Vehicle RefueledVehicle { get; set; }
        public Person PersonThatRefueled { get; set; }

        public Refuel(int id, DateTime timeStamp, int liters, int currentKm, decimal amountEuro, Vehicle refueledVehicle, Person personThatRefueled)
        {
            Id = id;
            TimeStamp = timeStamp;
            Liters = liters;
            CurrentKm = currentKm;
            AmountEuro = amountEuro;
            RefueledVehicle = refueledVehicle;
            PersonThatRefueled = personThatRefueled;
        }
    }
}
