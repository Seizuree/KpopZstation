using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZstation.Controller
{
    public class ArtistController
    {
        ArtistHandler handler = new ArtistHandler();
        public string ArtistValidation(string ArtName, FileUpload upImage)
        {
            if (ArtName.Equals(""))
            {
                return "Please fill the Artist Name!";
            }
            else if (ArtName.Length > 50)
            {
                return "Artist name must be under 50 characters!";
            }

            if (upImage.PostedFile.FileName.Equals(""))
            {
                return "Please choose Artist Image!";
            }

            else if (upImage.PostedFile.ContentLength >= 2000000)
            {
                return "Image file size must be lower than 2MB";
            }

            else
            {
                String[] validTypes = { ".png", ".jpg", ".jpeg", ".jfif" };
                bool isValidFile = false;
                String ext = System.IO.Path.GetExtension(upImage.PostedFile.FileName);

                for (var i = 0; i < validTypes.Length; i++)
                {
                    if (ext == validTypes[i])
                    {
                        isValidFile = true;
                        break;
                    }
                }

                if (!isValidFile)
                {
                    return "Image file extension must be .png, .jpg, .jpeg, or .jfif";
                }
            }

            return "Success";
        }

        public string InsertArtist(string ArtName, FileUpload images)
        {
            string result = ArtistValidation(ArtName, images);

            if (result == "Success")
            {
                handler.uploadArtist(ArtName, images);
            }

            return result;
        }

        public string UpdateArtist(int ArtistID, string ArtName, FileUpload images)
        {
            string result = ArtistValidation(ArtName, images);

            if (result == "Success")
            {
                handler.updateArtist(ArtistID, ArtName, images);
            }

            return result;
        }

        public List<Artist> GetAllArtistsByArtistID(int id)
        {
            return handler.GetArtistsByArtistID(id);
        }

        public List<Artist> GetAllArtists()
        {
            return handler.GetAllArtist();
        }

        public Artist GetArtistByArtistID(int id)
        {
            return handler.GetArtistByArtistID(id);
        }

        public Artist DeleteArtist(String id)
        {
            return handler.deleteArtist(id);
        }

        public string AddQuantity(string curr)
        {
            int add = Convert.ToInt32(curr) + 1;
            return Convert.ToString(add);
        }

        public string RemoveQuantity(string curr)
        {
            int remove = Convert.ToInt32(curr) - 1;
            return Convert.ToString(remove);
        }

        public Boolean AddButtonValidation(string curr, string stock)
        {
            int add = Convert.ToInt32(curr);
            int CurrStock = Convert.ToInt32(stock);

            if (add >= CurrStock)
            {
                return false;
            }

            else return true;
        }

        public Boolean RemoveButtonValidation(string curr)
        {
            int remove = Convert.ToInt32(curr);
            if (remove <= 1)
            {
                return false;
            }
            else return true;
        }
    }
}