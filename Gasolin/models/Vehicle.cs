using System;
using System.Collections.Generic;

namespace Gasolin.models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public int ConstructionYear { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int InitialKm { get; set; }
        public DateTime? SaleDate { get; set; }
        public int Active { get; set; }
        public string Fuel { get; set; }
        public string Owners { get; set; }
        public string Refills { get; set; }

        public void Save()
        {
            DAL.AddVehicle(this);
        }

        public void Update()
        {
            DAL.UpdateVehicle(this);
        }

        public void Delete()
        {
            DAL.DeleteVehicle(this.Id);
        }

        public static List<Vehicle> GetAll()
        {
            return DAL.GetAllVehicles();
        }
    }
}
