using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class ApadrinhamentoEntity
    {
        public int Membro_idMembro { get; set; }
        public MembroEntity Membro { get; set; }
        public int Padrinho_idPadrinho { get; set; }
        public PadrinhoEntity Padrinho { get; set; }
    }
}
