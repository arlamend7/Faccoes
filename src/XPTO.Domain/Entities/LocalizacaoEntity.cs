using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class LocalizacaoEntity
    {
        public int Membro_idMembro { get; set; }
        public MembroEntity Membro { get; set; }
        public int Quebrada_idQuebrada { get; set; }
        public QuebradaEntity Quebrada { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
