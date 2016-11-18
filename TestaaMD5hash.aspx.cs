using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

public partial class MD5hash : System.Web.UI.Page
{
  private static string UsersXML;
  protected void Page_Load(object sender, EventArgs e)
  {
    //haetaan users.xml tiedoston nimi
    if (!IsPostBack)
    {
      UsersXML = GetFileName();
      ltFileName.Text = UsersXML;
    }
  }
  private bool HaeKäyttäjät(out string tulos)
  {
    try
    {
      //TODO
      tulos = "löytyi";
      return true;
    }
    catch (Exception ex)
    {
      tulos = ex.Message;
      return false;
    }
  }
  private string GetFileName()
  {
    //haetaan web.configista
    var olio = ConfigurationManager.AppSettings["kayttajatiedosto"];
    string filu = "";
    if (olio != null)
    {
      filu = olio.ToString();
      filu = Server.MapPath("~/App_Data/" + filu);
    }
    return filu;
  }
  protected void btnShowUsers_Click(object sender, EventArgs e)
  {
    //TODO
  }
  protected void btnShowHash_Click(object sender, EventArgs e)
  {
    //TODO hashataan salasana ja näytetään se
  }
  protected void btnShowHash256_Click(object sender, EventArgs e)
  {
    //TODO
    string mj = txtPassword.Text;
  }
  protected void btnTesthash_Click(object sender, EventArgs e)
  {
    //huom sama koodi toimii molemmille MD5 & SHA256 buttoselle
    bool sha256 = false;
    bool salasanaOK = false;
    //tutkitaan mikä nappula kutsui tätä funktiota
    //TODO
  }
  protected void btnCreateHash_Click(object sender, EventArgs e)
  {
    //luodaan hash ja näytetään se txtboxissa
    //hashataan annettu salasana 
    string mj = txtPassword.Text;
    if (mj.Length > 0)
    {
      txtPasswordHashed.Text = JAMK.IT.Security.MD5Hash.GetMd5Hash(mj);
    }
  }
  protected void btnCreateUser_Click(object sender, EventArgs e)
  {
    //TODO
  }

  protected void btnShowHex_Click(object sender, EventArgs e)
  {
    string mj = txtPassword.Text;
    string hexa = JAMK.IT.Security.MyConvert.ConvertStringToHex(mj);
    lblResult.Text = string.Format("merkkijono {0} on hexana {1}", mj, hexa);
  }
}