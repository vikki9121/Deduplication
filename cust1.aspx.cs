using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cust1 : System.Web.UI.Page
{
    string filename = string.Empty;
    string path2;
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader rs;
    string status1;
    string file2, org, dup;
   string con = "Data Source=DESKTOP-V0LEKS7\\SQLEXPRESS;Initial Catalog=deduplication;Integrated Security=True";
    int a;
    Class1 c = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(c.constr);
        string strSQL = "Select file_id,org,u_name from index1 where org like'%" + TextBox1.Text + "%' or Keywords like'%" + TextBox1.Text + "%'";
        SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
        DataSet ds = new DataSet();
        dt.Fill(ds, "file_id");
        con.Close();
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        conn = new SqlConnection(c.constr);
        conn.Open();

        string q = "select count(*) from req";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        a = Convert.ToInt32(cmd.ExecuteScalar());
        a += 1;
        q = "insert into req values('" + Convert.ToString(Session["u_id"]) + "','" + Convert.ToString(GridView2.SelectedRow.Cells[1].Text) + "','" + Convert.ToString(GridView2.SelectedRow.Cells[2].Text) + "','0','" + Convert.ToString(GridView2.SelectedRow.Cells[3].Text) + "','" + a + "')";
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}