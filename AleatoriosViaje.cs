using Ejercicio03Marzo.Algoritmos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03Marzo.Algoritmos.MetodosAlgoritmos
{
    public class AleatoriosViaje
    {
        public List<viaje> listaViajes = new List<viaje>();
        //public List<int> listaAleatorios = new List<int>();
        public AleatoriosViaje()
        {
        }
        public double GenerarPoisson(double lambda)
        {
            Random random = new Random();
            double l = Math.Exp(-lambda);
            double p = 1;
            int i = 0;

            while (l > p)
            {
                i++;
                p *= random.NextDouble();
            }
            return i - 1;
        }
        public double GenerarExponencial(double lambda)
        {
            Random random = new Random();
            double Comosea = random.NextDouble();
            double l = -Math.Log(1 - Comosea) / lambda;
            return l;
        }

        public List < viaje > LlenarDatosListaViajes (int totalviajes)
        {

        }


        
    }
}
   
