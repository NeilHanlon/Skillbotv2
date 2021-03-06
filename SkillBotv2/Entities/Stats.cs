﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBotv2.Entities
{
    class Stats
    {
        public Stat Overall { get; set; }
        public Stat Attack { get; set; }
        public Stat Defence { get; set; }
        public Stat Strength { get; set; }
        public Stat Constitution { get; set; }
        public Stat Ranged { get; set; }
        public Stat Prayer { get; set; }
        public Stat Magic { get; set; }
        public Stat Cooking { get; set; }
        public Stat Woodcutting { get; set; }
        public Stat Fletching { get; set; }
        public Stat Fishing { get; set; }
        public Stat Firemaking { get; set; }
        public Stat Crafting { get; set; }
        public Stat Smithing { get; set; }
        public Stat Mining { get; set; }
        public Stat Herblore { get; set; }
        public Stat Agility { get; set; }
        public Stat Thieving { get; set; }
        public Stat Slayer { get; set; }
        public Stat Farming { get; set; }
        public Stat Runecrafting { get; set; }
        public Stat Hunter { get; set; }
        public Stat Construction { get; set; }
        public Stat Summoning { get; set; }
        public Stat Dungeoneering { get; set; }
        public Stat Divination { get; set; }
        public Stat Invention { get; set; }

        public Stat GetStatForName(string name)
        {
            return (Stat) GetType().GetProperty(name).GetMethod.Invoke(this, null);
        }

        public struct Stat
        {
            public int Rank { get; set; }
            public int Level { get; set; }
            public long Exp { get; set; }

            public static Stat CreateFromCSV(string[] parts)
            {
                return new Stat
                {
                    Rank = int.Parse(parts[0]),
                    Level = int.Parse(parts[1]),
                    Exp = long.Parse(parts[2])
                }; ;
            }
        }
    }
}
