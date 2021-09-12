﻿using FluentNHibernate.Mapping;

using Solution.Dominio.Faccoes.Entidades;

namespace Solution.Infra.Faccoes.Mapeamentos
{
    public class FaccoesMap : ClassMap<Faccao>
    {
        public FaccoesMap()
        {
            Schema("DELTA");
            Table("FACCOES");
            Id(x => x.Id).Column("IDFACCAO");
            Map(x => x.Nome).Column("NOME");
            Map(x => x.Sigla).Column("SIGLA");
            Map(x => x.AnoOrigem).Column("ANOORIGEM");
            Map(x => x.UFOrigem).Column("UFORIGEM");
            Map(x => x.NomeLider).Column("NOMELIDER");
            HasMany(x => x.Membros)
                .KeyColumn("IDFACCAO")
                .Fetch.Subselect();

            ReadOnly();
        }
    }
}
