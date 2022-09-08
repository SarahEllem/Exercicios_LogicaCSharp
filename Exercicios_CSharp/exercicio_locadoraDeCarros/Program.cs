//A locadora de carros precisa da sua ajuda para cobrar seus serviços.  
//Escreva um programa que pergunte a quantidade de Km percorridos por um carro alugado 
//e a quantidade de dias pelos quais ele foi alugado. Calcule o preço total a pagar,
//sabendo que o carro custa R$90 por dia e R$0,20 por Km rodado.

namespace exercicio_locadoraDeCarros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmRodds, kmPreco = 0.20, kmTotal, precoTotal;
            int diaAlug, diaPreco = 90, diaTotal;

            Console.Write("Digite a quantidade de KM rodados: ");
            kmRodds = Double.Parse(Console.ReadLine());

            Console.Write("Agora, digite o número de dias que o carro ficou alugado: ");
            diaAlug = int.Parse(Console.ReadLine());

            kmTotal = kmRodds * kmPreco;
            diaTotal = diaAlug * diaPreco;

            precoTotal = kmTotal + diaTotal;

            Console.Write($"\nValor do KM rodado: R${kmTotal}   |   Valor dos dias alugados: R${diaTotal}\n");
            Console.WriteLine($"O valor total a ser pago é de R${precoTotal}\n");
        }
    }
}
