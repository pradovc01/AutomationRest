using HighJump.Platform.Html.Automation.Tests.Base;
using Korber.EAppTest.MT.MobileApplication.Automation.Tests.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Korber.EAppTest.MT.MobileApplication.Automation.Tests.Tests
{
	public class TCxxx : AutomationTestsBase<TestUser>
	{
		public TCxxx(ClientFixture<TestUser> clientFixture,
				AutomationFixture<TestUser, PlatformConnection> automation,
				ITestOutputHelper output)
            : base(clientFixture, automation, output)
        {
		}

		[Fact(DisplayName = "TCxxx Verify xxx")]
		[Trait("Category", "UI")]
		public void TC140778_Verifyxxx()
		{
			var language = "test";
			var languageModels = ClientFixture.korberCoreLRest.GetLanguageModels();
			Assert.True(languageModels.Any(), $"Application does not have any Languages registered.");
			var languageregistered = languageModels.Where(l => l.LanguageId == language).FirstOrDefault();
			Assert.True(languageregistered != null, $"Language[{language}] is not registered in App.");
		}
	}
}
