using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
    public class QuebradaEntity
    {
        public int IdContato { get; set; }
        public string Telefone { get; set; }
        public EnderecoEntity Endereco { get; set; }
        public string QuebradaOrigem { get; set; }
    }
}
