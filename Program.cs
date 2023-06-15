using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasERepeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes = new List<string>();



            nomes.Add(" Jonatas ");
            nomes.Add(" Gaby ");
            nomes.Add(" Manu ");
            
            Console.WriteLine($" O primeiro nome é {nomes[0]}");
            Console.WriteLine($" O segundo nome é {nomes[1]}");
            Console.WriteLine($" O terceiro nome é {nomes[2]}");

            Console.WriteLine(" Digite seu nome:");
            nomes.Add("Console.ReadLine() ");


            nomes.RemoveAt(2);


            int quantidade = nomes.Count;
            Console.WriteLine($" Existem {quantidade} usuários cadastrados!");


            Console.ReadKey();



















        
        }
        void Arrays()
        {
            string[] nomes = new string[3];

            nomes[0] = " Kennedy";
            nomes[1] = "Jonatas";
            nomes[2] = "Ana";
            

            Console.WriteLine($" O nome da primeira posição é { nomes[0]}");
            Console.WriteLine($" O nome da segunda posição é { nomes[1]}");
            Console.WriteLine($" O nome da terceira posição é { nomes[2]}");

          

            
            



            Console.ReadKey();

        }
    }    
        





    } 





