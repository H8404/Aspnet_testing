using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PotentialInjectionRisk : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
        if (!IsPostBack)
        {
            txtDate.Text = DateTime.Now.ToShortDateString();
        }
  }

    protected void btn_Click(object sender, EventArgs e)
    {
        //Huono esimerkki
        string nimi = txtName.Text;
        string kommentti = txtComment.Text;
        string pvm = txtDate.Text;
        //string sql = string.Format("INSERT INTO comment (name,comment,date) VALUES ('{0}', '{1}', '{2}');",nimi,kommentti,pvm);
        //Parametrisoitu kysely
        string sql = string.Format("INSERT INTO comment (name,comment,date) VALUES (@name,@comment,@date);");
        try
        {
            MySqlConnection con = new MySqlConnection(myComments.ConnectionString);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql,con);
            //määritellään parametrit
            cmd.Parameters.AddWithValue("@name", nimi);
            cmd.Parameters.AddWithValue("@comment", kommentti);
            cmd.Parameters.AddWithValue("@date", pvm);
            int lkm = cmd.ExecuteNonQuery();
            lblMessages.Text = "Muttujia lisätty tietokantaan " + lkm;
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}