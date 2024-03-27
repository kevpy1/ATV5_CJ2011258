using System.ComponentModel;
using System.Drawing;

namespace ATV5_CJ2011258
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite 0 para exercicio 0 ");
            Console.WriteLine("digite 1 para exercicio 1 ");
            Console.WriteLine("digite 2 para exercicio 2 ");
            Console.WriteLine("digite 3 para exercicio 3 ");
            Console.WriteLine("digite 4 para exercicio 4 ");
            Console.WriteLine("digite 5 para exercicio 5 ");
            Console.WriteLine("digite 6 para exercicio 6 ");
            Console.WriteLine("digite 7 para exercicio 7 ");

            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {


                case 0:

                    int a, temp;
                    int soma = 0;

                    for (a = 0; a < 8; a++)
                    {

                        Console.WriteLine("digite um valor ");
                        temp = int.Parse(Console.ReadLine());
                        if (temp < 0)
                            break;
                        soma = soma + temp;

                        Console.WriteLine(" A media é {0}, soma", soma / 3);
                    }
                    break;



                case 1:
                    Console.WriteLine("Digite um número inteiro: ");
                    int numero = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= numero; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;



                case 2:
                    Console.WriteLine("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1 até " + num + ":");

                    for (int i = 2; i <= num; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    break;



                case 3:
                    Console.WriteLine("Digite um número inteiro menor que 1000: ");
                    int nu = int.Parse(Console.ReadLine());

                    Console.WriteLine("Números pares de 1000 até " + nu + ":");

                    for (int i = 1000; i <= nu; i += 2)
                    {
                        Console.WriteLine(i);
                    }
                    break;

                case 4:
                    Console.WriteLine()
            
            }
        }
    }
}

























