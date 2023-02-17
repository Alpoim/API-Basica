using Calculo.Domain.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Domain.IApplication
{
    public interface ICalculoApplication
    {
        int Dividir(Numeros numeros);
        int Multiplicar(Numeros numeros);
        int Somar(Numeros numeros);
        int Subtrair(Numeros numeros);
    }
}
