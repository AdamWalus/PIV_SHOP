﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Product
    {
        [Key]
        [Column("ProductID")]
        [Required]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
