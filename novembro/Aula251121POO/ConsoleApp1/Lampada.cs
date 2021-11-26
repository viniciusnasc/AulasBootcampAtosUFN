using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula251121POO
{
    class Lampada
    {
        private int Ligado;
        //private string Marca;
        //private int Potencia;

        public void Ligar()
        {
            Ligado = 1;
        }

        public void Desligar()
        {
            Ligado = 0;
        }

        public void MeiaLuz()
        {
            Ligado = 2;
        }

        public int EstaLigada()
        {
            return Ligado;
        }
    }
}
