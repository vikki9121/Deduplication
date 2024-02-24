using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class owner4 : System.Web.UI.Page
{
    string filename = string.Empty;
    string path2;
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader rs;
    string status1;
    string file2, org, dup;
    //string con = "Data Source=CS2;Initial Catalog=deduplication;Integrated Security=True";
    Class1 c = new Class1();
    protected void Page_Load(object sender, EventArgs e)
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
        string p1 = Convert.ToString(GridView2.SelectedRow.Cells[2].Text);
        conn = new SqlConnection(c.constr);
        conn.Open();

        string q = "delete from index1 where u_name='" + Convert.ToString(Session["u_id"]) + "' and file_id= '" + p1 + "'";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}