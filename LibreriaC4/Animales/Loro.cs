using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC4.Animales
{
    public class Loro:Animal
    {
        public Loro(int edad, decimal altura, decimal peso, string tipo) : base(edad, altura, peso)
        {
            Tipo = tipo;
        }


        public string Tipo { get; set; }

        public override string ImprimirComida()
        {
            return "El loro come semillas";
        }
    }
}
