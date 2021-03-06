﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Medal
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Material { get; set; }

        public static string ToString(Medal medal)
        {
            return $"{medal.Material} {medal.Title}";
        }
    }
}
