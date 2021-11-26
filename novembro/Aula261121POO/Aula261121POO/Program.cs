using System;

namespace Aula261121POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Disciplina d1 = new("POO", 16);

            d1.GetNome();
            d1.GetCargaHoraria();

            Carro c1 = new();
            c1.ExibeMotor();
        }
    }
}
