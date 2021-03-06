﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public class Iguana : Lizard
    {
        public override bool LooksSlimey { get; set; } = false;
        public string Name { get; set; } = "iguana";

        public override string Eat()
        {
            return "Eating some bugs";
        }

        public override string Sleep()
        {
            return "ZZZZZZZ";
        }

        public override bool Slither()
        {
            return false;
        }

        public override bool LayEggs()
        {
            return true;
        }
    }
}
