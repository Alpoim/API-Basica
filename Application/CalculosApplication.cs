using Calculo.Domain.IApplication;
using Calculo.Domain.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Application
{
    public class CalculosApplication : ICalculoApplication
    {
        public int Somar(Numeros numeros)
        {
            return numeros.Somar();

        }
        public int Subtrair(Numeros numeros)
        {
            return numeros.Subtrair();

        }
        public int Multiplicar(Numeros numeros)
        {
            return numeros.Multiplicar();

        }
        public int Dividir(Numeros numeros)
        {
            if(numeros.numero2 == 0)
            {
                throw new Exception ("Não pode dividir por 0");
            }

            return numeros.Dividir();

        }
    }
}
