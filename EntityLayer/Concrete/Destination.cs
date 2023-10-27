using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Destination
	{

        [Key]
        public int DestinationID { get; set; }

		public string City { get; set; }

		public string DayNight { get; set; }

		public double Price { get; set; }

		public string Image { get; set; }

		public string Descriptoin { get; set; }

		public string Capacity { get; set; }

		public bool Status { get; set; }
		


	}
}

