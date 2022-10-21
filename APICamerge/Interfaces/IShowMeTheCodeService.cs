namespace APICamerge.Interfaces
{
	public interface IShowMeTheCodeService
	{
		/// <summary>
		/// Obtém a Url em que o código fonte se encontra.
		/// </summary>
		/// <returns>Retorna a Url em que o código fonte se encontra.</returns>
		string GetUrlSourceCode();
	}
}
