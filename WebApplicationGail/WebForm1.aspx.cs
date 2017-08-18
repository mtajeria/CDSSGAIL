using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using WebServiceGail;

namespace WebApplicationGail
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList5.SelectedValue  != "0")
            {
                DropDownList6.Enabled = true;
            }
            else
            {
                DropDownList6.Enabled = false;
                DropDownList6.Text = "No";
            }
        }
     

        protected void Button1_Click(object sender, EventArgs e)
        {

            GailService.GailModelSoapClient client = new GailService.GailModelSoapClient();
            WebServiceGail.Communication com = new WebServiceGail.Communication();
            
            //Lectura de entrada

            com.readVariables(DropDownList2.Text, DropDownList3.Text, DropDownList4.Text, DropDownList5.Text,
                DropDownList1.Text, DropDownList6.Text);


            // Procesamiento

            double relrisk2 = client.CalculateRR(com.agecat, com.agemen, com.ageflb, com.nbiops, com.numrel,
                com.ah);
            double relrisk3 = client.CalculateRR(Convert.ToString(int.Parse(com.agecat) + 5), com.agemen,
                com.ageflb, com.nbiops, com.numrel, com.ah);   
                     
            double a = Convert.ToDouble(com.agecat);            
            double prob2 = client.CalculateProbability(a, relrisk2, relrisk3 );


            // Salida

            com.setOutput(prob2);

            Lblmsg.Text = com.msg;
            Lblresult.Text = com.output;

        }

    }
}