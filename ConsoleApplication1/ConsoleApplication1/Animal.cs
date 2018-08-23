using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {
        private String nome;
        private String apelido;
        private bool selvagem;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Apelido
        {
            get
            {
                return apelido;
            }

            set
            {
                apelido = value;
            }
        }

        public bool Selvagem
        {
            get
            {
                return selvagem;
            }

            set
            {
                selvagem = value;
            }
        }

        public String Comunicar()
        {
            return ("Está comunicando...");
        }

        public void Brincar()
        {
            Console.WriteLine("Está brincando...");
        }
    }
}
