using FluentNHibernate.Mapping;

using Solution.Dominio.Faccoes.Entidades;

namespace Solution.Infra.Faccoes.Mapeamentos
{
    public class FaccoesMap : ClassMap<Faccao>
    {
        public FaccoesMap()
        {
            Schema("DELTA");
            Table("FACCOES");
            Id(x => x.Id).Column("ID");

            ReadOnly();
        }
    }
}
