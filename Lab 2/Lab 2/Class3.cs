using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Playlist

    {
        private string nombreplaylist;
        List<string> songs = new List<string>();
        

        
        public Playlist(string nombreplaylist, string cancionnombre, string cancionartista, string cancionalbum,string canciongenero)
        { this.nombreplaylist = nombreplaylist;
          }
        public string infoplaylist()
        {
            string infloplay = "Playlist;" + nombreplaylist + 
                "Canciones:"+
       return infloplay;    }
    }

}
