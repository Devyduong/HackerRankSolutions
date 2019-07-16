using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEntity.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
    }
}