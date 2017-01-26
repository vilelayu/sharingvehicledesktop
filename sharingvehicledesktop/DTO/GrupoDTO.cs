using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class GrupoDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string regiao { get; set; }
        public int idRateio { get; set; }
        public int idAgenda { get; set; }
    }
}
