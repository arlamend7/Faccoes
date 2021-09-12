﻿using System.Collections.Generic;
using System.Linq;

using NHibernate;

using Solution.Dominio.Faccoes.Entidades;
using Solution.Dominio.Faccoes.Repositorios;
using Solution.Infra.Utils;

namespace Solution.Infra.Faccoes.Repositorios
{
    public class FaccoesRepositorio : RepositorioNhibernateBase<Faccao> , IFaccoesRepositorio
    {
        public FaccoesRepositorio(ISession session) : base(session)
        {
        }

        public override IQueryable<Faccao> Query()
        {
            return new List<Faccao>().AsQueryable();
        }
    }
}
