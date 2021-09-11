using System;
using System.Collections.Generic;

using Solution.DataTransfer.Faccoes.Requests;
using Solution.DataTransfer.Faccoes.Responses;

namespace Solution.Aplicacao.Faccoes.Servicos.Interfaces
{
    public interface IFaccoesAppServicos
    {
        IEnumerable<FaccaoResponse> Listar(FaccaoListarRequest request);
    }
}
