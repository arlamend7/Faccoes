using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class CautelarEntity
    {
        public int IdCautelar { get; set; }
        public int TempoPena { get; set; }
        public string LocalCunprimento { get; set; }
        public int UF { get; set; }
    }
}
