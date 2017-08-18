using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebServiceGail
{
    public class Communication
    {
        public string agecat;
        public string agemen;
        public string ageflb;
        public string nbiops;
        public string numrel;
        public string ah;
        public string output;
        public string msg;

        public Communication()
        {
            output = "";
            msg = "";
        }

        public void readVariables(string a, string b, string c, string d, string e, string f)
        {
            agecat = a;
            agemen = b;
            ageflb = c;
            nbiops = d;
            numrel = e;
            ah = f;

        }

        public void setOutput(double prob2){
         
            prob2 = Math.Round(prob2, 2);
            //Image1.Visible = false;
            if ( prob2 >= 1.67)
            {
                msg = " ADVERTENCIA: La paciente es de alto riesgo. Se recomienda interconsulta con especialista. ";
                //str =str.Replace("\n", Environment.NewLine);
                
                //Image1.Visible = true;
            }

            output = prob2.ToString() + " %";
        }

    }
}