using APICamerge.Interfaces;
using System;

namespace APICamerge.Services
{
	public class CalculaJurosService : ICalculaJurosService
	{
		#region Constructor

		public CalculaJurosService()
		{

		}

		#endregion

		#region Public Methods

		public double GetJurosCompostos(double valorInicial, double taxaDeJuros,
			int meses)
		{
			double valorFinal = valorInicial * Math.Pow((1 + taxaDeJuros), meses);

			return Math.Round(valorFinal, 2);
		}

		#endregion
	}
}
