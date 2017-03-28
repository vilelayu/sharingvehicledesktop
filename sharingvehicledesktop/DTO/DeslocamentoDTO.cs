using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class DeslocamentoDTO
    {
        public int id { get; set; }
        public string data { get; set; }
        public int quilometragemDeslocada { get; set; }
        public int idCar { get; set; }
        public int idMotorista { get; set; }
    }
}
