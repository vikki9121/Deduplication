using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class REGISTER : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    //string con = "Data Source=CS2;Initial Catalog=deduplication;Integrated Security=True";
    Class1 c = new Class1();
     
    
    protected void Page_Load(object sender, EventArgs e)
    { 

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(c.constr);
        conn.Open();
        string q = "insert into reg values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + DropDownList1.Text + "' )";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        conn.Close();
        string script = "alert(\"Sucessfully Registered\");";
        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        Response.Redirect("Home.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}