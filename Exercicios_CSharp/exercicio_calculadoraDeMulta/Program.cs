//Escreva um programa que pergunte a velocidade de um carro. 
//Caso ultrapasse 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. 
//Nesse caso, exiba o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.

namespace exercicio_calculadoraDeMulta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidadeCarro, multa, diferencaKm;

            Console.Write("Digita a velocidade do carro: ");
            velocidadeCarro = Double.Parse(Console.ReadLine());

            if (velocidadeCarro > 80)
            {
                Console.WriteLine($"{velocidadeCarro}Km/h está acima do limite permitido. Você será multado.");

                diferencaKm = velocidadeCarro - 80;
                multa = diferencaKm * 5;

                Console.WriteLine($"Sua multa é de R${multa}");
            }
            else
            {
                Console.WriteLine($"Sua velocidade de {velocidadeCarro} está dentro da velocidade permitida.");
            }
        }
    }
}
