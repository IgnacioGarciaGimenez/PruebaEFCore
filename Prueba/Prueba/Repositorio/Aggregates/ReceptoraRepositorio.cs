using Microsoft.EntityFrameworkCore;
using Prueba.Aplicacion.Repositorio.Aggregates;
using Prueba.Dominio.Receptora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Repositorio.Aggregates
{
    public class ReceptoraRepositorio : Repositorio<Receptora>, IReceptoraRepositorio
    {
        public ReceptoraRepositorio(DbContext context) : base(context) { }
    }
}
