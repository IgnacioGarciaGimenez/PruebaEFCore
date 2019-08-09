using Prueba.Aplicacion.Repositorio;
using Prueba.Aplicacion.Repositorio.Aggregates;
using Prueba.Repositorio.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Repositorio
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IReceptoraRepositorio Receptoras { get; set; }
        public IProtocoloRepositorio Protocolos { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Receptoras = new ReceptoraRepositorio(_context);
            Protocolos = new ProtocoloRepositorio(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
