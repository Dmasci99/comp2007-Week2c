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

        /**
         * Determine which page is active and give the navbar link 
         * it's appropriate CSS Class.
         * 
         * @ChangeActivePageLink
         */
        protected void ChangeActivePageLink()
        {
            switch (Page.Title)
            {
                case "HomePage":
                    HomePage.Attributes.Add("class", "active");
                    break;
                case "AboutPage":
                    AboutPage.Attributes.Add("class", "active");
                    break;
                case "ProductsPage":
                    ProductsPage.Attributes.Add("class", "active");
                    break;
                case "ServicesPage":
                    ServicesPage.Attributes.Add("class", "active");
                    break;
                case "ContactPage":
                    ContactPage.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}