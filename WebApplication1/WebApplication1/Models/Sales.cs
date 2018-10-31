using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public virtual Product Product { get; set; }
    }
}