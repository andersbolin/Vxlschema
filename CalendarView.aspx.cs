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
    protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable("Schema");
        dt.Columns.Add("Veckonr", typeof(String));
        dt.Columns.Add("Måndag", typeof(String));
        dt.Columns.Add("Tisdag", typeof(String));
        dt.Columns.Add("Onsdag", typeof(String));
        dt.Columns.Add("Torsdag", typeof(String));
        dt.Columns.Add("Fredag", typeof(String));
        dt.Columns.Add("Lördag", typeof(String));
        dt.Columns.Add("Söndag", typeof(String));
        DataRow dr = dt.NewRow();
        //week number calculation
        DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
        DateTime date1 = DateTime.Today;
        System.Globalization.Calendar cal = dfi.Calendar;
        dr[0] = cal.GetWeekOfYear(date1, dfi.CalendarWeekRule, dfi.FirstDayOfWeek);
        dr[3] = "Test";
        dt.Rows.Add(dr);
        GridView gv = GridView1;
        gv.DataSource = dt;
        gv.DataBind();
        //GridViewRow row = (GridView)GridView1.Rows[0].Copy;
        //row.Cells[0].Value = "XYZ";
        //row.Cells[1].Value = 50.2;
        //GridView1.Row.Add(row);
    }
}