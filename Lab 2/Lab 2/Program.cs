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
            
            int choice;
            Console.WriteLine("Bienvenido a Espotifai,por favor elija la acción que deseé realizar:");
            Console.WriteLine("1:Ver las canciones,");
            Console.WriteLine("2:Agregar canción"); 
            Console.WriteLine("3:Salir del menu");
            Console.WriteLine("4:ver canciones por criterio");
            Console.WriteLine("5:Crear playlists");
            Console.WriteLine("6:Ver playlists");
            choice = Convert.ToInt32(Console.ReadKey());
            
            {if (choice == 1)
                {

                    Espotifai muestralista = new Espotifai();
                    muestralista.VerCanciones();
                }
                else if (choice == 2)
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
                    gen = Console.ReadLine();
                    List<string> reco = new List<string>();
                    reco.Add(nam);
                    reco.Add(alb);
                    reco.Add(ar);
                    reco.Add(gen);
                    foreach(string element in reco)
                    { Espotifai cl = new Espotifai();
                        cl.AgregarCancion(element);
                    }




                }
                else if (choice == 3) 
                { Console.WriteLine("Gracias por usar el programa"); }
                else if (choice == 4)
                { Console.WriteLine("Escriba el criterio");
                    string crit;
                    crit = Console.ReadLine();
                    Console.WriteLine("Ahora escriba el valor");
                    string valo;
                    valo = Console.ReadLine();
                    Espotifai nuevalista = new Espotifai();
                    nuevalista.CancionesPorCriterio(crit, valo);
                }
                else if(choice==5)
                { Console.WriteLine("Inserte el nombre para la playlist:");
                    string playlili;
                    playlili = Console.ReadLine();

                }
                else if(choice==6)
                { }


            }
            


        }
    }
}
