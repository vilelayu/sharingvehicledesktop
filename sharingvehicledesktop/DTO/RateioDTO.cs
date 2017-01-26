using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class RateioDTO
    {
        public int id { get; set; }
        public DateTime dataSaida { get; set; }
        public DateTime dataRetorno { get; set; }
        public int quilometragemUso { get; set; }
    }
}
