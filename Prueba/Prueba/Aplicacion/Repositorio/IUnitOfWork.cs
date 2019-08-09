using Prueba.Aplicacion.Repositorio.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Aplicacion.Repositorio
{
    public interface IUnitOfWork : IDisposable
    {
        IReceptoraRepositorio Receptoras { get; set; }
        IProtocoloRepositorio Protocolos { get; set; }
        void Complete();
    }
}
