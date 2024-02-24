using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class LOGIN : System.Web.UI.Page
{
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader rs;
    string con = "Data Source=CS2;Initial Catalog=deduplication;Integrated Security=True";
    string type;
    Class1 c = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         if(TextBox1.Text==""||TextBox2.Text=="")
        {
            string script = "alert(\"Enter all details\");";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
        }
        if (TextBox1.Text == "admin" && TextBox2.Text == "admin")
        {
            Response.Redirect("cloud1.aspx");
        }
        else
        {
            conn = new SqlConnection(c.constr);
            conn.Open();
            string q = "select type from reg where u_name='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "' ";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = q;
            rs = cmd.ExecuteReader();
            if (rs.Read())
            {
                
                type = Convert.ToString(rs.GetValue(0));
                
                
            }
            rs.Close();
            if (type == "Customer")
            {
                Session["u_id"] = TextBox1.Text.ToString();
                conn = new SqlConnection(c.constr);
                conn.Open();
                string s = "select mail from reg where u_name='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "' ";
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = s;
                rs = cmd.ExecuteReader();
                if (rs.Read())
                {

                    type = Convert.ToString(rs.GetValue(0));
                    string emailid = rs.GetValue(0).ToString();
                    Session["emailid"] = emailid;

                }
                rs.Close();
                Response.Redirect("cust1.aspx");

               
                
            }
            else if (type == "Data Owner")
            {
                Session["u_id"] = TextBox1.Text.ToString();
                Response.Redirect("owner1.aspx");
            }
            else
            {
                string script = "alert(\"invalid User\");";
        ScriptManager.RegisterStartupScript(this,GetType(),"ServerControlScript", script, true);
            }
            conn.Close();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
}
