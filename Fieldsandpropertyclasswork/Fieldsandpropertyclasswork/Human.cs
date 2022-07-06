using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fieldsandpropertyclasswork
{
    internal class Human
    {
        private int eye;
        private int teeth;
        private int leg;
        public string color;

        public int EyeproPerty
        {
            get { return eye; }
            set {
            if (value != 2)
                    eye = 2;
            else
                {
                    eye = value;
                }
            }
        }

        public int TeethproPerty
        {
            get { return teeth; }
            set
            {
                if (value > 32)
                    teeth = 32;
                else
                {
                    teeth = value;
                }
            }
        }

        public int legproPerty
        {
            get { return leg; }
            set
            {
                if (value != 2)
                    leg = 2;
                else
                { 
                    leg = value;
                }
                    
            }
        }
    }
}
