using Marina.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.App
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var db = new MarinaEntities();
            var customer = CustomersManager.Authenticate(uxFirstName.Text, uxLastName.Text);
            
            if(customer == null)  // if new customer, add the customer to the DB
            {
                Customer cust = new Customer
                {
                    FirstName = uxFirstName.Text,
                    LastName = uxLastName.Text,
                    Phone = uxPhone.Text,
                    City = uxCity.Text
                };
                CustomersManager.Add(cust);
               // Response.Redirect("~/");
            }
            //at this point, student is not null meaning we have a valid authentication
            //so add student id to session
            Session.Add("CustomerID", customer.ID);
            // redirect - false means no persistent cookie
            FormsAuthentication.RedirectFromLoginPage(customer.FullName, false);
            Response.Redirect("~/MyLease");
        }
    }
}