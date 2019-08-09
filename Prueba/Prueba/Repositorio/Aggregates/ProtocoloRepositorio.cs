using Microsoft.EntityFrameworkCore;
using Prueba.Aplicacion.Repositorio.Aggregates;
using Prueba.Dominio.Protocolos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Repositorio.Aggregates
{
    public class ProtocoloRepositorio : Repositorio<Protocolo>, IProtocoloRepositorio
    {
        public ProtocoloRepositorio(DbContext context) : base(context) { }
    }
}
