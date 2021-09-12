using System.Linq;

using Solution.Dominio.Faccoes.Entidades;

namespace Solution.Dominio.Faccoes.Repositorios
{
    public interface IFaccoesRepositorio
    {
        IQueryable<Faccao> Query();
    }
}
