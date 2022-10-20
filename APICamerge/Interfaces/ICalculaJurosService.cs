namespace APICamerge.Interfaces
{
	public interface ICalculaJurosService
	{
		/// <summary>
		/// Obtém o cálculo de juros compostos.
		/// </summary>
		/// <param name="valorInicial">Valor inicial indicado pelo usuário.</param>
		/// <param name="taxaDeJuros">Taxa de juros indicada pelo usuário.</param>
		/// <param name="meses">Tempo, em meses, indicado pelo usuário.</param>
		/// <returns>Retorna o valor do juro composto.</returns>
		double GetJurosCompostos(double valorInicial, double taxaDeJuros,
			int meses);
	}
}
