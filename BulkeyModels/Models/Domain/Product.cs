﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BulkeyModels.Models.Domain
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(0, 1000)]
        public double ListPrice { get; set; }
        [Required]
        [Display(Name = "Price for 1-50")]
        [Range(0, 1000)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Price for 50+")]
        [Range(0, 1000)]
        public double Price50 { get; set; }
        [Required]
        [Display(Name = "Price for 100+")]
        [Range(0, 1000)]
        public double Price100 { get; set; }
        public Guid CatagoryId { get; set; }

        [ForeignKey("CatagoryId")]
        public Catagory Catagory { get; set; }
        public string?ImageUrl { get; set; }
        
    }
}

