using System;

using Solution.Dominio.Membros.Entidades;
using Solution.Dominio.Quebradas.Entidades;

namespace Solution.Dominio.Localizacoes.Entidades
{
    public class Localizacao
    {
        public Membro Membro { get; protected set; }
        public Quebrada Quebrada { get; protected set; }

        public DateTime DataInicio { get; protected set; }
        public DateTime DataFim { get; protected set; }
    }
}
