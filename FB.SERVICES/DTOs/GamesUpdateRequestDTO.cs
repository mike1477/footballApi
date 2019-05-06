using System;
using System.Collections.Generic;
using System.Text;

namespace FB.SERVICES.DTOs
{
    public class GamesUpdateRequestDTO
    {
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public string Stadium { get; set; }
    }
}
