using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class CombustivelDTO
    {
        public int id { get; set; }
        public DateTime dia { get; set; }
        public string combustivel { get; set; }
        public float valor { get; set; }
        public double litro { get; set; }
        public int idCar { get; set; }
    }
}
