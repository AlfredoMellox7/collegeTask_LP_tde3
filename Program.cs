﻿// 1 - Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior
// Encontre o maior dentre 3 números:
// Primeiro Número : 65465
// Segundo Número : 64658
// Terceiro Número : 65464

// Console.WriteLine("------------------------");
// Console.WriteLine("Digite o primeiro número :");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite o segundo número :");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digite o terceiro número :");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("------------------------");

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"O primeiro valor: {num1} é o maior .");
//     Console.ReadKey();
// }
// else if(num2 > num1 && num2 > num3)
// {
//     Console.WriteLine($"O segundo valor : {num2} é o maior .");
//     Console.ReadKey();
// }
// else{
//     Console.WriteLine($"O terceiro número : {num3} é o maior .");
//     Console.ReadKey();
// }
// ---------------------------------------------------------------------------------------------------------

// 2- Escreva um programa para exibir os 10 primeiros números e calcular a sua soma usando o loop while ..
// int contador = 1;
// int soma = 0;
// Console.WriteLine(" ");
// Console.WriteLine("Os 10 primeiros números são : ");
// while(contador <= 10)
// {
//     Console.WriteLine(contador);                                                            // LOOP WHILE
//     soma+= contador;
//     contador++;
// }
// Console.WriteLine($"A soma dos 10 primeiros números é : {soma}.");
// Console.WriteLine(" ");
// --------------------------------------------------
// Escreva um programa para exibir os 10 primeiros números e calcular a sua soma usando o loop do-while.
// int contador = 1;
// int soma = 0;
// Console.WriteLine(" ");
// Console.WriteLine("Os 10 primeiros números são : ");
// do
// {
//     Console.WriteLine(contador); // 
//     soma+= contador;                                                                       // LOOP DO-WHILE
//     contador++;
// }
// while(contador <= 10);                        //Repetir até que o contador seja maior que 10

// Console.WriteLine($"A soma dos 10 primeiros números é : {soma}");
// Console.WriteLine(" ");
// --------------------------------------------------
//Escreva um programa para exibir os 10 primeiros números e calcular a sua soma usando o loop for.
// int soma = 0;
// Console.WriteLine(" ");
// Console.WriteLine("Os 10 primeiros números são : ");
// for ( int contador = 1; contador <= 10; contador++)
// {
//     Console.WriteLine(contador);     // Exibindo o número atual                            // LOOP FOR
//     soma += contador;                // Adicionando o número atual à soma
// }
// Console.WriteLine($"A soma dos 10 primeiros números é : {soma}");
// Console.WriteLine(" ");
// -------------------------------------------------------------------------------------------------------------

// 3- Escreva um programa para exibir a tabela de multiplicação de um número maior que zero recebido via teclado 
// - Verifique se o número é maior que zero e emita uma mensagem
// - Considere a tabela de multiplicação de 1 até 10
// - Após exibir a tabela torne a solicitar outro número
// - Para sair do loop defina uma condição de saída 
// Dica: Use os loop while e for e para sair a instrução break;

// while (true)
// {
//     Console.WriteLine(" ");
//     Console.WriteLine("Digite um número maior que zero(Ou digite zero para sair):");
//     int numero = Convert.ToInt32(Console.ReadLine());
//     if (numero <= 0)
//     {
//         Console.WriteLine("Número inválido, por favor insira um número de 1 a 10 .");
//         continue;    // Reinicia o processo .
//     }
//     Console.WriteLine("Tabela de multiplicação do número inserido : ");
//     for (int i = 1; i <= 10; i++)
//     {
//         Console.WriteLine($"{numero} x {i} = {numero * i} .");
//     }
//     Console.WriteLine(" ");
//     Console.WriteLine("Deseja continuar ? S/N .");
//     char resposta = Convert.ToChar(Console.ReadLine()!);
//     if (resposta != 'S')
//     {
//         Console.WriteLine(" ");
//         Console.WriteLine("Programa encerrado .");
//         break;
//     }
// }
// -------------------------------------------------------------------------------------------------------------
// 4- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:
// - Incrementando 2 em cada passo
// - Incrementando 1 em cada passo 
// - Com e loop infinito (use "break" e "continue")
// --------------------------------------------------
// Console.WriteLine(" ");
// Console.WriteLine("Exibindo números pares de 10 a 20 : (De 2 em 2 menos o número 16)");
// for (int i = 10; i <= 20; i += 2)
// {
//     if ( i == 16)
//     {
//         continue;
//     }
//     Console.WriteLine(i);
// }
// --------------------------------------------------
// Console.WriteLine(" ");
// Console.WriteLine("Exibindo números pares de 10 a 20 : (De 1 a 1 menos o número 16)");
// for (int i = 10; i <= 20; i++)
// {
//     if ( i % 2 == 0 && i != 16)
//         Console.WriteLine("i");
//     }
// }
// --------------------------------------------------
// Console.WriteLine(" ");
// Console.WriteLine("Exibindo números pares de 10 a 20 com loop infinito :");
// int numero = 10;
// while(true)
// {
//     if(numero > 20)
//     {
//         break;
//     }
//     if (numero == 16)
//     {
//         numero++;
//         continue;
//     }
//     if (numero % 2 == 0)
//     {
//         Console.WriteLine(numero);
//     }
//     numero++;
// }
// -------------------------------------------------------------------------------------------------------------
//
// 5 - Escreva um programa para calcular o fatorial de um número inteiro. 
// O fatorial de um número é representado por : n! => n * (n – 1) * (n – 2) ....2*1 
// Exemplo : fatorial de 6 é representado por 6! = 6*5*4*3*2*1
// Console.WriteLine(" ");
// Console.WriteLine("Digite um número inteiro positivo: ");       // Recolhendo dados do usuário
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0)
// {
//     Console.WriteLine("Insira um número inteiro positivo !");   // Mensagem caso o usuário insira um número negativo 
// }
// else
// {
//     long fatorial = CalcularFatorial(num);
//     Console.WriteLine($"O fatorial de {num} é {fatorial} .");   //Mensagem do output para o usuário 
// }

