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
    public partial class Home : System.Web.UI.Page
    {
        AlbumController albController = new AlbumController();
        ArtistController artController = new ArtistController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Artist> Artists = artController.GetAllArtists();
                gvArtistsDetail.DataSource = Artists;
                gvArtistsDetail.DataBind();
            }
        }

        protected void gvArtistsDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvArtistsDetail.Rows[e.RowIndex];
            artController.DeleteArtist(row.Cells[0].Text);
            Response.Redirect(Request.RawUrl);
        }

        protected void gvArtistsDetail_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvArtistsDetail.Rows[e.NewEditIndex];
            Response.Redirect("~/View/UpdateArtist.aspx?art_id=" + row.Cells[0].Text);
        }

        protected void btnInsertArtist_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/CreateArtist.aspx");
        }
    }
}