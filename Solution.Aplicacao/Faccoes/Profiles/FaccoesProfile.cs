using AutoMapper;

using Solution.DataTransfer.Faccoes.Responses;
using Solution.Dominio.Faccoes.Entidades;

namespace Solution.Aplicacao.Faccoes.Profiles
{
    public class FaccoesProfile : Profile
    {
        public FaccoesProfile()
        {
            CreateMap<Faccao, FaccaoResponse>();
        }
    }
}
