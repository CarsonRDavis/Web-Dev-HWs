using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw05 {
	public partial class Patients3 : System.Web.UI.Page {
		string dbType = "Access_Patients";

		protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                fillDDL(dbType);
            }
		}
		protected void ddPatients_SelectedIndexChanged(object sender, EventArgs e) {
            getSelectedPatient(dbType);
		}

        private void fillDDL(string dbType)
        {
            ddPatients.Items.Insert(0, new ListItem("--Select Patient--", "Ignore"));
            IDbCommand cmd = ConnectionFactory.GetCommand(dbType);
            cmd.CommandText = getDDSQL();
            try
            {
                cmd.Connection.Open();
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String lastName = dr.GetString(0);
                    String id = dr.GetInt32(1).ToString();

                    ddPatients.Items.Add(new ListItem(lastName, id));
                }
                dr.Close();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                txtVisitAndPreCharges.Text = ex.ToString();
            }
        }

        private String getFullSQL()
        {
            String sql =
                "SELECT " +
                    "Visits.VisitDate, " +
                    "Visits.Charge, " +
                    "Visits.PatientID " +
                "FROM " +
                    "Visits " +
                "ORDER BY " +
                    "Visits.VisitDate Asc";
            return sql;
        }

        private String getDDSQL()
        {
            String sql = 
                    "SELECT " +
                        "Patients.LastName, " +
                        "Patients.PatientID " +
                    "FROM " +
                        "Patients";

            return sql;
        }

        private void getSelectedPatient(String dbType)
        {
            String person = "";

            IDbCommand cmd = ConnectionFactory.GetCommand(dbType);
            cmd.CommandText = getFullSQL();
            try
            {
                cmd.Connection.Open();
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String date = dr.GetDateTime(0).ToString();
                    String charge = "$" + dr.GetDecimal(1).ToString() + ".00";
                    int id = dr.GetInt32(2);
                    if(Int32.Parse(ddPatients.SelectedValue) == id)
                    {
                        person += date + "\t" + charge + "\n";
                    }
                }
                dr.Close();
                cmd.Connection.Close();
            }
            catch (Exception ex)
            {
                txtVisitAndPreCharges.Text = ex.ToString();
                return;
            }

            txtVisitAndPreCharges.Text = person;
        }

	}
}