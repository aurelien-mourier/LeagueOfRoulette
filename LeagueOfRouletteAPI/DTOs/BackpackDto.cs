﻿using LeagueOfRouletteAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueOfRouletteAPI.DTOs
{
    public class BackpackDto
    {
        public int BackpackId { get; set; }
        public string Label { get; set; }
        public ICollection<BackpackCardDto> BackpackCard { get; set; }
    }
}
