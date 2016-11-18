using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ValidateRequest : System.Web.UI.Page
{
    //http://stackoverflow.com/questions/502112/handling-request-validation-silently
    public override void ProcessRequest(HttpContext context)
    {
        try
        {
            base.ProcessRequest(context);
        }
        catch (HttpRequestValidationException ex)
        {

            context.Response.Redirect("HandleValidationError.aspx");
        }
    }

    protected void Page_Load(object sender, EventArgs e)
  {
    try
    {

    }
    catch (Exception ex)
    {
      ltMessage.Text = ex.Message;  
    }
  }

  protected void btnCommit_Click(object sender, EventArgs e)
  {
    try
    {
            string xmlfilu = Server.MapPath("~/App_Data/Comments.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(xmlfilu);
            string[] newrow = { txtName.Text, txtComment.Text, DateTime.Now.ToShortDateString() };
            ds.Tables[0].Rows.Add(newrow);
            ds.WriteXml(xmlfilu);
            txtName.Text = string.Empty;
            txtComment.Text = string.Empty;
            gvComments.DataBind();
    }
    catch (Exception ex)
    {
      ltMessage.Text = ex.Message;
    }
  }
}