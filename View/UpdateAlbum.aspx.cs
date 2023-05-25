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
    public partial class UpdateAlbum : System.Web.UI.Page
    {
        AlbumController controller = new AlbumController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["alb_id"]);
                id = 1;
                Album CurrAlbum = controller.GetAlbumByAlbumID(id);
                tbAlbName.Text = CurrAlbum.Albumname;
                tbAlbDesc.Text = CurrAlbum.AlbumDescription;
                tbAlbPrice.Text = Convert.ToString(CurrAlbum.AlbumPrice);
                tbAlbStock.Text = Convert.ToString(CurrAlbum.AlbumStock);
            }
        }

        protected void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            int ArtistID = Convert.ToInt32(Request.QueryString["art_id"]);
            int AlbumID = Convert.ToInt32(Request.QueryString["alb_id"]);
            lblError.Text = controller.UpdateAlbum(AlbumID, tbAlbName.Text, tbAlbDesc.Text, Convert.ToInt32(tbAlbPrice.Text), Convert.ToInt32(tbAlbStock.Text), upImage);

            if (lblError.Text == "Success")
            {
                Response.Redirect("ArtistDetail.aspx?art_id=" + ArtistID);
            }
        }
    }
}