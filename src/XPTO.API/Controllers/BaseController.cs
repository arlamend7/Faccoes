
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace XPTO.API.Controllers
{
    public class BaseController : ControllerBase
    {

        public BaseController()
        {
        }

        #region [IActionResult] sync

        protected IActionResult Result<TData>(TData data)
            where TData : class
        {
            return ResultOk(data);
        }

        protected IActionResult Result()
        {
            return ResultOk();
        }

        protected IActionResult ResultOk()
        {
            return ResultOk("Sucesso!");
        }

        protected IActionResult ResultOk<TData>(TData data, IEnumerable<string> messages)
            where TData : class
        {
            return new JsonResult(new Response<TData>(data, true, HttpStatusCode.OK, messages));
        }

        protected IActionResult ResultOk<TData>(TData data)
            where TData : class
        {
            return new JsonResult(new Response<TData>(data, true, HttpStatusCode.OK));
        }

        private IActionResult ResultErro(IEnumerable<string> messages)
        {
            return ResultErro("Erro!", messages);
        }

        private IActionResult ResultErro<TData>(TData data, IEnumerable<string> messages)
            where TData : class
        {
            Response.StatusCode = (int)HttpStatusCode.BadRequest;

            return new JsonResult(new Response<TData>(data, false, HttpStatusCode.BadRequest, messages));
        }

        #endregion [IActionResult] sync

        #region [IActionResult] async

        protected Task<IActionResult> ResultOkAsync()
        {
            return Task.FromResult(ResultOk());
        }

        protected Task<IActionResult> ResultOkAsync<TData>(TData data, IEnumerable<string> messages)
            where TData : class
        {
            return Task.FromResult(ResultOk(data, messages));
        }

        protected Task<IActionResult> ResultOkAsync<TData>(TData data)
            where TData : class
        {
            return Task.FromResult(ResultOk(data));
        }

        protected Task<IActionResult> ResultErroAsync(IEnumerable<string> messages)
        {
            return Task.FromResult(ResultErro(messages));
        }

        protected Task<IActionResult> ResultErroAsync<TData>(TData data, IEnumerable<string> messages)
            where TData : class
        {
            return Task.FromResult(ResultErro(data, messages));
        }

        #endregion [IActionResult] async


    }

    public class Response<TData> : StatusCodeResult
       where TData : class
    {
        public bool Success { get; set; }
        public TData Data { get; set; }
        public IEnumerable<string> Messages { get; set; }

        public Response(TData data, bool success, HttpStatusCode statusCode)
            : base((int)statusCode)
        {
            this.Data = data;
            this.Success = success;
        }

        public Response(TData data, bool success, HttpStatusCode statusCode, IEnumerable<string> messages)
            : this(data, success, statusCode)
        {
            this.Messages = messages;
        }
    }
}
