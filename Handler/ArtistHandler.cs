using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class ArtistHandler
    {
        ArtistRepository ArtistRepo = new ArtistRepository();
        public Artist GetArtistByArtistID(int id)
        {
            return ArtistRepo.GetArtistByID(id);
        }
    }
}