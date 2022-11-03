using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaC4
{
    public abstract class Animal
    {
        private int Edad { get; }
        private decimal Altura { get; }
        private decimal Peso { get; }

        public Animal(int edad, decimal altura, decimal peso)
        {
            Edad = edad;
            Altura = altura;
            Peso = peso;
        }

        public virtual string Imprimir()
        {
            return Edad + " - " + Altura + " - " + Peso;
        }

        public abstract string ImprimirComida();
    }
}
