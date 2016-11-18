using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Tunnistus : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = System.Environment.UserDomainName + "\\" + System.Environment.UserName;
        Label2.Text = Page.User.Identity.Name;
        Label3.Text = Page.User.Identity.IsAuthenticated.ToString();
        Label4.Text = Page.User.Identity.AuthenticationType;
        Label5.Text = Page.Request.Params["AUTH_PASSWORD"];
    }
}
