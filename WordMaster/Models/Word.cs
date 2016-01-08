using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WordMaster.Models
{
	public class Word
	{
		public int WordID { get; set; }

		[Required]
		public string Name { get; set; }

		[Required]
		public string Definition { get; set; }
		
		public virtual List<WordUsage> WordUsages { get; set; }

	}
}