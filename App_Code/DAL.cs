using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// DAL to be used by Schema WEBTOOL
/// </summary>
public class DAL
{

    //Declare variables
    SqlConnection conn;
    string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|/SJ.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework";    

	public DAL()
	{
		
	}

    public bool deleteTur(string tur)  
    {
        using(conn = new SqlConnection(connectionString)){
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "DELETE FROM [Table] WHERE Id=" + tur;
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return false;
            }
        }
        return true;
    }

    public bool changeTur(string tur, string start, string stop)
    {
        using(conn = new SqlConnection(connectionString)){
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "UPDATE [Table] SET start=@sta, slut=@sto WHERE Id=@key";
            cmd.Parameters.Add(new SqlParameter("@key", tur));
            cmd.Parameters.Add(new SqlParameter("@sta", start));
            cmd.Parameters.Add(new SqlParameter("@sto", stop));
            cmd.Connection = conn;         
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        return true;
    }

    public bool addTur(string tur, string start, string stop)
    {
        string value = string.Empty;
        using(conn = new SqlConnection(connectionString)){
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT INTO [Table] (Id,start,slut) VALUES (@tur,@sta,@sto)";
            cmd.Parameters.Add(new SqlParameter("@tur",tur));
            cmd.Parameters.Add(new SqlParameter("@sta",start));
            cmd.Parameters.Add(new SqlParameter("@sto",stop));
            cmd.Connection = conn;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        return true;
    }

    public string getTurStop(int tur)
    {
        string value = string.Empty;
        using(conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT start FROM [Table] WHERE Id=" + tur;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                value = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex) 
            {
                return string.Empty;
            }
        }
        return value;
    }

    public string getTurStart(int tur)
    {
        string value = string.Empty;
        using (conn = new SqlConnection(connectionString))
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT stop FROM [Table] WHERE Id=" + tur;
            cmd.Connection = conn;
            try
            {
                conn.Open();
                value = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        return value;
    }
}