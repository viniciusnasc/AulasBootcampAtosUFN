using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Motor
    {
        private string NomeFabricante;
        private int Potencia;
        private string Tipo;

        public Motor(string nomeFabricante, int potencia, string tipo)
        {
            NomeFabricante = nomeFabricante;
            Potencia = potencia;
            Tipo = tipo;
        }

        public void SetInformacoes(string nomeFabricante, int potencia, string tipo)
        {
            NomeFabricante = nomeFabricante;
            Potencia = potencia;
            Tipo = tipo;
        }

        public void GetInformacoes()
        {
            Console.WriteLine($"Fabricante: {NomeFabricante};\nPotencia: {Potencia};\nTipo: {Tipo}.");
        }
    }
}
