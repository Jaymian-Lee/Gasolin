using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolin.models
{
    public class Person
    {
        public int Id { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime DriverLicenseDate { get; set; }
        public List<Vehicle> OwnedVehicles { get; set; } = new List<Vehicle>();
        public List<Refuel> Refills { get; set; } = new List<Refuel>();

        public Person(int id, string givenName, string familyName, DateTime birthDate, DateTime driverLicenseDate)
        {
            Id = id;
            GivenName = givenName;
            FamilyName = familyName;
            Birthdate = birthDate;
            DriverLicenseDate = driverLicenseDate;
        }

        public void Save()
        {
            DAL.AddPerson(this);
        }

        public void Update()
        {
            DAL.UpdatePerson(this);
        }

        public void Delete()
        {
            DAL.DeletePerson(this.Id);
        }

        public static List<Person> GetAll()
        {
            return DAL.GetAllPersons();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {GivenName} {FamilyName}, Birthdate: {Birthdate.ToShortDateString()}, Driver License Date: {DriverLicenseDate.ToShortDateString()}";
        }
    }
}