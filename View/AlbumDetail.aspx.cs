using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        AlbumController controller = new AlbumController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // manual artistID and albumID
                int ArtistID = Convert.ToInt32(Request.QueryString["art_id"]);
                ArtistID = 1;
                int AlbumID = Convert.ToInt32(Request.QueryString["alb_id"]);
                AlbumID = 1;
                Album CurrAlbum = controller.GetAlbumByArtistIDAndAlbumID(ArtistID, AlbumID);
                AlbName.Text = CurrAlbum.Albumname;
                AlbDesc.Text = CurrAlbum.AlbumDescription;
                AlbPrice.Text = Convert.ToString(CurrAlbum.AlbumPrice);
                AlbStock.Text = Convert.ToString(CurrAlbum.AlbumStock);
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            tbQuantity.Text = controller.AddQuantity(tbQuantity.Text);
            btnAdd.Enabled = controller.AddButtonValidation(tbQuantity.Text, AlbStock.Text);
            btnRemove.Enabled = controller.RemoveButtonValidation(tbQuantity.Text);
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            tbQuantity.Text = controller.RemoveQuantity(tbQuantity.Text);
            btnAdd.Enabled = controller.AddButtonValidation(tbQuantity.Text, AlbStock.Text);
            btnRemove.Enabled = controller.RemoveButtonValidation(tbQuantity.Text);
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

        }
    }
}