using System.Collections.Generic;

using Solution.Dominio.Membros.Entidades;

namespace Solution.Dominio.Faccoes.Entidades
{
    public class Faccao
    {
        public virtual long Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual string Sigla { get; protected set; }
        public virtual string UFOrigem { get; protected set; }
        public virtual string AnoOrigem { get; protected set; }
        public virtual string NomeLider { get; protected set; } // poderia ser um membro

        public virtual IList<Membro> Membros { get; protected set; }
    }
}
