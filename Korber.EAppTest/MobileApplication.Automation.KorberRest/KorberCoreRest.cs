using MobileApplication.Automation.Common.KorberCore;
using MobileApplication.Automation.KorberRest;
using MobileApplication.Automation.KorberRest.Dto;
using System.Collections.Generic;

namespace MobileApplication.Automation.KorberRest
{
	public class KorberCoreRest : KoberRest
	{

		public KorberCoreRest(string korberCoreUrl, AuthenticationRest authenticationTicket) //url= "http://localhost:30000"
            :base(korberCoreUrl, authenticationTicket)

        {
		}
		public IEnumerable<LanguageModelDto> GetLanguageModels()
		{
			return GetRest<LanguageModelDto>("LanguageModels");
		}

	}
}
