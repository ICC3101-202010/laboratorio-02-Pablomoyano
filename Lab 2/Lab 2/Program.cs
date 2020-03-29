using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listamusical = new List<string>();
            int choice;
            Console.WriteLine("Bienvenido a Espotifai,por favor elija la acción que deseé realizar:");
            Console.WriteLine("1:Ver las canciones,");
            Console.WriteLine("2:Agregar canción"); 
            Console.WriteLine("3:Salir del menu");
            choice = Convert.ToInt32(Console.ReadLine());
            while (choice != 3) 
            {if (choice==1)
                {foreach (string element in listamusical)
                        }
             else if (choice==2)
                { }
             
            }
            Console.WriteLine("Gracias por usar el programa");

        }
    }
}
