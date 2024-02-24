using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cloud2 : System.Web.UI.Page
{
    Class1 c = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(c.constr);
        string strSQL = "Select file_id,u_name  from index1 where dup='" + DropDownList1.SelectedItem.Text + "'";
        SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
        DataSet ds = new DataSet();
        dt.Fill(ds, "file_id");
        con.Close();
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}