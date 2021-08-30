using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class FaccaoEntity
    {
        public int IdFaccao { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string UFOrigem { get; set; }
        public int AnoOrigem { get; set; }
        public string NomeLider { get; set; }
    }
}
