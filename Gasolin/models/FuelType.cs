using System.Collections.Generic;

namespace Gasolin.models
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public void Save()
        {
            if (Id == 0)
            {
                DAL.AddFuelType(this);
            }
            else
            {
                DAL.UpdateFuelType(this);
            }
        }

        public void Delete()
        {
            DAL.DeleteFuelType(Id);
        }

        public static List<FuelType> GetAll()
        {
            return DAL.GetAllFuelTypes();
        }
    }
}
