using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PasswordRecovery : System.Web.UI.Page
{
   // private MembershipUser mu = null;

    protected void Page_Load(object sender, EventArgs e)
    {
        //var sinaiVerify = new Sinai_Verify();
        //sinaiVerify.VerifyLogIn();
        PassRecovery.Focus();
       // this.PWRecovery.Focus();
        //BIZ.ShowLogOut(Master);
    }

    protected void PWRecovery_SendMailError(object sender, SendMailErrorEventArgs e)
    {

    }

    protected void PasswordRecovery_submit(object sender, MailMessageEventArgs e)
    {
        PasswordRecovery_SendingMail(sender, e);
        e.Cancel = false;
    }
    protected void PasswordRecovery_SendingMail(object sender, MailMessageEventArgs e)
    {
        try
        {

            MembershipUser mu = Membership.GetUser(PassRecovery.UserName);

            SmtpClient emailClient = new SmtpClient();

            NetworkCredential SMTPUserInfo = new NetworkCredential("leonfrid1987@gmail.com", "Swim1956#");
           // NetworkCredential SMTPUserInfo = new NetworkCredential("info@sinaivanservice.com", "8080news");

            emailClient.Port = 587;
            emailClient.EnableSsl = true;
            emailClient.UseDefaultCredentials = false;
            emailClient.Credentials = SMTPUserInfo;
            e.Message.To.Add(mu.Email);
            emailClient.Send(e.Message);
            e.Cancel = true;
        }
        catch (Exception exx)
        {
            exx.Message.ToString();
        }
    }
   
}


