using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using APICamerge.Interfaces;

namespace APICamerge.Controllers
{
	public class CalculaJurosController : ControllerBase
	{
        #region Attributes

        private readonly ICalculaJurosService CalculaJurosService;

        #endregion

        #region Constructor

        public CalculaJurosController(ICalculaJurosService calculaJurosService)
        {
            CalculaJurosService = calculaJurosService;
        }

        #endregion

        #region Requests

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(double))]
        [SwaggerResponse((int)HttpStatusCode.NoContent, Type = typeof(Nullable))]
        [HttpGet]
        [Route("/CalculaJuros")]
        public IActionResult GetJurosCompostos([FromQuery][Required] double valorInicial,
            double taxaDeJuros, int meses)
        {
            return Ok(CalculaJurosService.GetJurosCompostos(valorInicial,
                taxaDeJuros, meses));
        }

        #endregion
    }
}
