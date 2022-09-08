//Escreva um programa para calcular a redução do tempo de vida de um fumante.
//Pergunte a quantidade de cigarros fumados por dias e quantos anos ele já fumou.
//Considere que um fumante perde 10 min de vida a cada cigarro.
//Calcule quantos dias de vida um fumante perderá e exiba o total em dias.

namespace exercicio_TempoDeVida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cigarrDia, anosFumando; //Entrada de dados
            int anosTotal, minPerdd, diasPerdd;

            Console.Write("Olá, qual é a quantidade de cigarros que você fuma por dia? ");
            cigarrDia = int.Parse(Console.ReadLine());

            Console.Write("Há quantos anos você fuma? ");
            anosFumando = int.Parse(Console.ReadLine());

            //anos fumados => transformando anos em dias
            anosTotal = anosFumando * 365;

            //minutos perdidos => calculando os minutos perdidos
            minPerdd = (cigarrDia * anosTotal) * 10;

            //dias perdidos => transformando os minutos perdidos em dias
            diasPerdd = minPerdd / 1440;

            Console.WriteLine($"\nVocê perdeu {diasPerdd} dias de vida.\n");
        }
    }
}