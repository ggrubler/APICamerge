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

        /// <summary>
		/// Obtém o cálculo de juros compostos.
		/// </summary>
		/// <param name="valorInicial">Valor inicial indicado pelo usuário.</param>
		/// <param name="taxaDeJuros">Taxa de juros indicada pelo usuário.</param>
		/// <param name="meses">Tempo, em meses, indicado pelo usuário.</param>
		/// <returns>Retorna o valor do juro composto.</returns>
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(double))]
        [SwaggerResponse((int)HttpStatusCode.NoContent, Type = typeof(Nullable))]
        [HttpGet]
        [Route("/CalculaJuros")]
        public IActionResult GetJurosCompostos([FromQuery][Required] double valorInicial,
            [FromQuery][Required] double taxaDeJuros,
            [FromQuery][Required] int meses)
        {
            return Ok(CalculaJurosService.GetJurosCompostos(valorInicial,
                taxaDeJuros, meses));
        }

        


        #endregion
    }
}
