using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestoesAbertasVA2.cs
{
    internal class Program
    {
        public static void Main(string[] args) 
        {



            int opcao;

            Console.WriteLine("Atividade -1 ");
            Console.WriteLine("Atividade - 2");
            Console.WriteLine("Atividade - 3");
            Console.WriteLine("Escolha uma opcao");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Questoes atividae1 = new Questoes();
                    atividae1.Questao10();
                    break;
                case 2:
                    Questoes atividae2 = new Questoes();
                    atividae2.Questao11();
                    break;
                case 3:
                    Questoes atividae3 = new Questoes();
                    atividae3.Questao12();
                    break;


            }









        }


    }
}
