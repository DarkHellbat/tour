﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tour
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public override string ToString()
        {
            return this.CountryName;
        }
    }
}
