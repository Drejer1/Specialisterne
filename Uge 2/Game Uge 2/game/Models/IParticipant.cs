﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Models
{
    interface IParticipant
    {
        public void drawCard();
        List<Card> Hand { get; set; }

    }
}
