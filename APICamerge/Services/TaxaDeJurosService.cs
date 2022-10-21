
using APICamerge.Interfaces;

namespace APICamerge.Services
{
	public class TaxaDeJurosService : ITaxaDeJurosService
	{
		#region Constructor

		public TaxaDeJurosService()
		{

		}

		#endregion

		#region Public Methods

		public double? GetTaxaDeJuros(double? taxaDeJuros)
		{
			if (taxaDeJuros < 0) return null;

			else return taxaDeJuros;
				
		}

		#endregion

	}
}
