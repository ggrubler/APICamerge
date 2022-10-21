using System;
using System.Collections.Generic;
using Xunit;
using APICamerge.Interfaces;
using APICamerge.Services;

namespace APICamerge.ServiceTests
{
	public class TaxaDeJurosServiceTests
	{
		[Fact]
		private void CheckIfTaxaDeJurosIsAcceptable()
		{
			ITaxaDeJurosService service = new TaxaDeJurosService();

			double expectedTaxaDeJuros = 0.05;

			double? actualTaxaDeJuros = service.GetTaxaDeJuros(expectedTaxaDeJuros);

			Assert.Equal(expectedTaxaDeJuros, actualTaxaDeJuros);
		}
	}
}
