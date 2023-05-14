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
        public string AlbumValidation(int ArtistID,string AlbName, string AlbDesc, string AlbPrice, string AlbStock, string UploadedFileName, int UploadedFileSize)
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

            int price = Convert.ToInt32(AlbPrice);
            
            if (price < 100000 || price > 1000000)
            {
                return "Album price must be between 100000 and 1000000";
            }
            
            if (AlbStock.Equals(""))
            {
                return "Please fill the Album Stock!";
            }
            
            int stock = Convert.ToInt32(AlbStock);
            
            if (stock < 0)
            {
                return "Album stock must be more than 0";
            }
            
            if (UploadedFileName.Equals(""))
            {
                return "Please choose Album Image!";
            }
            
            else if (UploadedFileSize >= 2000000)
            {
                return "Image file size must be lower than 2MB";
            }

            else
            {
                String[] validTypes = { ".png", ".jpg", ".jpeg", ".jfif" };
                bool isValidFile = false;
                String ext = System.IO.Path.GetExtension(UploadedFileName);

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
            
            handler.uploadAlbum(ArtistID, AlbName, AlbDesc, price, stock, UploadedFileName);

            return "Success";
        }

        public List<Album> GetAllAlbums(int id)
        {
            return handler.GetAlbumsByID(id);
        }

        public Album DeleteAlbum(String id)
        {
            return handler.deleteAlbum(id);
        }
    }
}