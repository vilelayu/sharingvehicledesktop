using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class CarroDTO
    {
        public int id { get; set; }
        public string Renavam { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }
        public string combustivel { get; set; }
        public string quilometragem { get; set; }
    }
}
