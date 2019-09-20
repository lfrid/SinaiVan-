using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Forms_LogIn : System.Web.UI.Page
{
    //protected void Page_PreInit(object sender, EventArgs e)
    //{
    //    Request.ContentType = "text/css";
    //}
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Login1.Focus();
    }
    
    protected void Page_LoadComplete(object sender , EventArgs e) 
     {
        CheckBox chkBox = (CheckBox)Login1.FindControl("RememberMe");
        chkBox.Visible = false;
        chkBox.Checked = false;
        chkBox.Text = "Remember me next time.";
    }
   
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {

        if (Membership.ValidateUser(Login1.UserName, Login1.Password))
        {
            FormsAuthentication.SetAuthCookie(Login1.UserName, true);
            string[] roles = Roles.GetRolesForUser(Login1.UserName);
            
            Response.Cookies["userInfo"]["ID"] = Login1.UserName;
            Response.Cookies["userInfo"]["pass"] = Login1.Password;
            var expire = DateTime.Now.AddHours(Convert.ToDouble(ConfigurationManager.AppSettings["UserIDExpire"]));
            Response.Cookies["userInfo"].Expires = expire;
            HttpContext.Current.Response.Cookies.Set(Response.Cookies["userInfo"]);

            foreach (string userRole in roles)
            {
                Session["UserRole"] = userRole;
                Session["CurrentUser"] = Login1.UserName;

                switch (userRole)
                {
                    case "Admin":
                    case "Developer":
                        Response.Redirect(Login1.DestinationPageUrl);
                        break;
                    case "Manager":
                        Response.Redirect(Login1.DestinationPageUrl);
                        break;
                    case "Supervisor":
                        Response.Redirect(Login1.DestinationPageUrl);
                        break;
                    case "User":
                        Response.Redirect(Login1.DestinationPageUrl);
                        break;
                    default:
                        Response.Redirect("~/LogIn.apsx");
                        break;
                }
            }

        }
    }

    protected void LoginStatus1_Logout(object sender, LoginCancelEventArgs e)
    {
        FormsAuthentication.SignOut();
        Session.Abandon();
        Response.Redirect("~/LogIn.aspx");
    }

}
