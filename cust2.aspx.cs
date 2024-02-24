using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cust2 : System.Web.UI.Page
{
    string p,p1;
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader rs;
    //string con = "Data Source=CS2;Initial Catalog=deduplication;Integrated Security=True";
    string type, s2;
    Class1 c = new Class1();
    Class2 c1 = new Class2();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn = new SqlConnection(c.constr);
        conn.Open();
        string q = "select file_id from temp where keyvalue='" + TextBox1.Text + "' ";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        rs = cmd.ExecuteReader();
        if (rs.Read())
        {

            type = Convert.ToString(rs.GetValue(0));
            s2 = "yes";
        }
        rs.Close();
        if (s2 == "yes")
        {
            q = "select dup,org from index1 where file_id='" + type + "' ";

            cmd.CommandText = q;
            rs = cmd.ExecuteReader();
            if (rs.Read())
            {

                p = Convert.ToString(rs.GetValue(0));
                q = Convert.ToString(rs.GetValue(1));
            }
            rs.Close();
            c1.decrypt(Server.MapPath("~/Files/Encrypted/" + p), Server.MapPath("~/Files/Decrypted/" + q));
            p1 = Server.MapPath("~/Files/Decrypted/" + q);
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
                else if (p1.EndsWith(".jpg"))
                {
                    Response.ContentType = "image/jpg";
                }
            else
            {
                Response.ContentType = "image/png";
            }

                string filePath = p1;

                //Response.AddHeader("Content-Disposition", "attachment;filename=\"" + filePath + "\"");
                //Response.TransmitFile(Server.MapPath(filePath));
                //Response.End();

                Response.Clear();
                Response.ContentType = "application/octet-stream";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(p1));

            
                Response.WriteFile(p1);
                Response.End();
               // Response.Flush();

            }
            Label4.Text = "";
            //Response.Redirect("customer1.aspx");
        }
        else
        {
            Label4.Text = "Enter correct key";
        }
    }
    protected void UpdateTimer_Tick(object sender, EventArgs e)
    {
        conn = new SqlConnection(c.constr);
        conn.Open();
        string q = "delete from temp ";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();
        Response.Redirect("timeout.aspx");
    }
    }
