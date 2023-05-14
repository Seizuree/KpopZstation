using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AlbumHandler
    {
        AlbumRepository AlbumRepo = new AlbumRepository();
        public Album uploadAlbum(int ArtistID, String AlbName, String AlbDesc, int AlbPrice, int AlbStock, String AlbImage)
        {
            return AlbumRepo.InsertAlbum(ArtistID, AlbName, AlbImage, AlbPrice, AlbStock, AlbDesc);
        }

        public Album updateAlbum(int AlbumID, String AlbName, String AlbDesc, int AlbPrice, int AlbStock, String AlbImage)
        {
            return AlbumRepo.UpdateAlbum(AlbumID, AlbName, AlbImage, AlbPrice, AlbStock, AlbDesc);
        }

        public Album deleteAlbum(String albumID)
        {
            return AlbumRepo.DeleteAlbum(albumID);
        }

        public List<Album> GetAlbumsByArtistID(int id)
        {
            return AlbumRepo.GetAlbumsByArtistID(id);
        }

        public Album GetAlbumByAlbumID(int id)
        {
            return AlbumRepo.GetAlbumByID(id);
        }
    }
}