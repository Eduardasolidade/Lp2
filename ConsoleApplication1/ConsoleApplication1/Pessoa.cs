using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pessoa
    {
        private String nome;
        private int idade, qtd = 0;
        private long identidade;
        private String profissao;
        const int MAX = 2;

        private Animal[] pets = new Animal[MAX];



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

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public long Identidade
        {
            get
            {
                return identidade;
            }

            set
            {
                identidade = value;
            }
        }

        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }

        public String Falar()
        {
            return ("Está falando.");
        }
        public void Trabalhar()
        {
            Console.WriteLine("Está trabalhando!");
        }

        public void Comer()
        {
            Console.WriteLine("Está comendo...");
        }

        public void AddAnimal(Animal a)
        {
            if (qtd <= MAX)
            {
                pets[qtd] = a;
                qtd++;

            }

        }

       
    }
}
