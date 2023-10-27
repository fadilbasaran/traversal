using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class NewsLetter
	{
        [Key]
        public int NewsLetteID { get; set; }

		public string Mail { get; set; }


	}
}

