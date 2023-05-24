using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZstation.Controller
{
    public class AlbumController
    {
        AlbumHandler handler = new AlbumHandler();
        public string AlbumValidation(string AlbName, string AlbDesc, int AlbPrice, int AlbStock, FileUpload upImage)
        {
            if(AlbName.Equals(""))
            {
                return "Please fill the Album Name!";
            }
            else if(AlbName.Length > 50)
            {
                return "Album name must be under 50 characters!";
            }

            else if (AlbDesc.Equals(""))
            {
                return "Please fill the Album Description!";
            }
            else if (AlbDesc.Length > 255)
            {
                return "Album description must be under 255 characters!";
            }

            else if (AlbPrice.Equals(""))
            {
                return "Please fill the Album Price!";
            }
            
            if (AlbPrice < 100000 || AlbPrice > 1000000)
            {
                return "Album price must be between 100000 and 1000000";
            }
            
            if (AlbStock.Equals(""))
            {
                return "Please fill the Album Stock!";
            }
            
            if (AlbStock < 0)
            {
                return "Album stock must be more than 0";
            }
            
            if (upImage.PostedFile.FileName.Equals(""))
            {
                return "Please choose Album Image!";
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

        public string InsertAlbum(int ArtistID, string AlbName, string AlbDesc, int AlbPrice, int AlbStock, FileUpload images)
        {
            string result = AlbumValidation(AlbName, AlbDesc, AlbPrice, AlbStock, images);
            
            if(result == "Success")
            {
                handler.uploadAlbum(ArtistID, AlbName, AlbDesc, AlbPrice, AlbStock, images);
            }
            
            return result;
        }

        public string UpdateAlbum(int AlbumID, string AlbName, string AlbDesc, int AlbPrice, int AlbStock, FileUpload images)
        {
            string result = AlbumValidation(AlbName, AlbDesc, AlbPrice, AlbStock, images);

            if (result == "Success")
            {
                handler.updateAlbum(AlbumID, AlbName, AlbDesc, AlbPrice, AlbStock, images);
            }
            
            return result;
        }

        public List<Album> GetAllAlbumsByArtistID(int id)
        {
            return handler.GetAlbumsByArtistID(id);
        }

        public Album GetAlbumByAlbumID(int id)
        {
            return handler.GetAlbumByAlbumID(id);
        }

        public Album GetAlbumByArtistIDAndAlbumID(int artistID, int albumID)
        {
            return handler.GetAlbumByArtistIDAndAlbumID(artistID, albumID);
        }

        public Album DeleteAlbum(String id)
        {
            return handler.deleteAlbum(id);
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