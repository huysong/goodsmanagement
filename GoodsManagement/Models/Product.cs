﻿
using System.ComponentModel.DataAnnotations;

namespace GoodsManagement.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
