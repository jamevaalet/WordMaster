using System.ComponentModel.DataAnnotations;

namespace WordMaster.Models
{
	public class WordUsage
	{
		public int WordUsageID { get; set; }

		public int WordID { get; set; }

		[Required]
		public string Usage { get; set; }
	}
}