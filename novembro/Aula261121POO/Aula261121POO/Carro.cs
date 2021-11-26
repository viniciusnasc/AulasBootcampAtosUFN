using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Carro
    {
        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        public int AnoMarca { get; private set; }
        public int Chassi { get; private set; }
        public string Proprietario { get; private set; }
        public double VelocidadeMax { get; private set; }
        public double VelocidadeAtual { get; private set; }
        public int NumPortas { get; private set; }
        public bool TetoSolar { get; private set; }
        public int NumMarcha { get; private set; }
        public bool CambioAutomatico { get; private set; }
        public double VolumeCombustivel { get; private set; }

        public Carro(string modelo, string cor, int anoMarca, int chassi,
                     string proprietario, double velocidadeMax, double velocidadeAtual, int numPortas,
                     bool tetoSolar, int numMarcha, bool cambioAutomatico, double volumeCombustivel)
        {
            Modelo = modelo;
            Cor = cor;
            AnoMarca = anoMarca;
            Chassi = chassi;
            Proprietario = proprietario;
            VelocidadeMax = velocidadeMax;
            VelocidadeAtual = velocidadeAtual;
            NumPortas = numPortas;
            TetoSolar = tetoSolar;
            NumMarcha = numMarcha;
            CambioAutomatico = cambioAutomatico;
            VolumeCombustivel = volumeCombustivel;
        }

        public void Acelerar()
        {
            if (VelocidadeAtual < VelocidadeMax)
                VelocidadeAtual++;
        }

        public void Freia()
        {
            VelocidadeAtual = 0;
        }

        public void TrocaMarcha()
        {
            NumMarcha++;
        }

        public void ReduzMarcha()
        {
            NumMarcha--;
        }
    }
}
