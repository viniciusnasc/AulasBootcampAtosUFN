using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula261121POO
{
    interface IArvore
    {
        int Id { get; set; }
        string Nome { get; set; }
        void Viver();
        void Morrer();


    }
}
