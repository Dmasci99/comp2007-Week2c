using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week2c
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ChangeActivePageLink();
        }

        protected void ChangeActivePageLink()
        {
            switch (Page.Title)
            {
                case "HomePage": HomePage.Attributes.Add("class", "active");
                    break;
                case "AboutPage":
                    HomePage.Attributes.Add("class", "active");
                    break;
                case "ProductsPage":
                    HomePage.Attributes.Add("class", "active");
                    break;
                case "ServicesPage":
                    HomePage.Attributes.Add("class", "active");
                    break;
                case "ContactPage":
                    HomePage.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}