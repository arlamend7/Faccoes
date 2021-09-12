using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Solution.Dominio.Membros.Entidades;

namespace Solution.Dominio.Investigacoes.Entidades
{
    public class Investigacao
    {
        public virtual long Id { get; protected set; }
        public virtual Membro Membro { get; protected set; }
        public virtual string TituloOperacao { get; protected set; }
        public virtual string PromotoriaVara { get; protected set; }
        public virtual string Estado { get; protected set; }
        public virtual string Prova { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual DateTime DataInvestigacao { get; protected set; }
    }
}
