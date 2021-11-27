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

            Animal a1 = new("cachorro", "m", "pitbull");

            a1.Caminhar();
            a1.Dormir();
            a1.EmitirSom();
        }
    }
}
