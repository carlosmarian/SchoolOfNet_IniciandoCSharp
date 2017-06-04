
using System;

namespace ConsoleCSharp01
{
    class Pessoa
    {
        public string nome;
        public string sobreNome;
        public int idade;
        public char sexo;

        //Construtor
        public Pessoa()
        {
            nome = "Paulo";
        }

        public void Falar(string algo)
        {
            Console.WriteLine(algo);

        }        
    }
}
