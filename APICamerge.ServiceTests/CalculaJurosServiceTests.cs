using APICamerge.Interfaces;
using APICamerge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace APICamerge.ServiceTests
{
	public class CalculaJurosServiceTests
	{
		[Fact]
		private void CheckIfCalculaJurosIsCorrect()
		{
			ICalculaJurosService service = new CalculaJurosService();

			int expectedValorInicial = 100;
			double expectedTaxaDeJuros = 0.01;
			int expectedMeses = 5;

			double expectedValorFinal = 105.10;

			double actualValorFinal = service.GetJurosCompostos(expectedValorInicial,
				expectedTaxaDeJuros, expectedMeses);

			Assert.Equal(expectedValorFinal, actualValorFinal);
		}
	}
}
