using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class InsertAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitAlbum_Click(object sender, EventArgs e)
        {
            
        }

        protected void FileSizeValidation(object source, ServerValidateEventArgs args)
        {
            if (upImage.HasFile)
            {
                if (upImage.PostedFile.ContentLength <= 2 * 1024 * 1024)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false; 
                }
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}