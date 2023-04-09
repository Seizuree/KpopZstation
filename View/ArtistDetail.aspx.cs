using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AlbumRepository albumView = new AlbumRepository();
                List<Album> albums = albumView.GetAlbums();
                gvAlbumsDetail.DataSource = albums;
                gvAlbumsDetail.DataBind();
            }
        }

        protected void btnInsertAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertAlbum.aspx");
        }

        protected void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateAlbum.aspx");
        }

        protected void btnDeleteAlbum_Click(object sender, EventArgs e)
        {

        }

        protected void gvAlbumsDetail_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gvAlbumsDetail.Rows[e.NewSelectedIndex];
            tbSelectedAlbumName.Text = row.Cells[2].Text;
        }
    }
}