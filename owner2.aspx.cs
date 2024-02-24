using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class owner2 : System.Web.UI.Page
{
    string p1;
    Class1 c = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        this.display(); 
    }
    public void display()
    {
        SqlConnection con = new SqlConnection(c.constr);
        string strSQL = "Select u_name,file_id,org,Keywords  from index1 where u_name='" + Convert.ToString(Session["u_id"]) + "'";
        SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
        DataSet ds = new DataSet();
        dt.Fill(ds, "file_id");
        con.Close();
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        p1 = Convert.ToString(GridView2.SelectedRow.Cells[3].Text);
        if (p1 != string.Empty)
        {                             
            if (p1.EndsWith(".txt"))
            {
                Response.ContentType = "application/txt";
            }
            else if (p1.EndsWith(".pdf"))
            {
                Response.ContentType = "application/pdf";
            }
            else if (p1.EndsWith(".docx"))
            {
                Response.ContentType = "application/docx";
            }
            else
            {
                Response.ContentType = "image/jpg";
            }

            string filePath = p1;

            Response.AddHeader("Content-Disposition", "attachment;filename=\"" + filePath + "\"");
            Response.TransmitFile(Server.MapPath(filePath));
            Response.End();
        }
    }
}