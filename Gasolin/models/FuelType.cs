using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolin.models
{
    public class FuelType
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public FuelType(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
