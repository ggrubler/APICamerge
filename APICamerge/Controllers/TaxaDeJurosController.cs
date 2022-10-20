using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using APICamerge.Interfaces;

namespace APICamerge.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class TaxaDeJurosController : ControllerBase
    {
        #region Attributes

        private readonly ITaxaDeJurosService TaxaDeJurosService;

        #endregion

        #region Constructor

        public TaxaDeJurosController(ITaxaDeJurosService taxaDeJurosService)
        {
            TaxaDeJurosService = taxaDeJurosService;
        }

        #endregion

        #region Requests

        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(double))]
        [SwaggerResponse((int)HttpStatusCode.NoContent, Type = typeof(Nullable))]
        [HttpGet]
        [Route("/TaxaDeJuros")]
        public IActionResult GetTaxaDeJuros([FromQuery] [Required] double taxaDeJuros)
        {
            return Ok(TaxaDeJurosService.GetTaxaDeJuros(taxaDeJuros));
        }

        #endregion

    }
}

