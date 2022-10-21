using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;
using APICamerge.Interfaces;

namespace APICamerge.Controllers
{
	public class ShowMeTheCodeController_old : ControllerBase
	{
		#region Attributes

		private readonly IShowMeTheCodeService ShowMeTheCodeService;

		#endregion

		#region Constructor

		public ShowMeTheCodeController_old(IShowMeTheCodeService showMeTheCodeService)
		{
			ShowMeTheCodeService = showMeTheCodeService;
		}

		#endregion

		#region Requests

		/// <summary>
		/// Obtém o endereço onde o código fonte se encontra.
		/// </summary>
		/// <returns>Retorna o endereço onde o código fonte se encontra.</returns>
		[SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(string))]
		[SwaggerResponse((int)HttpStatusCode.NoContent, Type = typeof(Nullable))]
		[HttpGet]
		[Route("/ShowMeTheCode")]
		public IActionResult GetUrlSourceCode()
		{
			return Ok(ShowMeTheCodeService.GetUrlSourceCode());
		}
		#endregion
	}
}
