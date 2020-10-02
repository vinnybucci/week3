using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace PetElevator
{
   public class Pet
    {
        public string PetName { get; set; }
        public string Species { get; set; }
        public List<string> Vaccinations { get; set; } = new List<string>();

        public Pet(string PetName, string Species)
        {
            this.PetName = PetName;
            this.Species = Species;

        }

        public string ListVaccinations()
        {
            string vaccineList = String.Join(", ", Vaccinations);
            return vaccineList;
        }

    }
}