// static long CalcularFatorial(int num)
// {
//     if (num < 0)
//     {
//         throw new ArgumentException("O fatorial de um número negativo não está definido.");  // Mensagem caso o usuário insira um número negativo
//     }
//     else if (num == 0 || num == 1)
//     {
//         return 1;
//     }
//     else
//     {
//         long resultado = 1;
//         for (int i = 2; i <= num; i++)
//         {
//             resultado *= i;
//         }
//         return resultado;
//     }
// }
// -------------------------------------------------------------------------------------------------------------
// Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado
//
// int multiplicador = 2;

// do
// {
//     Console.WriteLine($"Tabela de multiplicação do {multiplicador} .");
//     int multiplicando = 1;
//     do
//     {
//         int resultado = multiplicador * multiplicando;
//         Console.WriteLine($"{multiplicador} * {multiplicando} = {resultado} .");
//         multiplicando++;
//     } while (multiplicando <= 10);
//     Console.WriteLine();
//     multiplicador++;
// } while (multiplicador <= 6);
// -------------------------------------------------------------------------------------------------------------
//Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de 
// um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a 
// instrução switch, break e default em um loop infinito e defina uma condição de saida.)
//
// while (true)
// {
//     Console.WriteLine(" ");
//     Console.WriteLine("Digite a nota do aluno : ( Lembrando ser de 0 a 10): ");
//     int nota;
//     while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
//     {
//         Console.WriteLine("Insira um número inteiro de 0 a 10 !");
//     }
//     switch (nota)
//     {
//         case 0:
//         case 1:
//         case 2:
//         case 3:
//         case 4:
//             Console.WriteLine("F, está reprovado .");
//             break;
//         case 5:
//             Console.WriteLine("E, está reprovado .");
//             break;
//         case 6:
//             Console.WriteLine("C, Nota mínima atingida, aprovado.");
//             break;
//         case 7:
//         case 8:
//             Console.WriteLine("B, Nota mínima atingida, aprovado.");
//             break;                
//         case 9:
//             Console.WriteLine("A, está aprovado.");
//             break;
//         case 10:
//             Console.WriteLine("A+, Excelente desempenho, está aprovado !");
//             break;
//         default:
//             Console.WriteLine("Nota inválida.");
//             break;
//     }
//     Console.WriteLine("Deseja fazer outra avaliação ?");
//     string resposta = Console.ReadLine()!;

//     if (resposta.ToLower() != "s")
//     break;
// }
// -------------------------------------------------------------------------------------------------------------
//  {
// while (true)
// {
//     Console.WriteLine("Escolha a operação:");
//     Console.WriteLine("1 - Adição");
//     Console.WriteLine("2 - Subtração");
//     Console.WriteLine("3 - Multiplicação");
//     Console.WriteLine("4 - Divisão");
//     Console.WriteLine("5 - Sair");

//     int opcao;
//     while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
//     {
//         Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
//     }

//     switch (opcao)
//     {
//         case 1:
//             RealizarAdicao();
//             break;
//         case 2:
//             RealizarSubtracao();
//             break;
//         case 3:
//             RealizarMultiplicacao();
//             break;
//         case 4:
//             RealizarDivisao();
//             break;
//         case 5:
//             Console.WriteLine("Saindo do programa...");
//             return;
//     }

//     static void RealizarAdicao()
//     {
//         Console.WriteLine("Digite o primeiro número:");
//         int num1 = int.Parse(Console.ReadLine()!);

//         Console.WriteLine("Digite o segundo número:");
//         int num2 = int.Parse(Console.ReadLine()!);

//         int resultado = num1 + num2;
//         Console.WriteLine($"O resultado da adição é: {resultado}");
//     }

//     static void RealizarSubtracao()
//     {
//         Console.WriteLine("Digite o primeiro número:");
//         int num1 = int.Parse(Console.ReadLine()!);

//         Console.WriteLine("Digite o segundo número:");
//         int num2 = int.Parse(Console.ReadLine()!);

//         int resultado = num1 - num2;
//         Console.WriteLine($"O resultado da subtração é: {resultado}");
//     }

//     static void RealizarMultiplicacao()
//     {
//         Console.WriteLine("Digite o primeiro número:");
//         int num1 = int.Parse(Console.ReadLine()!);

//         Console.WriteLine("Digite o segundo número:");
//         int num2 = int.Parse(Console.ReadLine()!);

//         int resultado = num1 * num2;
//         Console.WriteLine($"O resultado da multiplicação é: {resultado}");
//     }

//     static void RealizarDivisao()
//     {
//         Console.WriteLine("Digite o dividendo:");
//         int dividendo = int.Parse(Console.ReadLine()!);

//         Console.WriteLine("Digite o divisor:");
//         int divisor;
//         while (!int.TryParse(Console.ReadLine(), out divisor) || divisor == 0)
//         {
//             Console.WriteLine("O divisor deve ser diferente de zero. Por favor, digite novamente.");
//         }

//         double resultado = (double)dividendo / divisor;
//         Console.WriteLine($"O resultado da divisão é: {resultado}");
//     }
// }