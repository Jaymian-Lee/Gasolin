using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolin.models
{
    public class VehicleType
    {
        public int Id { get; set; }
        public string Description { get; set; }


        public void Save()
        {
            DAL.AddVehicleType(this);
        }

        public static List<VehicleType> GetAll()
        {
            return DAL.GetAllVehicleTypes();
        }

    }
}
