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
    DAL dal = new DAL();
    String turnr, start, slut;
    SqlConnection conn;
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
        return dal.addTur(TextBox1.Text, TextBox2.Text, TextBox3.Text);
    }

    protected bool RemovefromDB() 
    {
        return dal.deleteTur(TextBox1.Text);
    }

    protected bool ChangeinDB()
    {
        return dal.changeTur(TextBox1.Text, TextBox2.Text, TextBox3.Text);
    }
}