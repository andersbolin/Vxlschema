using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Manager_Datamanager : System.Web.UI.Page
{
    //Declaring variables
    String turnr, start, slut;

    protected void Page_Load(object sender, EventArgs e)
    {

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
        return false;
    }
    protected bool RemovefromDB() 
    {
        Label1.Text = "";
        //ta bort en rad, key = turnr
        return false;
    }
    protected bool ChangeinDB()
    {
        Label1.Text = "";
        //ändra start & slut där ID = turnr
        return false;
    }
}