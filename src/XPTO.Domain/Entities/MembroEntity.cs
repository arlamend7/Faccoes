using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class MembroEntity
    {
        public int IdMembro { get; set; }
        public int Faccao_idFaccao { get; set; }
        public FaccaoEntity Faccao { get; set; }

    }
}
