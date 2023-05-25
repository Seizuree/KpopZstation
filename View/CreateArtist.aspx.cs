using KpopZstation.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace KpopZstation.View
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitArtist_Click(object sender, EventArgs e)
        {
            ArtistController validator = new ArtistController();

            lblError.Text = validator.InsertArtist(tbArtName.Text, upImage);

            if (lblError.Text == "Success")
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }
    }
}