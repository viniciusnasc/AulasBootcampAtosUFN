using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Carro
    {
        public string _modelo;
        public string _cor;
        public int _anoMarca;
        public int _chassi;
        public string _proprietario;
        private double _velocidadeMax;
        public double _velocidadeAtual;
        public int _numPortas;
        public bool _tetoSolar;
        public int _numMarcha;
        public bool _cambioAutomatico;
        public double _volumeCombustivel;

        public string modelo { get => _modelo; set => _modelo = value; }
        public string cor { get => _cor; set => _cor = value; }
        public int anoMarca { get => _anoMarca; set => _anoMarca = value; }
        public int chassi { get => _chassi; set => _chassi = value; }
        public string proprietario { get => _proprietario; set => _proprietario = value; }
        public double velocidadeMaxima { get => _velocidadeMax; set => _velocidadeMax = value; }
        public double velocidadeAtual { get => _velocidadeAtual; set => _velocidadeAtual = value; }
        public int numPortas { get => _numPortas; set => _numPortas = value; }
        public bool tetoSolar { get => _tetoSolar; set => _tetoSolar = value; }
        public int numMarcha { get => _numMarcha; set => _numMarcha = value; }
        public bool cambioAutomatico { get => _cambioAutomatico; set => _cambioAutomatico = value; }
        public double volumeCombustivel { get => _volumeCombustivel; set => _volumeCombustivel = value; }

        public Carro(string modelo, string cor, int anoMarca, int chassi,
                     string proprietario, double velocidadeMax, double velocidadeAtual, int numPortas,
                     bool tetoSolar, int numMarcha, bool cambioAutomatico, double volumeCombustivel)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.anoMarca = anoMarca;
            this.chassi = chassi;
            this.proprietario = proprietario;
            this.velocidadeMaxima = velocidadeMax;
            this.velocidadeAtual = velocidadeAtual;
            this.numPortas = numPortas;
            this.tetoSolar = tetoSolar;
            this.numMarcha = numMarcha;
            this.cambioAutomatico = cambioAutomatico;
            this.volumeCombustivel = volumeCombustivel;
        }

        public void Acelerar()
        {
            if (_velocidadeAtual < _velocidadeMax)
                velocidadeAtual++;
        }

        public void Freia()
        {
            velocidadeAtual = 0;
        }

        public void TrocaMarcha()
        {
            numMarcha = _numMarcha++;
        }

        public void ReduzMarcha()
        {
            numMarcha = _numMarcha--;
        }
    }
}
