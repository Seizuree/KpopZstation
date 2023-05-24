using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class ArtistController
    {
        ArtistHandler handler = new ArtistHandler();

        public Artist GetArtistByArtistID(int id)
        {
            return handler.GetArtistByArtistID(id);
        }
    }
}