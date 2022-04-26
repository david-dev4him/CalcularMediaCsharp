using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleModularizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ResultadoAcademico();
            Console.ReadKey();

        }
        static void ResultadoAcademico()
        {
            float n1, n2, m;
            Console.WriteLine("RESULTADO ACADÊMICO");
            MensagemLeitura(1);
            n1 = float.Parse(Console.ReadLine());
            MensagemLeitura(2);
            n2 = float.Parse(Console.ReadLine());
            m = CalculaMedia(n1, n2);
            Console.WriteLine("A media é: " + m);
            ApresentaResultado(m);
        }

        static void ApresentaResultado(float media) //recebe a média como parâmetro para chegar no resultado//
        {
            if (media >= 7)
                Console.WriteLine("Aprovado");
            else if (media >= 4)
            {
                Console.WriteLine("Exame Final");
                if (LeExame(media) >= 5)
                    Console.WriteLine("Aprovado");
                else
                    Console.WriteLine("Reprovado");
            }


            else
                Console.WriteLine("Reprovado");
        }

        static float LeExame (float media)
        {
            float ne, nf;
            Console.WriteLine("Informe a nota do exame: ");
            ne = float.Parse(Console.ReadLine());
            nf = (media + ne) / 2;
            return nf;
        }
        
        static float CalculaMedia(float nota1, float nota2)
        {
            float media;
            media = (nota1 + nota2) / 2;
            return media; //utiliza no método "ApresentaResultado"//
        }
        
        static void MensagemLeitura(int n)
        {
            Console.WriteLine("Digite um valor para ser atribuído à " + n + "ª nota: ");
        }
    }
}
