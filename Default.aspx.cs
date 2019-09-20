using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
//using MyFunctions = Typogram.My;
using System.Data;
using System.Web.UI.HtmlControls;

using System.IO;
using System.Text;
//using Typogram;
//using Typogram.Utility;
//using Typogram.Utility.ConnectionUtility;
//using Typogram.Utility.Support.Web;
using System.Collections;
using System.Diagnostics;

using System.DirectoryServices.AccountManagement;

public partial class Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
             Response.Redirect("~/Login.aspx");
        }
    }

    public static UserPrincipal ADGetCurrentUserPrincipalByPassword(String UserID, string Password)
    {
        //PrincipalContext context = new PrincipalContext(ContextType.Domain);
        //UserPrincipal usr = UserPrincipal.FindByIdentity(context,
        //                                             IdentityType.SamAccountName,
        //                                             UserID);

        //if (usr == null)
        //{
        PrincipalContext context = new PrincipalContext(ContextType.Domain, "SHHADC01.nslijhs.net");
        UserPrincipal usr = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, UserID);
        // }

        var authenticated = context.ValidateCredentials(usr.Name, Password, ContextOptions.SimpleBind);
        if (!authenticated)
        {
            authenticated = context.ValidateCredentials(usr.SamAccountName, Password, ContextOptions.Negotiate);
            if (!authenticated)
                return null;
        }

        UserPrincipal userfilter = new UserPrincipal(context);
        userfilter.SamAccountName = usr.SamAccountName;
        userfilter.Enabled = true;

        PrincipalSearcher ps = new PrincipalSearcher();
        ps.QueryFilter = userfilter;
        PrincipalSearchResult<Principal> p = ps.FindAll();
        foreach (Principal user in p)
        {
            return (UserPrincipal)user;
        }

        return null;
    }

}