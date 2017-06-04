using System;
using System.Collections;

namespace ConsoleCSharp01
{
    class ConsoleCSharp
    {
        static void Main()
        {

            //Queue fila = new Queue();

            //fila.Enqueue("Carlos");
            //fila.Enqueue("Maria");
            //fila.Enqueue("Pedro");

            //while(fila.Count > 0)
            //{
            //    var valor = fila.Dequeue();
            //    Console.WriteLine(valor);
            //}

            //Stack pilha = new Stack();

            //pilha.Push("Carlos 1");
            //pilha.Push("Maria 2");
            //pilha.Push("Pedro 3");
            //pilha.Push("João 4");

            //while(pilha.Count > 0)
            //{
            //    var valor = pilha.Pop();
            //    Console.WriteLine(valor);
            //}

            ArrayList lista = new ArrayList();

            lista.Insert(0, "Carlos 1");            
            lista.Insert(1, "Joao 2");
            lista.Insert(2, "Maria 3");
            lista.Insert(3, "Pedro 4");
            lista.Insert(2, "MARIA 3");

            for (int i = 0; i < lista.Count; i++)
            {
                var item = lista[i];

                Console.WriteLine(item);

            }



            ////MinhaData m = new MinhaData();
            ////m.dataAtual

            //Pessoa pessoa = new Pessoa();
            //pessoa.Nome = "João";
            //pessoa.SobreNome = "Silva";
            //pessoa.Sexo = Sexo.Masculino;
            //pessoa.Idade = 20;

            //pessoa.Idade = -1;

            //pessoa.Falar(string.Format("Olá, sou o {0} {1} e tenho {2} anos ", pessoa.Nome, pessoa.SobreNome, pessoa.Idade));

            //pessoa = new Pessoa();

            //pessoa.Falar(string.Format("Olá, sou o {0} {1} e tenho {2} anos ", pessoa.Nome, pessoa.SobreNome, pessoa.Idade));
            Console.ReadLine();
        }
    }
}