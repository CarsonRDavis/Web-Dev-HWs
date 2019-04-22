using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw04_davis
{
    public partial class information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            doMath();
        }

        void doMath()
        {
            string equation = Request.QueryString["q"].ToString();
            string[] components = equation.Split(' ');
            string msg = "";
            double answer;

            switch (components[1])
            {
                case "a":
                    answer = double.Parse(components[0]) + double.Parse(components[2]);
                    msg = components[0] + " + " + components[2] + " = " + answer.ToString();
                    break;
                case "s":
                    answer = double.Parse(components[0]) - double.Parse(components[2]);
                    msg = components[0] + " - " + components[2] + " = " + answer.ToString();
                    break;
                case "d":
                    answer = double.Parse(components[0]) / double.Parse(components[2]);
                    msg = components[0] + " / " + components[2] + " = " + answer.ToString();
                    break;
                case "m":
                    answer = double.Parse(components[0]) * double.Parse(components[2]);
                    msg = components[0] + " * " + components[2] + " = " + answer.ToString();
                    break;
                default:
                    msg = "Please use a, s ,d or m to solve an equation.";
                    break;
            }

            Response.Write(msg);
            Response.End();
        }
    }
}