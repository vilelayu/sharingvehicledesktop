using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class RevisaoDTO
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string NomeOficina { get; set; }
        public DateTime dataEntrada { get; set; }
        public DateTime dataSaida { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSaida { get; set; }
        public string nomeItem { get; set; }
        public decimal preco { get; set; }
        public int quantidade { get; set; }
        public int idCar { get; set; }
    }
}
