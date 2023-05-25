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
    public partial class UpdateArtist : System.Web.UI.Page
    {
        ArtistController controller = new ArtistController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["art_id"]);
                Artist CurrArtist = controller.GetArtistByArtistID(id);
                tbArtName.Text = CurrArtist.ArtistName;
            }
        }

        protected void btnUpdateArtist_Click(object sender, EventArgs e)
        {
            int ArtistID = Convert.ToInt32(Request.QueryString["art_id"]);
            lblError.Text = controller.UpdateArtist(ArtistID, tbArtName.Text, upImage);

            if (lblError.Text == "Success")
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }
    }
}