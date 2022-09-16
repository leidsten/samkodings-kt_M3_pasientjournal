using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasientRegistration
{
    internal class Pasient
    {
        private string Name { get; set; }
        public string Illness { get; set; }


        public Pasient (string name, string illness)
        {
            Name = name;
            Illness = illness;
        }

      
        public string PrintInfo()
        {
            return Name + " " + Illness;
        }
    }
}
