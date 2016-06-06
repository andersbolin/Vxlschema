using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SchemaCalculation : System.Web.UI.Page
{
    //Declaring variables
    int[] kalenderveckor = { 7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,1,2,3,4,5,6,7,8,9,10,11,12,13,14 };
    int[] nyckelvnr = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };

    string[] v1 = {"150","132","F","110 580","590 505","516","FP"};
    string[] v2 = {"FP","402","403 210","305","FP","FP"};
    string[] v3 = { "201", "200", "132", "FP", "105", "226", "107 507" };
    string[] v4 = { "511 580", "590 520", "530", "F", "FP", "FP", "FP" };
    string[] v5 = { "410", "210", "8204", "8200", "8200", "FP", "8200" };
    string[] v6 = { "8202", "8206", "FP", "300", "335", "336", "327" };
    string[] v7 = { "300", "8204", "8207", "F", "FP", "FP", "FP" };
    string[] v8 = { "8204", "8205", "100 560", "570 500", "510", "FP", "FP" };
    string[] v9 = { "FP", "FP", "FP", "F", "115", "126", "137" };
    string[] v10 = { "340", "330", "402", "403 400", "205", "FP", "FP" };
    string[] v11 = { "F", "120", "110 580", "590 540", "550", "FP", "FP" };
    string[] v12 = { "FP", "340", "340", "200", "FP", "106", "307" };
    string[] v13 = { "330", "300", "8202", "8202", "8203", "FP", "FP" };
    string[] v14 = { "120", "100 560", "570 500", "510", "FP", "FP", "FP" };
    string[] v15 = { "FP", "F", "8206", "401", "355", "316", "237" };


    protected void Page_Load(object sender, EventArgs e)
    {

    }
}