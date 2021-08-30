using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPTO.Domain.Entities
{
   public class InvestigacaoEntity
    {
        public int IdInvestigacao { get; set; }
        public string TituloOperacao { get; set; }
        public string PromotoriaVara {  get; set; }
        public string Estado {  get; set; }
        public string Prova {  get; set; }
        public string Descricao {  get; set; }
        public DateTime DataInvestigacao {  get; set; }
        public int Membro_idMembro { get; set; }
        public MembroEntity Membro { get; set; }
    }
}
