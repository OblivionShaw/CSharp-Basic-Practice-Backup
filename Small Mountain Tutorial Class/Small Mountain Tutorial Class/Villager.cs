﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Small_Mountain_Tutorial_Class
{
    class Villager : Creature
    {
        public Villager(string name)
        {
            this.name = name;
        }
        public string Talk()
        {
            return "hi";
        }
    }
}
