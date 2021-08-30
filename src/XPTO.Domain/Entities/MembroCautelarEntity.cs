using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class MembroCautelarEntity
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int Cautelar_idCautelar { get; set; }
        public CautelarEntity Cautelar { get; set; }

    }
}
