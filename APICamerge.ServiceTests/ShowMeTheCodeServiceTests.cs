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
	public class ShowMeTheCodeServiceTests
	{
		[Fact]
		private void CheckIfUrlIsCorrect()
		{
			IShowMeTheCodeService service = new ShowMeTheCodeService();

			string expectedSourceCode = "https://github.com/ggrubler/APICamerge";

			string actualSourceCode = service.GetSourceCode();

			Assert.Equal(expectedSourceCode, actualSourceCode);
		}
	}
}
