using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class DossieEntity
    {
        public int IdArquivo { get; set; }
        public byte[] Blob { get;  set; }
        public DateTime DataAtualizacao { get; set; }
        public string Descricao { get; set; }
        public string Link { get; set; }
        public DateTime DataAcesso { get; set; }
        public int Membro_idMembro { get; set; }
        public MembroEntity Membro { get; set; }
    }
}
