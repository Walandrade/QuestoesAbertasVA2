using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestoesAbertasVA2.cs
{
    internal class Questoes
    {


        public void Questao10() 
         {


            Console.WriteLine("digite a 1° nota(de 1 a 10):");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a 2° nota(de 1 a 10):");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a 3° nota(de 1 a 10):");
            int nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a 4° nota(de 1 a 10):");
            int nota4 = int.Parse(Console.ReadLine());
            int media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 6)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
        }

        public void Questao11()
        {

            
            int escolha = 0;
            int horas = 0;
            int valor = 0;
            Console.WriteLine("calculo de salário");
            Console.WriteLine("qaul o nível de profissão?");
            Console.WriteLine("1. nível 1");
            Console.WriteLine("2. nível 2");
            Console.WriteLine("3. nível 3");
            escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("informe quantas horas foram trabalhadas");
                    horas = int.Parse(Console.ReadLine());
                    valor = horas * 12;
                    Console.WriteLine($"foram trabalhadas {horas}horase e recebeu{valor}*reais.");


                    break;
                case 2:

                    Console.WriteLine("informe quantas horas foram trabalhadas");
                    horas = int.Parse(Console.ReadLine());
                    valor = horas * 17;
                    Console.WriteLine($"foram trabalhadas {horas}horase e recebeu{valor}*reais.");


                    break;
                case 3:

                    Console.WriteLine("informe quantas horas foram trabalhadas");
                    horas = int.Parse(Console.ReadLine());
                    valor = horas * 25;
                    Console.WriteLine($"foram trabalhadas{horas}horas e recebeu{valor}*reais.");

                    break;
                Default:

                    Console.WriteLine("opcao invalida, digite novamente:");

            }
            Console.ReadLine();


        }

        public void Questao12() 
        {

            //12
            double total;
            int qtd;
            int codProduto;

            double valor100 = 1.10, valor101 = 1.30, valor102 = 1.50, valor103 = 1.10, valor104 = 1.30, valor105 = 1.00;

            Console.WriteLine("CARDAPIO");
            Console.WriteLine("100|cachorro quente R$1,10");
            Console.WriteLine("101|Bauru simples R$1,30");
            Console.WriteLine("102|Bauru com ovo R$1,50");
            Console.WriteLine("103|Hamburgue R$1,10");
            Console.WriteLine("104|Cheeseburgue R$1,30");
            Console.WriteLine("105|Refrigerante R$1,10");

            codProduto = int.Parse(Console.ReadLine());
            switch (codProduto)
            {
                case 100:
                    Console.WriteLine("informe a quantidade:");
                    qtd = int.Parse(Console.ReadLine());
                    total = valor100 + qtd;
                    Console.WriteLine($"100|cachorro quente|valor total{total}");
                    break;

                case 101:
                    Console.WriteLine("informe a quantidade:");
                    qtd = int.Parse(Console.ReadLine());
                    total = valor101 * qtd;
                    Console.WriteLine($"101|bauru simplis|valor total{total}");
                    break;

                case 102:
                    Console.WriteLine("informe a quantidade:");
                    qtd = int.Parse(Console.ReadLine());
                    total = valor102 * qtd;
                    Console.WriteLine($"102|Bauru com ovo|valor total{total}");
                    break;

                case 103:
                    Console.WriteLine("informe a quantidade:");
                    qtd = int.Parse(Console.ReadLine());
                    total = valor103 * qtd;
                    Console.WriteLine($"103|Hamburguer|valor total{total}");
                    break;

                case 104:
                    Console.WriteLine("informe a quantidade:");
                    qtd = int.Parse(Console.ReadLine());
                    total = valor104 * qtd;
                    Console.WriteLine($"104|Cheeseburguer|valor total{total}");
                    break;

                case 105:
                    Console.WriteLine("informe a quantidade:");
                    qtd = int.Parse(Console.ReadLine());
                    total = valor105 * qtd;
                    Console.WriteLine($"105|Refrigerante|valor total{total}");
                    break;

                defalt:
                    Console.WriteLine("Opcao invalida:");
            }



        }

    }
}
