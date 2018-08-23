using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Animal[] a = new Animal[2];


            p1.Nome = "Duda";
            p1.Idade = 24;
            p1.Identidade = 0364570420081;
            p1.Profissao = "Estudante";

            Animal a1 = new Animal();
            a1.Nome = "Bolinha";
            a1.Apelido = "Noia";
            a1.Selvagem = false;

            Animal a2 = new Animal();
            a2.Nome = "Izabel";
            a2.Apelido = "Izzie";
            a2.Selvagem = false;

            
        }
    }
}
