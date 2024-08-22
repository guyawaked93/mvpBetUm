using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvpBetUm
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Inserir valor da banca
            var dinheiroBanca = 0.0;

            Console.WriteLine("Digite o valor da sua banca: ");


            while (!double.TryParse(Console.ReadLine(), out dinheiroBanca))
            {
                Console.WriteLine("Insira apenas numeros!!!");

                Console.WriteLine("Digite o valor da sua banca: ");

            }

            // Console.WriteLine($"Sua Banca é de {dinheiroBanca}");

            Console.WriteLine("A recomendação da porcentagem total da sua banca e de 1 a 3%");
            Console.WriteLine("Digite a porcentagem: ex 1%");

            if (double.TryParse(Console.ReadLine(), out double porcentagem))
            {
                double resultado = dinheiroBanca * (porcentagem / 100);

                Console.WriteLine($"O seguro é voce apostar {resultado} da sua {dinheiroBanca}");
            }
            else
            {

                Console.WriteLine("Tente novamente");
            }



            #endregion


            #region  Exemplos que fiz antes
            //Console.WriteLine("insira o valor da sua banca :");
            //dinheiroBanca = Convert.ToInt32(Console.ReadLine()); // fiz o casting (conversão) do valor que o usuário digitou.


            //Console.WriteLine("Digite seu nome:");
            //var nome = Console.ReadLine();
            //Console.WriteLine($"Ola, {nome}");
            #endregion

        }
    }

}
