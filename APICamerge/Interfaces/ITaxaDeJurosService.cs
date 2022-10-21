namespace APICamerge.Interfaces
{
	public interface ITaxaDeJurosService
	{
		/// <summary>
		/// Obtém a taxa de juros indicada pelo usuário.
		/// </summary>
		/// <param name="taxaDeJuros">Taxa de juros indicada pelo usuário.</param>
		/// <returns>Retorna a taxa de juros indicada pelo usuário.</returns>
		double? GetTaxaDeJuros(double? taxaDeJuros);
	}
}
