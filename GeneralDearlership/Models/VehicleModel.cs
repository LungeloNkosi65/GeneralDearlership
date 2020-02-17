using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDearlership.Models
{
    public class VehicleModel : Make
    {
        public string MakeName { get; set; }
        public VehicleModel(string name, string makeName) : base(name)
        {
            MakeName = makeName;
        }
    }
}
