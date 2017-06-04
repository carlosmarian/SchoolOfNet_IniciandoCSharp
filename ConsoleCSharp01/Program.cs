using System;

namespace ConsoleCSharp01
{
    class ConsoleCSharp
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.SobreNome = "Silva";
            pessoa.Sexo = 'M';
            pessoa.Idade = 20;

            pessoa.Idade = -1;

            pessoa.Falar(string.Format("Olá, sou o {0} {1} e tenho {2} anos ", pessoa.Nome, pessoa.SobreNome, pessoa.Idade));

            pessoa = new Pessoa();

            pessoa.Falar(string.Format("Olá, sou o {0} {1} e tenho {2} anos ", pessoa.Nome, pessoa.SobreNome, pessoa.Idade));
            Console.ReadLine();
        }
    }
}