using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Net.Mail;
using System.Drawing;

public partial class owner1 : System.Web.UI.Page
{
    string filename = string.Empty;
    string path2;
    SqlConnection conn;
    SqlCommand cmd;
    SqlDataReader rs;
    string status1,status;
    string file2, org, dup,path1,file3;
    string fname1, fname2;
    int count1,count2;
    bool flag=true;
   // string con = "Data Source=RETECH\\SQLEXPRESS;Initial Catalog=deduplication;Integrated Security=True";
    int a;
    Class2 c1 = new Class2();
    Class1 c = new Class1();
    string ext;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        path2 = "temp/" + FileUpload1.FileName;
        filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
      ext = Path.GetExtension(FileUpload1.PostedFile.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/temp/" + filename));
        if (ext == ".txt")
        {
           status = validate(path2);
        }
        else if (ext==".png"|| ext==".PNG"||ext==".jpg")
        {
            status = validate1(path2);
        }
        if (status == "dup")
        {
            string script = "alert(\"SUCESSFULLY UPLOADED\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
            conn = new SqlConnection(c.constr);
            conn.Open();
            dup = FileUpload1.FileName;
            string q = "select count(*) from index1";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = q;
            a = Convert.ToInt32(cmd.ExecuteScalar());
            a += 1;
            q = "insert into index1 values('" + a + "','" + dup + "','" + org + "','" + file3 + "','" + Convert.ToString(Session["u_id"]) + "','" + TextBox1.Text + "','" + file2 + "')";
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        else if (status == "new")
        {
            upload();
            string script = "alert(\"SUCESSFULLY UPLOADED\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
            conn = new SqlConnection(c.constr);
            conn.Open();
            org = FileUpload1.FileName;
            string q = "select count(*) from index1";
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = q;
            a = Convert.ToInt32(cmd.ExecuteScalar());
            a += 1;
            q = "insert into index1 values('" + a + "','" + org + "','" + org + "','" + path2 + "','" + Convert.ToString(Session["u_id"]) + "','" + TextBox1.Text + "','"+path1+"')";
           
            cmd.CommandText = q;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        
    }
    public void upload()
    {
        filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
        FileUpload1.SaveAs(Server.MapPath("~/Files/" + filename));
        Response.Write("File uploaded sucessfully.");

        c1.encrypt(Server.MapPath("~/Files/" + filename), Server.MapPath("~/Files/Encrypted/" + filename));
        path2 = "Files/Encrypted/" + FileUpload1.FileName;
        path1 = "Files/" + FileUpload1.FileName;
    }
    public string validate(string path1)
    {

        string file1 =Server.MapPath( path1);

        conn = new SqlConnection(c.constr);
        conn.Open();
        string q = "select path2,org,path from index1  ";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        rs = cmd.ExecuteReader();
       
        while (rs.Read())
        {
            file2 = Convert.ToString(rs.GetValue(0));
            string file4 = Server.MapPath(Convert.ToString(rs.GetValue(0)));
            file3 = Convert.ToString(rs.GetValue(2));


            HashAlgorithm hashAlgo = HashAlgorithm.Create();

            FileStream stream1 = new FileStream(file1, FileMode.Open);
            FileStream stream2 = new FileStream(file4, FileMode.Open);

            byte[] hash1;
            byte[] hash2;

            hash1 = hashAlgo.ComputeHash(stream1);
            hash2 = hashAlgo.ComputeHash(stream2);
            stream1.Close();
            stream2.Close();
            string text = System.IO.File.ReadAllText(file1);
            string text2 = System.IO.File.ReadAllText(file4);
            if (Convert.ToBase64String(hash1) == Convert.ToBase64String(hash2))
            {
                status1 = "dup";

            }

            int aa = Compute(text, text2);
            if (aa == 0)
            {
                status1 = "dup";
                org = Convert.ToString(rs.GetValue(1));
                break;
            }
        }


        rs.Close();
        conn.Close();
        if (status1 == "dup")
        {
            return "dup";
        }
        else
        {
            return "new";
        }


    }

    private void encrypt(string inputFilePath, string outputfilePath, string strhash)
    {
        strhash = TextBox1.Text;
        FileStream instream, outstream;
        CryptoStream crystream;
       
        MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

        byte[] bytetext;
        instream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read);
        outstream = new FileStream(outputfilePath, FileMode.Create, FileAccess.Write);


        bytetext = File.ReadAllBytes(inputFilePath);
        md5.Clear();

      
        int bytesread;
        long length, position = 0;
        length = instream.Length;

        bytetext = File.ReadAllBytes(inputFilePath);
        while (position < length)
        {
            bytesread = instream.Read(bytetext, 0, bytetext.Length);
            position += bytesread;
            
        }
        instream.Close();
        outstream.Close();
    }
    public static int Compute(string s, string t)
    {
        if (string.IsNullOrEmpty(s))
        {
            if (string.IsNullOrEmpty(t))
                return 0;
            return t.Length;
        }

        if (string.IsNullOrEmpty(t))
        {
            return s.Length;
        }

        int n = s.Length;
        int m = t.Length;
        int[,] d = new int[n + 1, m + 1];

        // initialize the top and right of the table to 0, 1, 2, ...
        for (int i = 0; i <= n; d[i, 0] = i++) ;
        for (int j = 1; j <= m; d[0, j] = j++) ;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                int min1 = d[i - 1, j] + 1;
                int min2 = d[i, j - 1] + 1;
                int min3 = d[i - 1, j - 1] + cost;
                d[i, j] = Math.Min(Math.Min(min1, min2), min3);
            }
        }
        return d[n, m];
    }

     public string validate1(string path1)
    {
      
        string file1 = Server.MapPath(path1);
       Bitmap img1,img2;
        conn = new SqlConnection(c.constr);
        conn.Open();
        string q = "select path2,org,path from index1  ";
        cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = q;
        rs = cmd.ExecuteReader();
        while (rs.Read())
        {
            file2 = Convert.ToString(rs.GetValue(0));
            string file4 = Server.MapPath(Convert.ToString(rs.GetValue(0)));
            file3 = Convert.ToString(rs.GetValue(2));

            fname1 = file1.ToString();
            fname2 = file4.ToString();

             string img1_ref, img2_ref;
    img1 = new Bitmap(fname1);
    img2 = new Bitmap(fname2);
    //progressBar1.Maximum = img1.Width;
    if (img1.Width == img2.Width && img1.Height == img2.Height)
    {
        for (int i = 0; i < img1.Width; i++)
        {
            for (int j = 0; j < img1.Height; j++)
            {
                img1_ref = img1.GetPixel(i, j).ToString();
                img2_ref = img2.GetPixel(i, j).ToString();
                if (img1_ref != img2_ref)
                {
                    count2++;
                    flag = false;
                    break;
                }
                count1++;
            }
            //progressBar1.Value++;
        }
        if (flag == false)
            status="new";
        //MessageBox.Show("Sorry, Images are not same , " + count2 + " wrong pixels found");
        else
         status="dup";
        //MessageBox.Show(" Images are same , " + count1 + " same pixels found and " + count2 + " wrong pixels found");
    }
    else
          status="new";
    //MessageBox.Show("can not compare this images");
    this.Dispose();
}
         
        rs.Close();
        conn.Close();
        if (status == "dup")
        {
            return "dup";
        }
        else
        {
            return "new";
        }


    }
   
}