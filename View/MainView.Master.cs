using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class MainView : System.Web.UI.MasterPage
    {
        public Customer customer;
        protected void Page_Load(object sender, EventArgs e)
        {
            customer = ((Customer)Session["customer"]);
        }

        protected void btRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }

        protected void btHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }

        protected void btCartC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Cart.aspx");
        }

        protected void btTransactionC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Transaction.aspx");
        }

        protected void btUpdateC_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfile.aspx");
        }

        protected void btLogoutC_Click(object sender, EventArgs e)
        {
            Session.Remove("customer");
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();

            HttpContext.Current.Response.Cookies.Remove("customer"); 
            HttpCookie cookie = HttpContext.Current.Request.Cookies["customer"]; 
            cookie.Expires = DateTime.Now.AddDays(-10); 
            cookie.Value = null; 
            HttpContext.Current.Response.SetCookie(cookie);
        }
    }
}