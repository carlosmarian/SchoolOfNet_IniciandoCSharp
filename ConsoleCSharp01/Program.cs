using System;

namespace ConsoleCSharp01
{
    class ConsoleCSharp
    {
        static void Main()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "João";
            pessoa.sobreNome = "Silva";
            pessoa.sexo = 'M';
            pessoa.idade = 20;

            pessoa.Falar(string.Format("Olá, sou o {0} {1} e tenho {2} anos ", pessoa.nome, pessoa.sobreNome, pessoa.idade));

            pessoa = new Pessoa();

            pessoa.Falar(string.Format("Olá, sou o {0} {1} e tenho {2} anos ", pessoa.nome, pessoa.sobreNome, pessoa.idade));
            Console.ReadLine();
        }
    }
}