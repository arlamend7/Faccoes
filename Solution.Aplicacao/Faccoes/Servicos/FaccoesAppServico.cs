using System.Collections.Generic;
using System.Linq;

using AutoMapper;

using Solution.Aplicacao.Faccoes.Servicos.Interfaces;
using Solution.DataTransfer.Faccoes.Requests;
using Solution.DataTransfer.Faccoes.Responses;
using Solution.Dominio.Faccoes.Entidades;
using Solution.Dominio.Faccoes.Repositorios;

namespace Solution.Aplicacao.Faccoes.Servicos
{
    public class FaccoesAppServico : IFaccoesAppServicos
    {
        private readonly IFaccoesRepositorio faccoesRepositorio;
        private readonly IMapper mapper;

        public FaccoesAppServico(IFaccoesRepositorio faccoesRepositorio, IMapper mapper)
        {
            this.faccoesRepositorio = faccoesRepositorio;
            this.mapper = mapper;
        }

        public IEnumerable<FaccaoResponse> Listar(FaccaoListarRequest request)
        {
            IQueryable<Faccao> query = faccoesRepositorio.Query();

            return query.Select(mapper.Map<FaccaoResponse>);
        } 
    }
}
