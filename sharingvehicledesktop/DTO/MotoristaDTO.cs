using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharingvehicledesktop.DTO
{
    class MotoristaDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cnh { get; set; }
        public string cpf { get; set; }
        public string dataNascimento { get; set; }
        public string dataVencimentoCnh { get; set; }
        public string idUsuario { get; set; }
    }
}
