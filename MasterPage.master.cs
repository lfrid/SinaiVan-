using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Web.Configuration;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
                       
          //  Configuration config = WebConfigurationManager.OpenWebConfiguration(
          //  HttpContext.Current.Request.ApplicationPath);
          //  SmtpSection settings = (SmtpSection)config.GetSection("system.net/mailSettings/smtp");

          //  settings.Network.UserName = "remedysol@gmail.com";
          //  settings.Network.Password = "remedy123";
          //  settings.Network.Host = "smtp.gmail.com";
          //  settings.Network.Port = 587;
          ////  settings.Network.EnableSsl = true;
          //  config.Save();
           
        }
         
    }

    protected void Menu1_MenuItemDataBound(object sender, MenuEventArgs e)
    {
        if (Session["UserRole"] != null)
        {
            if (Session["UserRole"].ToString() == "Supervisor")
            {
                SiteMapNode node = (SiteMapNode)e.Item.DataItem;
                if (node.Roles.Count > 0)
                {
                    var ro = node.Roles[0];
                    if (node.Roles[0].Equals("Admin"))
                    {
                        if (e.Item.Parent != null)
                            e.Item.Parent.ChildItems.Remove(e.Item);
                        else
                            menuMaster.Items.Remove(e.Item);
                    }
                }
            }
            else if (Session["UserRole"].ToString() == "User")
            {
                SiteMapNode node = (SiteMapNode)e.Item.DataItem;
                if (node.Roles.Count > 0)
                {
                    var ro = node.Roles[0];
                    if (node.Roles[0].Equals("Admin") || node.Roles[0].Equals("Supervisor"))
                    {
                        if (e.Item.Parent != null)
                            e.Item.Parent.ChildItems.Remove(e.Item);
                        else
                            menuMaster.Items.Remove(e.Item);
                    }
                }
            }
        }

    }
    protected void LoginStatus1_LoggedOut(object sender, EventArgs e)
    {
       Session.Abandon();
    }
}
