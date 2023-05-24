using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class ArtistRepository
    {
        KpopzstationDatabaseEntities db = DatabaseSingleton.getInstance();

        public Artist GetArtistByID(int id)
        {
            return (from ar in db.Artists where ar.ArtistID == id select ar).FirstOrDefault();
        }
    }
}