using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Dominio.Protocolos
{
    public class Protocolo
    {
        public int Id { get; set; }
        public ICollection<CodigoEvento> CodigosEvento { get; set; }
    }
}
