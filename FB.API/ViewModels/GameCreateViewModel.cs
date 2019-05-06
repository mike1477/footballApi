using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FB.API.ViewModels
{
    public class GameCreateViewModel
    {
        [Required]
        public string TeamHome { get; set; }

        [Required]
        public string TeamAway { get; set; }

        [Required]
        public string Stadium { get; set; }
    }
}
