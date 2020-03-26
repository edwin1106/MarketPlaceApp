using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlaceApp.Commands
{
    public class CrearAsset
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Tag { get; set; }
        [Required]
        public string ImageURL { get; set; }
    }
}
