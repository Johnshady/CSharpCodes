using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_assignment
{
    internal class Animals
    {
        public string Name { get; set; }
        public string Mode_of_nutrirtion { get; set; }
        public string Habitat { get; set; }
        public bool Herbivorios { get; set; }
        public bool Movement { get; set; }
        public int Horn { get; set; }
        public string Classes { get; set; }


        public Animals()
        {

        }

        public Animals(string name, string mode, string hab, bool herb, bool move, int hrn, string classe)
        {
            Name = name;
            Mode_of_nutrirtion = mode;
            Habitat = hab;
            Herbivorios = herb;
            Movement = move;
            Horn = hrn;
            Classes = classe;
        }
    }
}
