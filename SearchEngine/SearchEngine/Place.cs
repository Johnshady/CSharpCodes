﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    internal class Place
    {
        public Place(string name,string county,string country)
        {
            Name = name;
            County = county;
            Country = country;
        }     
        public string Name { get; }
        public string County { get;  }
        public string Country { get; }
        

    }
}
