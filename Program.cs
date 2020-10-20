using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo15
{
    class Program
    {
        static void Main(string[] args)
        {
            // saisie d'une phrase 
            Console.WriteLine("Entrez une phrase : ");
            string phrase = Console.ReadLine();

            // replacement des espace apr underscore
            string newpharse = phrase.Replace(' ','_');

            //affichage de la nouvelle phrase
            Console.WriteLine(newpharse);
            Console.ReadLine();
        }
    }
}
