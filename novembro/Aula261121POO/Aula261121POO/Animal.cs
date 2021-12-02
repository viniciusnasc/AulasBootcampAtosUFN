using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    public abstract class Animal
    {
        public string _especie;
        public string _sexo;
        public string _raca;

        public string especie { get => _especie; set => _especie = value; }
        public string sexo { get => _sexo; set => _sexo = value; }
        public string raca { get => _raca; set => _raca = value; }

        /*
        public Animal(string especie, string sexo, string raca)
        {
            this._especie = especie;
            this._sexo = sexo;
            this._raca = raca;
        }
        */

        public abstract string EmitirSom();

        public void Dormir()
        {
            Console.WriteLine($"O {especie} dormiu");
        }

        public void Caminhar()
        {
            Console.WriteLine($"o {especie} caminhou");
        }
    }
}
