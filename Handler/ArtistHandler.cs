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
    public class ArtistHandler
    {
        ArtistRepository ArtistRepo = new ArtistRepository();

        public Artist uploadArtist(String ArtName, FileUpload upImage)
        {
            string directoryPath = "Assets/Artists/";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryPath, upImage.FileName);
            upImage.SaveAs(filePath);
            string ArtImage = "~/" + directoryPath + upImage.FileName;

            return ArtistRepo.InsertArtist(ArtName, ArtImage);
        }

        public Artist updateArtist(int ArtistID, String ArtName, FileUpload upImage)
        {
            string directoryPath = "Assets/Artists/";
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, directoryPath, upImage.FileName);
            upImage.SaveAs(filePath);
            string ArtImage = "~/" + directoryPath + upImage.FileName;

            return ArtistRepo.UpdateArtist(ArtistID, ArtName, ArtImage);
        }

        public Artist deleteArtist(String artistID)
        {
            return ArtistRepo.DeleteArtist(artistID);
        }
        public Artist GetArtistByArtistID(int id)
        {
            return ArtistRepo.GetArtistByID(id);
        }

        public List<Artist> GetAllArtist()
        {
            return ArtistRepo.GetArtists();
        }
        public List<Artist> GetArtistsByArtistID(int id)
        {
            return ArtistRepo.GetArtistsByArtistID(id);
        }
    }
}