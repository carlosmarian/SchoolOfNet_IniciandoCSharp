
using System;

namespace ConsoleCSharp01
{
    public enum Sexo
    {
        Masculino = 1,
        Feminimo = 2
    }

    public struct MinhaData
    {
        public DateTime dataAtual;
    }

    class Pessoa
    {
        private string nome;
        private string sobreNome;
        private int idade;
        private Sexo sexo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string SobreNome
        {
            get { return sobreNome; }
            set { sobreNome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
            }
        }

        public Sexo Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

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
