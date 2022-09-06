using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kudvenkat81
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                country country1 = new country() { Code = "AUS", Name = "Australia", Capital = "Canberra" };
                country country2 = new country() { Code = "IND", Name = "India", Capital = "New delhi" };
                country country3 = new country() { Code = "USA", Name = "United states", Capital = "Newyork" };
                country country4 = new country() { Code = "CAN", Name = "Canada", Capital = "Ottawa" };

                Dictionary<string, country> countryDic = new Dictionary<string, country>();
                countryDic.Add(country1.Code, country1);
                countryDic.Add(country2.Code, country2);
                countryDic.Add(country3.Code, country3);
                countryDic.Add(country4.Code, country4);

                Session["CountriesData"] = countryDic;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, country> countryDic = (Dictionary<string, country>)Session["CountriesData"];
 
           

            string couCode = txtcode.Text.ToUpper();

            if (countryDic.ContainsKey(couCode))
            {
                country obj = countryDic[couCode];
                Label1.Text = "";
                txtname.Text = obj.Name;
                txtcapital.Text = obj.Capital;
            }
            else
            {
                Label1.Text = "code is not valid";
                txtname.Text = "";
                txtcapital.Text = "";
            }

            


        }
    }
}