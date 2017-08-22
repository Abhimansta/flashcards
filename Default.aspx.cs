using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
            fl1.InnerHtml = "";
            SqlConnection con1 = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con1.Open();
            string oString = "Select * from projectlist";
            SqlCommand oCmd = new SqlCommand(oString, con1);
            SqlDataReader mdr = oCmd.ExecuteReader();

            while (mdr.Read())
            {
                fl1.InnerHtml += "<div style='background-color: "+mdr[0]+ "' class='flashcard' runat='server'><span runat='server' onclick='dellEntry'>X</span><h3> Team : " + mdr[1] + " </h3><h4> Team Memebers: </h4><p> " + mdr[2] + " <br/> " + mdr[3] + " <br/> " + mdr[4] + " </p><h4> Project Name: " + mdr[5] + "</h4 > </div > ";
            }

            mdr.Close();
            con1.Close();

        }
        catch (Exception p)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('wrong in here!')", true);
        }
        
    }

    void dellentry()
    {
        this.Parent.
        SqlConnection con1 = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        con1.Open();
        string oString = "Select * from projectlist";
        SqlCommand oCmd = new SqlCommand(oString, con1);
    }
    
    protected void Submit_Click(object sender, EventArgs e)
    {
        var t = false;

        //file upload: 

        if (project_file.HasFile)
        {
            //file saviing into a local directory.
            project_file.SaveAs("D:/" + project_file.FileName);

        }
        else
        {
            //no file uploaded
        }

        try
        {
            Random rnd = new Random();
            var rndColor = String.Format("#{0:X6}", rnd.Next(0x1000000));



            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            con.Open();
            string oString = "INSERT INTO projectlist VALUES('" + rndColor + "','" + TeamName.Text + "','" + Member1.Text + "','" + Member2.Text + "','" + Member3.Text + "','" + protitle.Text + "','" + prodes.Text + "')";
            SqlCommand oCmd = new SqlCommand(oString, con);
            oCmd.ExecuteNonQuery();
            con.Close();

           
            t = true;
        }
        catch (Exception ex)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('something is wrong on not uneque :  ')", true);
        }
        finally
        {
            if(t)
            {
                Response.Redirect("Default.aspx?Load=Load");
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
                
            }
        }

    }
    

    
}