using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Marina.Data;

namespace Marina.App
{
    public partial class Docks : System.Web.UI.Page
    {
        // Dock property so someone can get the Course object
        public Dock Dock { get; set; }
        // Bolean property to set AutoPostBack
        public bool AllowPostBack
        {
            get { return ddDocks.AutoPostBack; }
            set { ddDocks.AutoPostBack = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                var mgr = new DocksManager();
                ddDocks.DataSource = mgr.GetAllAsListItems();
                ddDocks.DataTextField = "Name";
                ddDocks.DataValueField = "ID";
                ddDocks.DataBind();
                ddDocks.SelectedIndex = 0;
                ddDocks_SelectedIndexChanged(this, e);
            }
        }

        protected void ddDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new MarinaEntities();
            var id = Convert.ToInt32(ddDocks.SelectedValue); // get Id from the drop down list
            //search for dock with the selected id
            Dock dock = DocksManager.Find(id);
            Dock = dock;

            //var slip = db.Slips.Where(s => s.DockID == Dock.ID).ToList();
            //grdslip.DataSource = slip;
            var availableSlips = db.Slips.Where(s => 
            s.Leases.Count == 0 && s.DockID == Dock.ID).ToList();
            grdslip.DataSource = availableSlips;
            grdslip.DataBind();
        }
    }
}