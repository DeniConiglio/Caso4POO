using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC4.Animales
{
    public class Conejo:Animal
    {
        public Conejo(int edad, decimal altura, decimal peso, string color) : base(edad, altura, peso)
        {
            Color = color;
        }

        
        public string Color { get; set; }

        public override string ImprimirComida()
        {
            return "El conejo come Verdura";
        }
    }
}
