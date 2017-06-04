using System;

class ConsoleCSharp
{
    private void iniciandoComCSharp()
    {
        //Operadores de comparacao;
        //int a = 10;
        //int b = 10;

        //if (a != b)
        //    Console.WriteLine("Diferentes");
        //else
        //    Console.WriteLine("A igual a b");

        //if (a == b)
        //{
        //    Console.WriteLine("A igual a b");
        //}
        //else
        //    Console.WriteLine("Diferentes");

        //if (a >= b)
        //    Console.WriteLine("a maior igual que b");
        //else if (b >= a)
        //    Console.WriteLine("b maior igual que a");


        ////Repetição
        //int[] colecao = new int[] { 1, 2, 3, 4, 5 };

        //int indice = 12;

        //do
        //{
        //    Console.WriteLine(indice);
        //    indice--;
        //} while (indice > 10);

        //while (indice > 0)
        //{
        //    Console.WriteLine(indice);
        //    indice--;
        //}

        //for (int i = 0; i < colecao.Length; i++)
        //{
        //    Console.WriteLine( string.Format("{0} {1}", i, colecao[i]));
        //}

        //foreach (var item in colecao)
        //{
        //    Console.WriteLine(item);
        //}


        //int idade = 70;

        //switch (idade)
        //{
        //    case 80:
        //    case 70:
        //    case 60:
        //        Console.WriteLine("Aposentado");
        //        break;
        //    case 10:
        //        Console.WriteLine("Criança");
        //        break;
        //    default:
        //        Console.WriteLine("Nenhum");
        //        break;
        //}


        //string resultado = idade > 60 ? "Aposentado" : "Trabalhando";
        //Console.WriteLine(resultado);

        //if (idade > 17)
        //{
        //    Console.WriteLine("Autorizado");
        //    Console.WriteLine("Certo");
        //}
        //else if (idade > 2)
        //    Console.WriteLine("Bebe suco");
        //else
        //    Console.WriteLine("Bebe leite");


        //int a = 15;
        //int b = 2;

        //a++;//incremento simples;
        //a += 2;//incremento de + x, neste caso 2
        //a--;
        //a -= 2;
        //Console.WriteLine(a);
        //decimal resultado = (Convert.ToDecimal(a) / Convert.ToDecimal(b));

        //int resultado = a / b;
        //int resto = a % b; //obter a sobra(MOD)

        //Console.WriteLine(resultado);
        //Console.WriteLine(resto);

        //int matricula = 10;
        //string nome = "Pedro";
        //string sobreNome = "Silva";
        //DateTime dataNascimento = DateTime.Now;
        //decimal salario = 1000.50M; //valor decimal é para sufixo M
        //bool feriasVencidas = true;
        //char sexo = 'M';


        //Console.WriteLine(string.Format("Nome: {0} {1}", nome, sobreNome));

    }

    static String retornarString()
    {
        return "Mensagem retorno";
    }

    public static void exibirMensagem()
    {
        Console.WriteLine("Mensagem");
    }

    static void imprimirValor(decimal parametrodecimal, string parametroString)
    {
        parametrodecimal++;
        Console.WriteLine(parametrodecimal);
        Console.WriteLine(parametroString);
    }

    static void Soma10(ref int valor)
    {
        valor += 10;
        Console.WriteLine(valor);
    }

    static void Main()
    {
        decimal numero = 100.33m;
        imprimirValor(numero, "teste");
        Console.WriteLine(numero);

        int valorInicial = 10;
        Soma10(ref valorInicial);
        Console.WriteLine(valorInicial);

        //exibirMensagem();
        //Console.WriteLine(retornarString());

        Console.ReadLine();
    }
}