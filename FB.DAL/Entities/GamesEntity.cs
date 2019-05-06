using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FB.DAL.Entities
{
    public class GamesEntity
    {
        public int Id { get; set; }
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public string Stadium { get; set; }
    }
}
