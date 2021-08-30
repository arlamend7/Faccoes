using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class ProcessoEntity
    {
        public int IdProcesso { get; set; }
        public string Vara { get; set; }
        public string Comarca { get; set; }
        public string UF { get; set; }
        public string Artigos { get; set; }
        public string NumProcesso { get; set; }
        public int Membro_idMembro { get; set; }
        public MembroEntity Membro { get; set; }
    }
}
