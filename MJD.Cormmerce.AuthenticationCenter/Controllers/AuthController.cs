using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MJD.AgileFramework.Common.Models;
using MJD.Cormmerce.AuthenticationCenter.Model;
using MJD.Cormmerce.AuthenticationCenter.Utility;

namespace MJD.Cormmerce.AuthenticationCenter.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private ICustomJWTService _iJWTService = null;
        private HttpHelperService _HttpHelperService = null;
        public AuthController(ILogger<AuthController> logger, ICustomJWTService service, HttpHelperService httpHelperService)
        {
            _logger = logger;
            _iJWTService = service;
            _HttpHelperService = httpHelperService;
        }

        [Route("api/accredit")]
        [HttpPost]
        public JsonResult Accredit([FromForm] string username, [FromForm] string password)
        {
            AjaxResult<User> ajaxResult = _HttpHelperService.VerifyUser(username, password);
            if (ajaxResult.Success)
            {
                string token = this._iJWTService.GetToken(username, password, ajaxResult.TValue);
                ajaxResult.Value = token;
            }
            Console.WriteLine($"Accredit Result : {JsonConvert.SerializeObject(ajaxResult)}");
            return new JsonResult(ajaxResult);
        }
    }
}
