using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REstfulAnimalProject.Models {
    public class Animal {

        public int AnimalId { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public bool IsLandAnimal { get; set; }
    }
}
