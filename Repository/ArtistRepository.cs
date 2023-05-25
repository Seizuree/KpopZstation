using KpopZstation.Factory;
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

        public List<Artist> GetArtistsByArtistID(int id)
        {
            return (from al in db.Artists where al.ArtistID == id select al).ToList();
        }

        public List<Artist> GetArtists()
        {
            return (from al in db.Artists select al).ToList();
        }

        public Artist InsertArtist(String artistName, String artistImage)
        {
            Artist insert = ArtistFactory.addArtist(artistName, artistImage);
            db.Artists.Add(insert);
            db.SaveChanges();
            return insert;
        }

        public Artist UpdateArtist(int artistID, String artistName, String artistImage)
        {
            Artist update = db.Artists.Find(artistID);
            update.ArtistName = artistName;
            update.ArtistImage = artistImage;
            db.SaveChanges();
            return update;
        }

        public Artist DeleteArtist(String artistID)
        {
            Artist delete = db.Artists.Find(int.Parse(artistID));
            db.Artists.Remove(delete);
            db.SaveChanges();
            return delete;
        }

        public Artist GetArtistByID(int id)
        {
            return (from ar in db.Artists where ar.ArtistID == id select ar).FirstOrDefault();
        }
    }
}