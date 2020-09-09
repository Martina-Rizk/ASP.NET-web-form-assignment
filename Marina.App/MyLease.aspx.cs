using Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.App
{
    public partial class MyLease : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["CustomerID"]);
                var db = new MarinaEntities();
                var lease = db.Leases.Where(l => l.CustomerID == id).ToList();
                grdLeased.DataSource = lease;
                DataBind();
            }
        }
    }
}