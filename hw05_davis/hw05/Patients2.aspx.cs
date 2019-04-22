using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw05 {
	public partial class Patients2 : System.Web.UI.Page {
		string dbType = "Access_Patients";

		protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                displayData(dbType);
            }
		}

        private void displayData(string dbType)
        {
            IDbCommand cmd = ConnectionFactory.GetCommand(dbType);
            cmd.CommandText = getSQL();
            try
            {
                cmd.Connection.Open();
                IDataReader dr = cmd.ExecuteReader();
                txtPatientsAboveAvg.Text = "";
                while (dr.Read())
                {
                    String visitDate= dr.GetDateTime(0).ToString();
                    String lastName = dr.GetString(1);
                    String charge = dr.GetDecimal(2).ToString() + ".00";

                    String patient = String.Format("{0,2:0} \t {1,-10:0} \t ${2,-8:0}", visitDate, lastName, charge);
                    txtPatientsAboveAvg.Text += patient + Environment.NewLine;
                }

                dr.Close();
                cmd.Connection.Close();
            }
            catch(Exception ex)
            {
                txtPatientsAboveAvg.Text = ex.ToString();
            }
        }

        private String getSQL()
        {
            String sql =
                "SELECT " +
                    "Visits.VisitDate, " +
                    "Patients.LastName, " +
                    "Visits.Charge " +
                "FROM " +
                    "Visits " +
                "INNER JOIN " +
                    "Patients ON Visits.PatientID=Patients.PatientID " +
                "ORDER BY " +
                    "Visits.VisitDate Asc";
            return sql;
        }
	}
}