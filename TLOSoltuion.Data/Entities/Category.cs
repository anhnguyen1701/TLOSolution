﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TLOSoltuion.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set;}
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Imagepath { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
