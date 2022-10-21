using APICamerge.Interfaces;

namespace APICamerge.Services
{
	public class ShowMeTheCodeService : IShowMeTheCodeService
	{
		#region Constructor
		public ShowMeTheCodeService()
		{

		}

		#endregion

		#region Public Methods
		public string GetUrlSourceCode()
		{
			string sourceCode = "https://github.com/ggrubler/APICamerge";

			return sourceCode;
		}

		#endregion

	}
}
