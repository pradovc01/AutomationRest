using Korber.EAppTest.MT.MobileApplication.Automation.Tests.Users;
using System.Linq;
using Xunit;

namespace Korber.EAppTest.MT.MobileApplication.Automation.Tests.Tests
{
	public class TCyyy: ClientFixture<TestUser>
	{
		[Fact(DisplayName = "Tcyy")]
		[Trait("Category", "Rest")]
		public void SetupCompanFromScratch()
		{
      var language = "test";
      var languageModels = korberCoreLRest.GetLanguageModels();
      Assert.True(languageModels.Any(), $"Application does not have any Languages registered.");
      var languageregistered = languageModels.Where(l => l.LanguageId == language).FirstOrDefault();
      Assert.True(languageregistered != null, $"Language[{language}] is not registered in App.");
    }
	}
}
