using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;


namespace WebApplicationGail
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            GailService.GailModelSoapClient client = new GailService.GailModelSoapClient();
            
            //Lectura de entrada
            string agecat = DropDownList2.Text;
            string agemen = DropDownList3.Text;
            string ageflb = DropDownList4.Text;
            string nbiops = DropDownList5.Text;
            string numrel = DropDownList1.Text; 
            string ah     = DropDownList6.Text;


            double relrisk2 = client.ReadForm(agecat, agemen, ageflb, nbiops, numrel, ah);
            double relrisk3 = client.ReadForm(Convert.ToString(int.Parse(agecat) + 5), agemen, ageflb, nbiops, numrel, ah);
               
                     
            double a = Convert.ToDouble(agecat);
            
            double prob2 = client.CalculateProbability(a, 5.0, relrisk2, relrisk3 );
            
            // Salida 
            string str = "";
            Lblmsg.Text = str;
            //Image1.Visible = false;
            if (Math.Round(prob2, 2) >= 1.67)
            {
                str = " ADVERTENCIA: La paciente es de alto riesgo. Se recomienda interconsulta con especialista. ";
                //str =str.Replace("\n", Environment.NewLine);
                Lblmsg.Text = str;
                //Image1.Visible = true;
            }
            
            Lblresult.Text = Math.Round(prob2, 2).ToString() + " %" ;

        }



    }
}