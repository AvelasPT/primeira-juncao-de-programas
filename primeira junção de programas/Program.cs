using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeira_junção_de_programas
{
    class Program
    {
        static void Main(string[] args)
        {
            int selecao;
            Console.WriteLine("Este programa consiste de outros 4");
            Console.WriteLine("1-C01");
            Console.WriteLine("2-C02");
            Console.WriteLine("3-C03");
            Console.WriteLine("4-C04");
            selecao = int.Parse(Console.ReadLine());

            switch(selecao)
            {
                case 1:
                    int n;

                    Console.Write("Introduza o número que quiser para calcular o seu número triangular: ");
                    n = int.Parse(Console.ReadLine());

                    n = (n * (n + 1)) / 2;

                    Console.WriteLine("o número triangular do número introduzido é: " + n + ".");

                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                case 2:
                    int n1, n2, n3;
                    double media, soma;

                    Console.Write("Introduza o 1º nº: ");
                    n1 = int.Parse(Console.ReadLine());

                    Console.Write("Introduza o 2º nº: ");
                    n2 = int.Parse(Console.ReadLine());

                    Console.Write("Introduza o 3º nº: ");
                    n3 = int.Parse(Console.ReadLine());

                    soma = n1 + n2 + n3;
                    media = soma / 3;

                    if (n1 > n2 && n2 > n3)
                    {
                        Console.WriteLine("O maior número é o " + n1 + " e o menor é " + n3 + ".");
                    }
                    else if (n1 > n3 && n3 > n2)
                    {
                        Console.WriteLine("O maior número é o " + n1 + " e o menor é " + n2 + ".");
                    }
                    else if (n2 > n1 && n1 > n3)
                    {
                        Console.WriteLine("O maior número é o " + n2 + " e o menor é " + n3 + ".");
                    }
                    else if (n2 > n3 && n3 > n1)
                    {
                        Console.WriteLine("O maior número é o " + n2 + " e o menor é " + n1 + ".");
                    }
                    else if (n3 > n1 && n1 > n2)
                    {
                        Console.WriteLine("O maior número é o " + n3 + " e o menor é " + n2 + ".");
                    }
                    else
                    {
                        Console.WriteLine("O maior número é o " + n3 + " e o menor é " + n1 + ".");
                    }
                    Console.WriteLine("A soma entre os três números dá " + soma + " e a media deles dá " + media + ".");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                case 3:
                    double divisao, multiplicacao, nn1, nn2;

                    Console.Write("Introduza o primeiro nº: ");
                    nn1 = double.Parse(Console.ReadLine());

                    Console.Write("Introduza o segundo nº: ");
                    nn2 = double.Parse(Console.ReadLine());

                    if (nn1 >= nn2)
                    {
                        divisao = nn1 / nn2;
                        Console.WriteLine("Como o 1º número é maior que o 2º, o programa fez a divisão e o resultado dá " + divisao + ".");
                    }
                    else
                    {
                        multiplicacao = nn1 * nn2;
                        Console.WriteLine("Como o 2º número é maior que o 1º, o programa fez a multiplicação e o resultado dá " + multiplicacao + ".");
                    }

                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                case 4:
                    int idade1, idade2, idade3, idade4, idade5, c1, c2, c3, c4;

                    Console.Write("Introduza a idade da primeira pessoa: ");
                    idade1 = int.Parse(Console.ReadLine());

                    Console.Write("Introduza a idade da segunda pessoa: ");
                    idade2 = int.Parse(Console.ReadLine());

                    Console.Write("Introduza a idade da terceira pessoa: ");
                    idade3 = int.Parse(Console.ReadLine());

                    Console.Write("Introduza a idade da quarta pessoa: ");
                    idade4 = int.Parse(Console.ReadLine());

                    Console.Write("Introduza a idade da quinta pessoa: ");
                    idade5 = int.Parse(Console.ReadLine());

                    c1 = 0;
                    c2 = 0;
                    c3 = 0;
                    c4 = 0;

                    switch (idade1)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            c1 = c1 + 1;
                            break;

                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            c2 = c2 + 1;
                            break;

                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                            c3 = c3 + 1;
                            break;

                        default:
                            if (idade1 < 1)
                            {
                                Console.WriteLine("Um dos números é menor que 1.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                c4 = c4 + 1;
                            }
                            break;
                    }

                    switch (idade2)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            c1 = c1 + 1;
                            break;

                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            c2 = c2 + 1;
                            break;

                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                            c3 = c3 + 1;
                            break;

                        default:
                            if (idade2 < 1)
                            {
                                Console.WriteLine("Um dos números é menor que 1.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                c4 = c4 + 1;
                            }
                            break;
                    }
                    switch (idade3)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            c1 = c1 + 1;
                            break;

                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            c2 = c2 + 1;
                            break;

                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                            c3 = c3 + 1;
                            break;

                        default:
                            if (idade3 < 1)
                            {
                                Console.WriteLine("Um dos números é menor que 1.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                c4 = c4 + 1;
                            }
                            break;
                    }
                    switch (idade4)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            c1 = c1 + 1;
                            break;

                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            c2 = c2 + 1;
                            break;

                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                            c3 = c3 + 1;
                            break;

                        default:
                            if (idade4 < 1)
                            {
                                Console.WriteLine("Um dos números é menor que 1.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                c4 = c4 + 1;
                            }
                            break;
                    }
                    switch (idade5)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                            c1 = c1 + 1;
                            break;

                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            c2 = c2 + 1;
                            break;

                        case 21:
                        case 22:
                        case 23:
                        case 24:
                        case 25:
                        case 26:
                        case 27:
                        case 28:
                        case 29:
                        case 30:
                            c3 = c3 + 1;
                            break;

                        default:
                            if (idade5 < 1)
                            {
                                Console.WriteLine("Um dos números é menor que 1.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            else
                            {
                                c4 = c4 + 1;
                            }
                            break;
                    }
                    Console.WriteLine("");
                    Console.WriteLine("A quantidade de pessoas que têm 1 a 10 anos de idade é de: " + c1);
                    Console.WriteLine("A quantidade de pessoas que têm 11 a 20 anos de idade é de: " + c2);
                    Console.WriteLine("A quantidade de pessoas que têm 21 a 30 anos de idade é de: " + c3);
                    Console.WriteLine("A quantidade de pessoas que têm mais de 30 anos é de: " + c4);

                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
        }
    }
}