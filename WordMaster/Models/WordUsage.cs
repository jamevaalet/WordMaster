using System.ComponentModel.DataAnnotations;

namespace WordMaster.Models
{
	public class WordUsage
	{
		public int WordUsageID { get; set; }

		[Required]
		public Word Word { get; set; }
		public string Usage { get; set; }
	}
}