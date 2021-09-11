using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Solution.Aplicacao.Faccoes.Servicos.Interfaces;
using Solution.DataTransfer.Faccoes.Requests;

namespace Solution.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FaccoesController : ControllerBase
    {
        private readonly IFaccoesAppServicos faccoesAppServicos;

        public FaccoesController(IFaccoesAppServicos faccoesAppServicos)
        {
            this.faccoesAppServicos = faccoesAppServicos;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Listar([FromQuery] FaccaoListarRequest request)
        {
            return Ok(faccoesAppServicos.Listar(request));
        }
    }
}
