using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string  Name { get; set; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}