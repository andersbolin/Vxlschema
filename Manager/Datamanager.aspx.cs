using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_Datamanager : System.Web.UI.Page
{
    //Declaring variables
    String turnr, start, slut;
    SqlConnection conn;
    //string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|/SJ.mdf;Integrated Security=True;Connect Timeout=30";
    string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|/SJ.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework";    

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "";
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool result;
        //check what type of change is wanted and send values there
        if(DropDownList1.SelectedIndex == 0){
            result = AddtoDB();
        } else if(DropDownList1.SelectedIndex == 1){
            result = RemovefromDB();
        } else {
            result = ChangeinDB();
        }
        if(result && DropDownList1.SelectedIndex == 0) {
            Label1.Text = "Tillagt i databasen";
        }
        if(result && DropDownList1.SelectedIndex == 1) {
            Label1.Text = "Borttaget från databasen";
        }
        if(result && DropDownList1.SelectedIndex == 2) {
            Label1.Text = "Ändrat i databasen";
        }
        if(!result) {
            Label1.Text = "Kunde inte utföras. Kontakta support om felet kvarstår";
        }
    }

    protected bool AddtoDB()
    {
        Label1.Text = "";
        //Lägg till en hel rad
        try
        {
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [Table] (Id,start,slut) VALUES (@tur,@sta,@sto)";
            cmd.Parameters.Add(new SqlParameter("@tur",TextBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@sta",TextBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@sto",TextBox3.Text));
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();            
        } catch (SqlException ex) {
            return false;             
        } finally {
            conn.Close();
        }
        return true;
    }
    protected bool RemovefromDB() 
    {
        Label1.Text = "";
        //ta bort en rad, key = turnr
        try
        {
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE FROM [Table] WHERE Id="+TextBox1.Text;
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();        
        }
        catch (Exception ex)
        {            
            throw;
            return false;
        }
        finally
        {
            conn.Close();
        }
        return true;
    }
    protected bool ChangeinDB()
    {
        Label1.Text = "";
        //ändra start & slut där ID = turnr
        try
        {
            conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE [Table] SET start=@sta, slut=@sto WHERE Id=@key";
            cmd.Parameters.Add(new SqlParameter("@key", TextBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@sta", TextBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@sto", TextBox3.Text));
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();  
        }
        catch (Exception)
        {            
            throw;
            return false;
        }
        finally
        {
            conn.Close();
        }
        return true;
    }
}