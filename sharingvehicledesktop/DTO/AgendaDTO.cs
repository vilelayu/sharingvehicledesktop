using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class AgendaDTO
    {
        public int id { get; set; }
        public int idMotorista { get; set; }
        public int idCar { get; set; }
        public DateTime horario { get; set; }
        public DateTime dia { get; set; }
    }
}
