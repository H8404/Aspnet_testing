using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Testi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      lblUSername.Text = string.Format("<i>{0}</i>", Page.User.Identity.Name);
    }

  protected void btnShow_Click(object sender, EventArgs e)
  {
    ShowRole();
  }
  protected void btnShowRoles_Click(object sender, EventArgs e)
  {
    ShowRoles();
  }

  //[Authorize]
  protected void ShowRole()
  {
    //TODO...
  }
  protected void ShowRoles()
  {
    //TODO....
  }
}