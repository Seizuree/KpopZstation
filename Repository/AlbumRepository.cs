using KpopZstation.Factory;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class AlbumRepository
    {
        KpopzstationDatabaseEntities db = DatabaseSingleton.getInstance();

        public List<Album> GetByID(int id)
        {
            return (from al in db.Albums where al.ArtistID == id select al).ToList();
        }

        public Album InsertAlbum(int artistID, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescription)
        {
            Album insert = AlbumFactory.addAlbum(artistID, albumName, albumImage, albumPrice, albumStock, albumDescription);
            db.Albums.Add(insert);
            db.SaveChanges();
            return insert;
        }

        public Album UpdateAlbum(String albumID, String albumName, String albumImage, int albumPrice, int albumStock, String albumDescription)
        {
            Album update = db.Albums.Find(int.Parse(albumID));
            update.Albumname = albumName;
            update.AlbumImage = albumImage;
            update.AlbumPrice = albumPrice;
            update.AlbumStock = albumStock;
            update.AlbumDescription = albumDescription;
            db.SaveChanges();
            return update;
        }
        
        public Album DeleteAlbum(String albumID)
        {
            Album delete = db.Albums.Find(int.Parse(albumID));
            db.Albums.Remove(delete);
            db.SaveChanges();
            return delete;
        }
    }
}