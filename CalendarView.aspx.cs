using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalendarView : System.Web.UI.Page
{
    //Declaring variables
    DataTable dt;
    DataRow dr;
    DateTimeFormatInfo dfi;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Creates the datatable to use with gridveiw
        dt = new DataTable("Schema");
        CreateTable();

        //Create new data table
        for (int x = 0; x < 3; x++)
        {
            dr = dt.NewRow();
            dr[0] = SetWeekNumber() + x;
            dr[3] = "Test" + Environment.NewLine + "2:nd line";
            dt.Rows.Add(dr);
        }

        //Binder till gridview
        GridView gv = GridView1;
        gv.DataSource = dt;
        gv.DataBind();
        
    }

    protected int SetWeekNumber()
    {
        //week number calculation
        DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
        DateTime date1 = DateTime.Today;
        System.Globalization.Calendar cal = dfi.Calendar;
        int wnr = cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        return wnr;
    }

    protected void CreateTable()
    {
        dt.Columns.Add("Veckonr", typeof(String));
        dt.Columns.Add("Måndag", typeof(String));
        dt.Columns.Add("Tisdag", typeof(String));
        dt.Columns.Add("Onsdag", typeof(String));
        dt.Columns.Add("Torsdag", typeof(String));
        dt.Columns.Add("Fredag", typeof(String));
        dt.Columns.Add("Lördag", typeof(String));
        dt.Columns.Add("Söndag", typeof(String));
    }

    protected int TurNummer(int weeknumber)
    {

        return 0;
    }
}