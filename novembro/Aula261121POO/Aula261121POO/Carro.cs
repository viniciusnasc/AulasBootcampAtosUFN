using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Carro
    {
        private string _modelo;
        private string _cor;
        private int _anoMarca;
        private int _chassi;
        private string _proprietario;
        private double _velocidadeMax;
        private double _velocidadeAtual;
        private int _numPortas;
        private bool _tetoSolar;
        private int _numMarcha;
        private bool _cambioAutomatico;
        private double _volumeCombustivel;

        public Carro(string modelo, string cor, int anoMarca, int chassi,
                     string proprietario, double velocidadeMax, double velocidadeAtual, int numPortas,
                     bool tetoSolar, int numMarcha, bool cambioAutomatico, double volumeCombustivel)
        {
            _modelo = modelo;
            _cor = cor;
            _anoMarca = anoMarca;
            _chassi = chassi;
            _proprietario = proprietario;
            _velocidadeMax = velocidadeMax;
            _velocidadeAtual = velocidadeAtual;
            _numPortas = numPortas;
            _tetoSolar = tetoSolar;
            _numMarcha = numMarcha;
            _cambioAutomatico = cambioAutomatico;
            _volumeCombustivel = volumeCombustivel;
        }

        public void Acelerar()
        {
            if (_velocidadeAtual < _velocidadeMax)
                _velocidadeAtual++;
        }

        public void Freia()
        {
            _velocidadeAtual = 0;
        }

        public void TrocaMarcha()
        {
            _numMarcha++;
        }

        public void ReduzMarcha()
        {
            _numMarcha--;
        }
    }
}
