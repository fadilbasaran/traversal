﻿using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Feature
	{

        [Key]
        public int FeatureID { get; set; }

		public string Post1Name { get; set; }

		public string Post1Description { get; set; }

		public string Post1Image { get; set; }

		public string Status { get; set; }



	}
}

