using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAnInsect
{
    class Player
    { public int Height { get; set; }
        public string HairColor { get; set; }
        public string Weapon { get; set;}
        public string Clothing { get; set; }

        public string Name { get; set; }
        public int Lifespan { get; set; }
        public int Weight { get; set; }
        public string Species { get; set; }

        public void Adopt(Insect insect)
        {
            Console.WriteLine($"Thank you for adopting {insect.Name}");
        }
    }
}
