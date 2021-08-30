using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPTO.Infra.Data.EntityConfig;

namespace XPTO.Infra.Data.Context
{
    public class XPTOContext: DbContext
    {
        public XPTOContext(DbContextOptions<XPTOContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new FaccaoConfiguration());

        }
    }
}
