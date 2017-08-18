using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Diagnostics;

namespace WebServiceGail
{
    /// <summary>
    /// Summary description for GailModel
    /// </summary>
    [WebService(Namespace = "http://cdssgailmodel.com/webservice")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GailModel : System.Web.Services.WebService
    {

        [WebMethod]
        public double CalcPorb(double RR, int agecat)
        {






            int i = 0;
            double firstage = 25;
            double[] ageinterval = new double[13];
            for (i = 0; i < 13; i++)
            {
                ageinterval[i] = (double)firstage + 5 * i;
            }

            double[] baseline = new double[13];
            baseline[0] = 0.012;
            baseline[1] = 0.049;
            baseline[2] = 0.134;
            baseline[3] = 0.278;
            baseline[4] = 0.450;
            baseline[5] = 0.584;
            baseline[6] = 0.703;
            baseline[7] = 0.859;
            baseline[8] = 1.018;
            baseline[9] = 1.116;
            baseline[10] = 1.157;
            baseline[11] = 1.140;
            baseline[12] = 1.006;

            int j = 0;
            while (agecat >= ageinterval[j])
            {
                j = j + 1;
            }

            return RR * baseline[j];
        }

        [WebMethod]
        public double CalculateProbability(double a, double tau, double r1 , double r2)
        {

            double[] r = new double[2];
            r[0] = Math.Log(r1);
            r[1] = Math.Log(r2);


            double[] ho1 = new double[14];
            ho1[0] = 1.0 * 0.00001;        // [20:25) 
            ho1[1] = 7.6 * 0.00001;        // [25:30) 
            ho1[2] = 26.6 * 0.00001;        // [30:35) 
            ho1[3] = 66.1 * 0.00001;        // [35:40) 
            ho1[4] = 126.5 * 0.00001;        // [40:45) 
            ho1[5] = 186.6 * 0.00001;        // [45:50) 
            ho1[6] = 221.1 * 0.00001;        // [50:55) 
            ho1[7] = 272.1 * 0.00001;        //[55:60) 
            ho1[8] = 334.8 * 0.00001;         
            ho1[9] = 392.3 * 0.00001;         
            ho1[10] = 417.8 * 0.00001;         
            ho1[11] = 443.9 * 0.00001;         
            ho1[12] = 442.1 * 0.00001;         
            ho1[13] = 410.9 * 0.00001;         

            double F = 0.5788; // para todas las edades

            double[] h1 = new double[14];
            for (int i = 0; i < 14; i++)
            {
                h1[i] = F * ho1[i];
            }

            double[] h2 = new double[14];
            h2[0] = 49.3 * 0.00001;        // [20:25) 
            h2[1] = 53.1 * 0.00001;        // [25:30) 
            h2[2] = 62.5 * 0.00001;        // [30:35) 
            h2[3] = 82.5 * 0.00001;        // [35:40) 
            h2[4] = 130.7 * 0.00001;        // [40:45) 
            h2[5] = 218.1 * 0.00001;        // [45:50) 
            h2[6] = 365.5 * 0.00001;        // [50:55) 
            h2[7] = 585.2 * 0.00001;        // [55:60) 
            h2[8] = 943.9 * 0.00001;        // [60:65) 
            h2[9] = 1502.8 * 0.00001;        // [65:70) 
            h2[10] = 2383.9 * 0.00001;        // [70:75) 
            h2[11] = 3883.2 * 0.00001;        // [75:80) 
            h2[12] = 6682.8 * 0.00001;        // [80:85) 
            h2[13] = 14490.8 * 0.00001;        // [85:90) 


            int delta = 5;
            double firstage = 25;
            double[] ageinterval = new double[14];
            for (int i = 0; i < 14; i++)
            {
                ageinterval[i] = (double)firstage + delta * i;
                // Debug.WriteLine(ageinterval[i]);
            }
            
            int liminf = 0;     
            while (a > ageinterval[liminf])
            {
                liminf = liminf + 1;
            }
            liminf = liminf + 1;
            int limsup = liminf+1;

            Debug.WriteLine("Edad");
            Debug.WriteLine(a);
            Debug.WriteLine(ageinterval[liminf]);
            Debug.WriteLine(ageinterval[limsup]);

            double p,p2;
            
            p = 1.0 - Math.Exp(-(h1[liminf-1] * Math.Exp(r[0]) + h2[liminf-1]) * (ageinterval[liminf-1] - a));

            p = p * h1[liminf - 1] * Math.Exp(
                r[0]) / (h1[liminf - 1] * Math.Exp(r[0]) + h2[liminf - 1]);	/* age in */
            Debug.WriteLine("riesgo " + r[0]);
            Debug.WriteLine("/n Parametro P "+ p + "/n");
            //Debug.WriteLine(p);
            //Debug.WriteLine(h1[liminf -1]);
            //Debug.WriteLine("Riesgo Relativo" + r[0]);
            //Debug.WriteLine(r[0]);
            //Debug.WriteLine(h2[liminf -1]);
            //Debug.WriteLine(ageinterval[liminf-1]);
            //Debug.WriteLine(a);

            // Debug.WriteLine(r);
            // 
            
            p2 = 1.0 - Math.Exp(-(h1[limsup - 1] * Math.Exp(r[1])
                + h2[limsup - 1]) * ((a+tau) - ageinterval[limsup-2]));

            Debug.WriteLine("p2a " + p2);
            Debug.WriteLine("ECUACIÓN");
            Debug.WriteLine(Math.Exp(-(h1[limsup - 1] * Math.Exp(r[0])+ h2[limsup - 1])));
            Debug.WriteLine((a+tau) - ageinterval[limsup-2]);
            Debug.WriteLine("Parametros");
            Debug.WriteLine("-------------");
            Debug.WriteLine(h1[limsup - 1]);
            //Debug.WriteLine("Riesgo Relativo" + r[1]);
            Debug.WriteLine(r[0]);
            Debug.WriteLine(h2[limsup - 1]);
            Debug.WriteLine(ageinterval[limsup-2]);
            Debug.WriteLine(a+tau);


            p2 = p2 * h1[limsup - 1] * Math.Exp(r[1]) / (
                h1[limsup - 1] * Math.Exp(r[1]) + h2[limsup - 1]);
            Debug.WriteLine("-------------");
            Debug.WriteLine("p2b " + p2);
            Debug.WriteLine(h1[limsup - 1]);
            Debug.WriteLine(r[0]);
            Debug.WriteLine(h2[limsup - 1]);
                

            p2 *= Math.Exp(-(h1[liminf - 1] * Math.Exp(r[0]) +
                h2[liminf - 1]) * (ageinterval[liminf-1] - a));
            Debug.WriteLine("-------------");
            Debug.WriteLine("p2c " + p2);
            Debug.WriteLine(h1[liminf - 1]);
            Debug.WriteLine(r[0]);
            Debug.WriteLine(h2[limsup - 1]);
            Debug.WriteLine(ageinterval[liminf-1]);
            Debug.WriteLine(a);
                       
            return (p + p2) * 100;

        }

        [WebMethod]
        public double CalculateRelativeRisk(int agecat, int agemen, int ageflb, int nbiops, int numrel, int ah )
        {
            //Weighing the Risks and Benefits of Tamoxifen Treatment for Preventing Breast Cancer
            //Mitchell H. Gail, Joseph P. Costantino, John Bryant, Robert Croyle,
            //Laurence Freedman, Kathy Helzlsouer, Victor Vogel

            double rr1;
            double rr2;
            double rr3;
            double rr4;

            

            if (agemen >= 14)
            {
                rr1 = 1;
            }
            else if (agemen >= 12)
            {
                rr1 = 1.10;
            }

            else
            {
                rr1 = 1.21;
            }

            // Riesgo relativos por edad y número de biopsias

            if (agecat < 50)
            {
                if (nbiops == 0)
                {
                    rr2 = 1;
                }
                else if (nbiops == 1)
                {
                    rr2 = 1.70;
                }
                else
                {
                    rr2 = 2.88;
                }
            }
            else
            {
                if (nbiops == 0)
                {
                    rr2 = 1;
                }
                else if (nbiops == 1)
                {
                    rr2 = 1.27;
                }
                else
                {
                    rr2 = 1.62;
                }
            }

            if (ageflb < 20)
            {
                if (numrel == 0)
                {
                    rr3 = 1;
                }
                else if (numrel == 1)
                {
                    rr3 = 1;
                }
                else
                {
                    rr3 = 6.8;
                }
            }
            else if (ageflb <= 24)
            {
                if (numrel == 0)
                {
                    rr3 = 1.24;
                }
                else if (numrel == 1)
                {
                    rr3 = 2.68;
                }
                else
                {
                    rr3 = 5.78;
                }
            }
            else if (ageflb <= 29)
            {
                if (numrel == 0)
                {
                    rr3 = 1.55;
                }
                else if (numrel == 1)
                {
                    rr3 = 2.76;
                }
                else
                {
                    rr3 = 4.91;
                }
            }
            else
            {
                if (numrel == 0)
                {
                    rr3 = 1.93;
                }
                else if (numrel == 1)
                {
                    rr3 = 2.83;
                }
                else
                {
                    rr3 = 4.17;
                }
            }

            if (nbiops == 0)
            {
                rr4 = 1;
            }
            else
            {
                if (ah == 0)
                {
                    rr4 = 0.93;
                }
                else if (ah == 1)
                {
                    rr4 = 1.82;
                }
                else
                {
                    rr4 = 1;
                }
            }

            Debug.WriteLine(rr1);
            Debug.WriteLine(rr2);
            Debug.WriteLine(rr3);
            Debug.WriteLine(rr4);



            // Riesgo relativo asociado a edad de menarca
            //if (agemen >= 14)
            //{
            //    rr1 = 1;
            //}
            //else if (agemen >= 12){
            //    rr1 = 1.10;
            //}

            //else
            //{
            //    rr1 = 1.21;
            //}

            //// Riesgo relativos por edad y número de biopsias

            //if(agecat<50){
            //    if(nbiops == 0){
            //        rr2 = 1;
            //    }
            //    else if(nbiops == 1){
            //        rr2 = 1.70;
            //    }
            //    else{
            //        rr2 = 2.88;
            //    }
            //}
            //else{
            //    if(nbiops == 0){
            //        rr2 = 1;
            //    }
            //    else if(nbiops == 1){
            //        rr2 = 1.27;
            //    }
            //    else{
            //        rr2 = 1.62;
            //    }
            //}

            //if (ageflb < 20){
            //    if (numrel == 0){
            //        rr3 = 1;
            //    }
            //    else if (numrel == 1)
            //    {
            //        rr3 = 1;
            //    }
            //    else
            //    {
            //        rr3 = 6.8;
            //    }
            //}
            //else if(ageflb <= 24){
            //    if (numrel == 0){
            //        rr3 = 1.24;
            //    }
            //    else if (numrel == 1)
            //    {
            //        rr3 = 2.68;
            //    }
            //    else
            //    {
            //        rr3 = 5.78;
            //    }
            //}
            //else if(ageflb <= 29){
            //    if (numrel == 0){
            //        rr3 = 1.55;
            //    }
            //    else if (numrel == 1)
            //    {
            //        rr3 = 2.76;
            //    }
            //    else
            //    {
            //        rr3 = 4.91;
            //    }
            //}
            //else{
            //    if (numrel == 0){
            //        rr3 = 1.93;
            //    }
            //    else if (numrel == 1)
            //    {
            //        rr3 = 2.83;
            //    }
            //    else
            //    {
            //        rr3 = 4.17;
            //    }
            //}

            //if (nbiops == 0)
            //{
            //    rr4 = 1;
            //}
            //else{
            //    if (ah == 0)
            //    {
            //        rr4 = 0.93;
            //    }
            //    else if (ah == 1)
            //    {
            //        rr4 = 1.82;
            //    }
            //    else
            //    {
            //        rr4 = 1;
            //    }
            //}

            //Debug.WriteLine(rr1);
            //Debug.WriteLine(rr2);
            //Debug.WriteLine(rr3);
            //Debug.WriteLine(rr4);

            return rr1*rr2*rr3*rr4;
            
        }

        [WebMethod]
        public double ReadForm(string agecat, string agemen, string ageflb, string nbiops, string numrel, string ah)
        {

            double rr1;
            double rr2;
            double rr3;
            double rr4;

            int age = int.Parse(agecat);
            Debug.WriteLine(age);

            if (agemen == "7 a 11")
            {
                rr1 = 1.207;
            }
            else if (agemen == "12 a 13")
            {
                rr1 = 1.099;
            }
            else
            {
                rr1 = 1;
            }

            // Riesgo relativos por edad y número de biopsias

            if (age <= 50)
            {
                if (nbiops == "0")
                {
                    rr2 = 1;
                }
                else if (nbiops == "1")
                {
                    rr2 = 1.698;
                }
                else
                {
                    rr2 = 2.882;
                }
            }
            else
            {
                Debug.WriteLine("Mayor a 50 **********");
                if (nbiops == "0")
                {
                    rr2 = 1;
                }
                else if (nbiops == "1")
                {
                    rr2 = 1.273;
                }
                else
                {
                    rr2 = 1.62;
                }
            }

            if (ageflb == "Menor a 20")
            {
                if (numrel == "0")
                {
                    rr3 = 1;
                }
                else if (numrel == "1")
                {
                    rr3 = 2.607;
                }
                else
                {
                    rr3 = 6.798;
                }
            }
            else if (ageflb == "De 20 a 24")
            {
                if (numrel == "0")
                {
                    rr3 = 1.244;
                }
                else if (numrel == "1")
                {
                    rr3 = 2.681;
                }
                else
                {
                    rr3 = 5.775;
                }
            }
            else if (ageflb == "De 25 a 29")
            {
                if (numrel == "0")
                {
                    rr3 = 1.548;
                }
                else if (numrel == "1")
                {
                    rr3 = 2.756;
                }
                else
                {
                    rr3 = 4.907;
                }
            }
            else if (ageflb == "Sin partos")
            {
                if (numrel == "0")
                {
                    rr3 = 1.548;
                }
                else if (numrel == "1")
                {
                    rr3 = 2.756;
                }
                else
                {
                    rr3 = 4.907;
                }
            }
            else
            {
                if (numrel == "0")
                {
                    rr3 = 1.927;
                }
                else if (numrel == "1")
                {
                    rr3 = 2.834;
                }
                else
                {
                    rr3 = 4.169;
                }
            }

            if (nbiops == "0")
            {
                rr4 = 1;
            }
            else
            {
                if (ah == "No")
                {
                    rr4 = 0.93;
                }
                else if (ah == "Sí")
                {
                    rr4 = 1.82;
                }
                else
                {
                    rr4 = 1;
                }
            }

            Debug.WriteLine("rr1 " + rr1);
            Debug.WriteLine("rr2 " + rr2);
            Debug.WriteLine("rr3 " + rr3);
            Debug.WriteLine("rr4 " + rr4);

            return rr1 * rr2 * rr3 * rr4;
        }
           
       
          
    }
}
