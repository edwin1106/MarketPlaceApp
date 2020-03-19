using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketPlaceApp.Domain.Models
{
    public class Asset
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public  string Tag { get; set; }
        [Required]
        public string ImageURL { get; set; }


    }
}
