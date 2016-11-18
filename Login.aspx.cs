using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security; //tätä tarvitaan autentikointia varten!!!

public partial class Login : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsPostBack)
    {
      //TODO?
    }
  }
  protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
  {
    if ((Login1.UserName != string.Empty) && (Login1.Password != string.Empty))
    {
      if (AuthenticateUser(Login1.UserName, Login1.Password))
      {
        //autentikointi onnistui --> ohjataan eteenpäin
        FormsAuthentication.RedirectFromLoginPage(Login1.UserName, true);
      }
    }
    else
    {
      Login1.BackColor = System.Drawing.Color.Orange;
      Login1.FailureText = "Autentikointi ei onnistunut.";
    }
  }
  protected Boolean AuthenticateUser(string username, string password)
  {
    //you can authenticate againts a database, a file
    //TODO tähän käyttäjän tarkistus 1)Users.xml-tiedostosta 2)Mysql-kannasta
    return username == password;
  }

}