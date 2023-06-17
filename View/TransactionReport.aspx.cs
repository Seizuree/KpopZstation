using KpopZstation.Dataset;
using KpopZstation.Handler;
using KpopZstation.Model;
using KpopZstation.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        Customer customer;
        protected void Page_Load(object sender, EventArgs e)
        {
            customer = ((Customer)Session["customer"]);

            if (customer == null)
            {
                Response.Redirect("~/View/Login.aspx");
            }
            if (!customer.CustomerRole.Equals("admin"))
            {
                Response.Redirect("~/View/Home.aspx");
            }

            CrystalReportTransaction report = new CrystalReportTransaction();
            CrystalReportViewer1.ReportSource = report;

            TransactionDataset data = getData(TransactionHandler.getTransactions());
            report.SetDataSource(data);
        }

        private TransactionDataset getData(List<TransactionHeader> transactions)
        {
            TransactionDataset data = new TransactionDataset();

            var headerTable = data.TransactionHeader;
            var detailTable = data.TransactionDetail;

            // looping untuk masukin data kedalam dataset
            foreach (TransactionHeader th in transactions)
            {
                var hrow = headerTable.NewRow();
                hrow["TransactionID"] = th.TransactionID;
                hrow["Customer ID"] = th.CustomerID;
                hrow["Transaction Date"] = th.TransactionDate;
                hrow["Grand Total Value"] = th.TransactionDetails.Sum(detail => detail.Qty * detail.Album.AlbumPrice);

                headerTable.Rows.Add(hrow);

                foreach (TransactionDetail td in th.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionID"] = td.TransactionID;
                    drow["Album Name"] = td.Album.Albumname;
                    drow["Quantity"] = td.Qty;
                    drow["Album Price"] = td.Album.AlbumPrice;
                    drow["Sub Total Value"] = td.Qty * td.Album.AlbumPrice;

                    detailTable.Rows.Add(drow);
                }
            }

            return data;
        }
    }
}