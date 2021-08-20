using Biblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsodeBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione elemento a crear: ");
            Console.WriteLine("1. List: ");
            Console.WriteLine("2. SortedList: ");
            var response = Console.ReadLine();

            if( response == "1")
            {
                CollectionExample.ListCollection();
                Console.ReadKey();
            }
            else
            {
                CollectionExample.SortedListCollection();
            }
            
            CollectionExample.SortedListCollection();
            Console.ReadKey();

            CollectionExample.ListCollection();
        }
    }
}
