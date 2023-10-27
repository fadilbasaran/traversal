
using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Feature2
	{
        [Key]
        public int Feature2ID { get; set; }

        public string Post1Name { get; set; }

        public string Post1Description { get; set; }

        public string Post1Image { get; set; }

        public string Status { get; set; }

    }
}

