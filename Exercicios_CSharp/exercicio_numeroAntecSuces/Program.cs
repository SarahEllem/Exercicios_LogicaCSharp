//Faça um programa que leia um número inteiro e mostre o seu antecessor e seu 
//sucessor.

namespace exercicio_numeroAntecSuces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, numAntecessor, numSucessor;

            Console.WriteLine("Digite um número para saber seu antecessor e sucessor: ");
            num = int.Parse(Console.ReadLine());

            numAntecessor = num - 1;
            numSucessor = num + 1;

            Console.WriteLine($"O antecessor do seu número ({num}) é {numAntecessor} e o sucessor é {numSucessor}");
        }
    }
}
