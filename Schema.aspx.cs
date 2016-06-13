using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using System.Data.SqlClient;


public partial class Schema : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string key;

        key = ((DropDownList)PreviousPage.FindControl("DropDownList1")).Text;

        string startdatum, slutdatum;

        startdatum = ((TextBox)PreviousPage.FindControl("DateTextBox")).Text;
        slutdatum = ((TextBox)PreviousPage.FindControl("DateTextBox1")).Text;

        Label1.Text = startdatum;
        Label3.Text = slutdatum;
        Label2.Text = key;

        //Data Source=Data Source=(LocalDB)\v11.0;AttachDbFilename="C:\Users\Anders\Documents\Visual Studio 2013\WebSites\WebSite5\App_Data\SJ.mdf";Integrated Security=True;Connect Timeout=30
        SqlConnection conn;
        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|/SJ.mdf;Integrated Security=True;Connect Timeout=30";
        conn = new SqlConnection(connectionString);

        try{
            conn.Open();
            Label3.Text = "Data connection is open..";
            conn.Close();
        } catch (Exception ex){
            Label2.Text = "Failed to open..";
            Label3.Text = ex.ToString();
        }
    }
}