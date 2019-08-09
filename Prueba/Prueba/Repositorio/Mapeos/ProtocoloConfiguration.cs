using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prueba.Dominio.Protocolos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba.Repositorio.Mapeos
{    
    public class ProtocoloConfiguration : IEntityTypeConfiguration<Protocolo>
    {
        public void Configure(EntityTypeBuilder<Protocolo> builder)
        {
            builder.HasKey(p => p.Id).HasName("Id");
            builder.OwnsMany(p => p.CodigosEvento, ce =>
            {
                ce.ToTable("CodigosEvento");
                ce.Property<int>("Id")
                    .ValueGeneratedOnAdd();
                ce.HasKey("Id");
                ce.Property(x => x.Numero);
                ce.Property(x => x.TipoEventoId);
            });
        }
    }
    
}
