using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Domain.Objetos
{
    public class Numeros
    {
        public int numero1 { get; set; }
        public int numero2 { get; set; }


        public int Somar()
        {
            return numero1 + numero2;
        }
        public int Subtrair()
        {
            return numero1 - numero2;
        }
        public int Multiplicar()
        {
            return numero1 * numero2;
        }
        public int Dividir()
        {
            return numero1 / numero2;
        }
    }
}
