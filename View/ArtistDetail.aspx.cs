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
    public partial class ArtistDetail : System.Web.UI.Page
    {
        AlbumController albController = new AlbumController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["art_id"]);
                List<Album> albums = albController.GetAllAlbumsByArtistID(id);
                gvAlbumsDetail.DataSource = albums;
                gvAlbumsDetail.DataBind();
            }
        }

        protected void btnInsertAlbum_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["art_id"]);
            Response.Redirect("InsertAlbum.aspx?art_id=" + id);
        }

        protected void btnUpdateAlbum_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["art_id"]);
            Response.Redirect("UpdateAlbum.aspx?art_id=" + id + "&alb_id=" + tbAlbumID.Text);
        }

        protected void gvAlbumsDetail_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = gvAlbumsDetail.Rows[e.NewSelectedIndex];
            tbAlbumID.Text = row.Cells[1].Text;
            tbAlbumName.Text = row.Cells[3].Text;
            tbAlbumPrice.Text = row.Cells[4].Text;
            tbAlbumDescription.Text = row.Cells[5].Text;
        }

        protected void gvAlbumsDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvAlbumsDetail.Rows[e.RowIndex];
            albController.DeleteAlbum(row.Cells[1].Text);
            Response.Redirect(Request.RawUrl);
        }
    }
}