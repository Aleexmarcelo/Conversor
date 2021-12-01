using System;
using System.Globalization;
namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {       
            //Pedindo informações sobre o valor do dólar
            Console.WriteLine("Quanto está o dólar hoje?");
            //Lendo o que foi digitado e salvo em variável
            double DolarAtual = double.Parse(Console.ReadLine());
            //Pedindo a quantidade em dólares
            Console.WriteLine("\nQuantidade de dólar a ser comprado?");
            //Lendo o que foi digitado e salvo em variável
            double QntDolar = double.Parse(Console.ReadLine());
            //Instancia um conversor com as variáveis
            Conversor conversor = new Conversor(DolarAtual, QntDolar);
            //Executando os métodos sem taxa e com taxa
            conversor.Conversao();
            conversor.ConversaoTaxa();
            //Escrevendo todos os dados coletados
            Console.WriteLine(conversor.ToString());
        }
    }
}

//Link da página onde foi cotado o valor do dólar(R$5,56 com IOF de 2,89% ):https://g1.globo.com/economia/noticia/2021/11/24/dolar.ghtml
