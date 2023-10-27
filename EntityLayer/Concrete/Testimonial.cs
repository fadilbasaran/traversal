using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Testimonial
	{
        [Key]
        public int TestimonialID { get; set; }

		public string Cliant { get; set; }

		public string Comment { get; set; }

        public string CliantImage { get; set; }

        public string Status { get; set; }

    }
}

