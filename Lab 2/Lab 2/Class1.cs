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
        public Canción(string Namesong, string Albumsong, string Artistsong, string Genresong)
        {
            Name = Namesong;
            Album = Albumsong;
            Artist = Artistsong;
            Genre = Genresong;
        }
        public string Informacion(string Namesong, string Albumsong,string Artistsong,string Genresong)
        {
            string info = "genero:" + Genresong + ", artista:" + Artistsong + ", album:" + Albumsong + ", nombre:" + Namesong;
            return info;
          }
         


    }
}
