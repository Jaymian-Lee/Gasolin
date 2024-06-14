using System;
using System.Collections.Generic;

namespace Gasolin.models
{
    public class Refuel
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Liters { get; set; }
        public int CurrentKm { get; set; }
        public decimal AmountEuro { get; set; }
        public int VehicleId { get; set; }
        public Vehicle RefueledVehicle { get; set; }
        public int PersonId { get; set; }
        public Person PersonThatRefueled { get; set; }

        public Refuel() { }

        public Refuel(int id, DateTime timeStamp, int liters, int currentKm, decimal amountEuro, int vehicleId, int personId)
        {
            Id = id;
            TimeStamp = timeStamp;
            Liters = liters;
            CurrentKm = currentKm;
            AmountEuro = amountEuro;
            VehicleId = vehicleId;
            PersonId = personId;
            RefueledVehicle = DAL.GetVehicleById(vehicleId);
            PersonThatRefueled = DAL.GetPersonById(personId);
        }

        public void Save()
        {
            if (Id == 0)
            {
                DAL.AddRefuel(this);
            }
            else
            {
                // Update logic here if needed
            }
        }

        public void Delete()
        {
            DAL.DeleteRefuel(Id);
        }

        public static List<Refuel> GetAll()
        {
            return DAL.GetAllRefuels();
        }
    }
}
