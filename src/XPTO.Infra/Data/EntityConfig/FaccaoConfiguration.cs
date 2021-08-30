using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.Domain.Entities;

namespace XPTO.Infra.Data.EntityConfig
{
    public class FaccaoConfiguration : IEntityTypeConfiguration<FaccaoEntity>
    {
        public void Configure(EntityTypeBuilder<FaccaoEntity> builder)
        {
            builder.HasKey(x => x.IdFaccao);
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.NomeLider).IsRequired();
            builder.Property(x => x.Sigla).IsRequired();
            builder.Property(x => x.UFOrigem).IsRequired();

        }
    }
}
