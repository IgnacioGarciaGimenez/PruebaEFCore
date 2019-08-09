using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Dominio.Receptora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Repositorio.Mapeos
{
    public class ReceptoraConfiguration : IEntityTypeConfiguration<Receptora>
    {
        public void Configure(EntityTypeBuilder<Receptora> builder)
        {

        }

    }
}
