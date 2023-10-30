using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._2_exercice_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Saisie des 3 nombres * esssai refus
         
            Console.WriteLine("Veuillez saisir le nombre 1 : ");
            double nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre 2 : ");
            double nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre 3 : ");
            double nb3 = double.Parse(Console.ReadLine());

            // Affichage du plus petit des trois
            Console.WriteLine("Le plus petit nombre saisie est : " + Math.Min(nb1, Math.Min(nb2, nb3)) + ".");
            Console.ReadLine();
        }
    }
}
