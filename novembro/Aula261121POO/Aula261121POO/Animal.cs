using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    class Animal
    {
        private string _especie;
        private string _sexo;
        private string _raca;

        public string especie { get => _especie; set => _especie = value; }
        public string sexo { get => _sexo; set => _sexo = value; }
        public string raca { get => _raca; set => _raca = value; }

        public Animal(string especie, string sexo, string raca)
        {
            this.especie = especie;
            this.sexo = sexo;
            this.raca = raca;
        }

        public void EmitirSom()
        {
            Console.WriteLine($"O {especie} emitiu um som");
        }

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
