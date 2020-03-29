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
            choice = Convert.ToInt32(Console.ReadKey());
            while (choice != 3) 
            {if (choice==1)
                {
                    string muestra;
                    Espotifai muestralista = new Espotifai();
                    muestra = muestralista.VerCanciones();
                        }
             else if (choice==2)
                { 
                    string nam;
                    string alb;
                    string ar;
                    string gen;
                   Console.WriteLine("Escriba el nombre de la cancion");
                    nam = Console.ReadLine();
                    Console.WriteLine("Escriba el album de la cancion");
                    alb = Console.ReadLine();
                    Console.WriteLine("Escriba el nombre del artista");
                    ar = Console.ReadLine();
                    Console.WriteLine("Escriba el genero de la cancion");
                    gen=Console.ReadLine()


                }
             
            }
            Console.WriteLine("Gracias por usar el programa");

        }
    }
}
