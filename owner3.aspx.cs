using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;

public partial class owner3 : System.Web.UI.Page
{
    string filename = string.Empty;
    string path2;
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader rs;
    string status1;
    string file2, org, dup;
    Class1 c = new Class1();
   // string con = "Data Source=CS2;Initial Catalog=deduplication;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        Label7.Text = Convert.ToString(Session["emailid"]);
        display();
    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Convert.ToString(GridView2.SelectedRow.Cells[4].Text);
        TextBox2.Text = Convert.ToString(GridView2.SelectedRow.Cells[2].Text);
        TextBox3.Text = Convert.ToString(GridView2.SelectedRow.Cells[3].Text);
        TextBox4.Text = Convert.ToString(GridView2.SelectedRow.Cells[1].Text);
    }
    void display()
    {
        SqlConnection con = new SqlConnection(c.constr);
        string strSQL = "Select r_id,file_id,file_name,name from req where owner='" + Convert.ToString(Session["u_id"]) + "' and flag='0'";
        SqlDataAdapter dt = new SqlDataAdapter(strSQL, con);
        DataSet ds = new DataSet();
        dt.Fill(ds, "file_id");
        con.Close();
        GridView2.DataSource = ds;
        GridView2.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
        char[] CharsString = new char[10];
        Random random = new Random();

        for (int i = 0; i < CharsString.Length; i++)
        {
            CharsString[i] = chars[random.Next(chars.Length)];
        }

        string Result = new String(CharsString);
        Label6.Text = Result;

        conn = new SqlConnection(c.constr);
        conn.Open();
        string s = "insert into temp values ('" + Label6.Text + "','" + TextBox2.Text + "')";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = s;
        cmd.ExecuteNonQuery();
      // string q = "update req set flag='1' where r_id='" + TextBox4.Text + "'";
       // cmd = new SqlCommand();
      //  cmd.Connection = conn;
      //  cmd.CommandText = q;
      //  cmd.ExecuteNonQuery();
        conn.Close();
        display();

        try
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("cloudinformation2@gmail.com");
            msg.To.Add(Label7.Text);
            msg.Body = "key " + " : " + Label6.Text;
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential networkcred = new System.Net.NetworkCredential();
            networkcred.UserName = "cloudinformation2@gmail.com";
            networkcred.Password = "cloud1234";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = networkcred;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            string script = "alert(\"key  sended successfully\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

        }
        catch (Exception ex)
        {
            Label6.Text = "problem occurred";
            Response.Write("Exception in sendEmail:" + ex.Message);
           
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(c.constr);
        conn.Open();

        string q = "update req set flag='2' where r_id='" + TextBox4.Text + "'";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        conn.Close();
        display();
        try
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("cloudinformation2@gmail.com");
            msg.To.Add(Label7.Text);
            msg.Body = "Dataowner not accepted your Request";
            msg.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential networkcred = new System.Net.NetworkCredential();
            networkcred.UserName = "cloudinformation2@gmail.com";
            networkcred.Password = "cloud1234";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = networkcred;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(msg);
            string script = "alert(\"Rejected Successfully\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

        }
        catch (Exception ex)
        {
            Label6.Text = "problem occurred";
            Response.Write("Exception in sendEmail:" + ex.Message);
        }

    }
}