//Faça um algoritmo que leia a largura e altura de uma parede, calcule e 
//mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
//sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
namespace exercicio_CalcTinta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, largura, tinta, area;

            Console.Write("Digite o valor da altura: ");
            altura = Double.Parse(Console.ReadLine());

            Console.Write("Agora, digite o valor da largura: ");
            largura = Double.Parse(Console.ReadLine());

            area = altura * largura;
            tinta = area / 2;

            Console.WriteLine($"\nA sua área total é de {area} metros");
            Console.WriteLine($"Você precisará de {tinta} litros");
        }
    }
}
