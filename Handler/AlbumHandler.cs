using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZstation.Handler
{
    public class AlbumHandler
    {
        AlbumRepository AlbumRepo = new AlbumRepository();
        public Album uploadAlbum(int ArtistID, String AlbName, String AlbDesc, int AlbPrice, int AlbStock, FileUpload upImage)
        {
            string directoryPath = "Assets/Albums/";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryPath, upImage.FileName);
            upImage.SaveAs(filePath);
            string AlbImage = "~/" + directoryPath + upImage.FileName;

            return AlbumRepo.InsertAlbum(ArtistID, AlbName, AlbImage, AlbPrice, AlbStock, AlbDesc);
        }

        public Album updateAlbum(int AlbumID, String AlbName, String AlbDesc, int AlbPrice, int AlbStock, FileUpload upImage)
        {
            string directoryPath = "Assets/Albums/";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryPath, upImage.FileName);
            upImage.SaveAs(filePath);
            string AlbImage = "~/" + directoryPath + upImage.FileName;

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

        public Album GetAlbumByArtistIDAndAlbumID(int artistID, int albumID)
        {
            return AlbumRepo.GetAlbumByArtistIDAndAlbumID(artistID, albumID);
        }
    }
}