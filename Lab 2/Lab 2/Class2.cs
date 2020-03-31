using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Espotifai
    { private string nameplayli;
        public Espotifai()
        { }
         List<string> listamusical = new List<string>() ;
        public bool AgregarCancion(Canción cancion)
        {
            
            if (listamusical.Contains(cancion))
            { 
                return false;
            }
            else
            {
                listamusical.Add(cancion);
                return true; }
                
                }
        public void VerCanciones()
        {
            
            int i = 0;
            int sizelist = listamusical.Count();
            while (i != sizelist+1);
            Canción ver = new Canción(listamusical[i],listamusical[i+1],listamusical[i+2],listamusical[i+3]);
            Console.WriteLine(ver.Informacion());
            i = i + 4;

        }
        public List<Canción> CancionesPorCriterio(String criterio, String valor)
        {
            List<string> recopilacion = new List<string>();
            List<string> vacio = new List<string>();

            if (criterio == "nombre")
                foreach (string letras in listamusical)
                {
                    if (letras == valor)
                        recopilacion.Add(letras);
                }

            else if (criterio == "album")
            { int r;
                r = 1;
                int tama = listamusical.Count();
                while (r <=tama)
                { if (listamusical[r] == valor)
                        recopilacion.Add(listamusical[r - 1];
                    r = r + 4; } }
            else if (criterio == "artista")
            { int t = 2;
                int siz = listamusical.Count();
                while (t <= siz )
                { if (listamusical[t] == valor)
                        recopilacion.Add(listamusical[t - 2]);
                    t = t + 4;
                }
            }
            else if (criterio == "genero")
            {
                int h = 3;
                int size = listamusical.Count();
                while (h <= size )
                {
                    if (listamusical[h] == valor)
                        recopilacion.Add(listamusical[h - 3]);
                    h = h + 4;
                }
                

            }
            int finalsize = recopilacion.Count;
            if (finalsize == 0)

            {
                Console.WriteLine("Ninguna cancion cumple con lo solicitado,porfavor de un nuevo criterio");
                return vacio;
            }
            return recopilacion;
        }
        public bool GenerarPlaylist(String criterio, String valorCriterio, String nombrePlaylist)
        { if (}
        public String VerMisPlaylists()
        { }
    }
}
