using System.Collections.Generic;

namespace MobileApplication.Automation.KorberRest
{
	public class DataKorber<T> where T : class
	{
		public IEnumerable<T> Value { get; set; }
	}
}
