using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class GastoDTO
    {
        public int id { get; set; }
        public string tipoGasto { get; set; }
        public string numeroParcela { get; set; }
        public double valorParcela { get; set; }
        public string idCar { get; set; }
    }
}
