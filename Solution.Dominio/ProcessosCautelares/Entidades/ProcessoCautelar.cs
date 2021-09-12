using System;

using Solution.Dominio.Cautelares.Entidades;
using Solution.Dominio.Processos.Entidades;

namespace Solution.Dominio.ProcessosCautelares.Entidades
{
    public class ProcessoCautelar
    {
        public virtual Cautelar Cautelar { get; protected set; }
        public virtual Processo Processo { get; protected set; }
        public virtual DateTime DataInicio { get; protected set; }
        public virtual DateTime DataFim { get; protected set; }
    }
}
