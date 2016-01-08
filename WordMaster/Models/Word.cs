using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordMaster.Models
{
	public class Word
	{
		public int WordID { get; set; }
		public string Name { get; set; }
		public string Definition { get; set; }
		public List<WordUsage> WordUsages { get; set; }

	}
}