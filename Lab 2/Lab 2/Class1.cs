using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Canción
    {
        private string Name;
        private string Album;
        private string Artist;
        private string Genre;
        public Canción(string Name, string Album, string Artist, string Genre)
        {
            this.Name = Name;
            this.Album = Album;
            this.Artist = Artist;
            this.Genre = Genre;
        }
        public string Informacion()
        {
            string informa="genero:" + Genre + " ,artista:" + Artist + " ,album:" + Album + " ,nombre:" + Name;
            return informa;
          }
         


    }
}
