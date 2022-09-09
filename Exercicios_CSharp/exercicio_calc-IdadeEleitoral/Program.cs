//Faça um programa que leia o ano de nascimento de uma pessoa, calcule sua idade e depois 
//mostre se ela já pode ou não votar.
namespace exercicio_calcIdadeEleitoral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anoNasc, anoAtual, idade, anosFaltantes;

            Console.Write("Escreva o seu ano de nascimento: ");
            anoNasc = int.Parse(Console.ReadLine());

            Console.Write("Informe o ano atual: ");
            anoAtual = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNasc;
            Console.WriteLine($"Você tem {idade} anos.");

            if (idade < 16)
            {
                Console.WriteLine("Você ainda não pode votar.");
                anosFaltantes = 18 - idade;
                Console.WriteLine($"\nFaltam {anosFaltantes} anos para o seu voto se tornar obrigatório.");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine("Você já pode votar, mas é opcional.");
                anosFaltantes = 18 - idade;
                Console.WriteLine($"\nFaltam {anosFaltantes} anos para o seu voto se tornar obrigatório.");
            }
            else
            {
                Console.WriteLine("Você pode e DEVE votar.");
                anosFaltantes = idade - 18;
                Console.WriteLine($"\nVocê deveria votar a {anosFaltantes} anos.");
            }
        }
    }
}

