using KpopZstation.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace KpopZstation.View
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitAlbum_Click(object sender, EventArgs e)
        {            
            AlbumController validator = new AlbumController();
            int id = Convert.ToInt32(Request.QueryString["art_id"]);

            lblError.Text = validator.InsertAlbum(id, tbAlbName.Text, tbAlbDesc.Text, Convert.ToInt32(tbAlbPrice.Text), Convert.ToInt32(tbAlbStock.Text), upImage);

            if (lblError.Text == "Success")
            {
                Response.Redirect("ArtistDetail.aspx?art_id=" + id);
            }
        }
    }
}