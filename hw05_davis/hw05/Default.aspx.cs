using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace hw05 {
	public partial class Default : System.Web.UI.Page {
		string dbType = "Access_Property";
        List<Property> properties;

		protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack)
            {
                displayData();
            }
		}
		protected void rblSortType_SelectedIndexChanged(object sender, EventArgs e) {
            displayData();
		}

        protected void displayData()
        {
            IDbCommand cmd = hw05.ConnectionFactory.GetCommand(dbType);
            cmd.CommandText = getSelectSQL();
            try
            {
                cmd.Connection.Open();
                IDataReader dr = cmd.ExecuteReader();
                properties = createList(dr);
                txtProperties.Text = printProperties(properties);
                dr.Close();
                calculations(properties);
                cmd.Connection.Close();    
            }
            catch (Exception ex)
            {
                txtMsg.Text = ex.ToString();
            }
        }

        private String getSelectSQL()
        {
            string sql =
                "SELECT " +
                    "Properties.ListPrice, " +
                    "Properties.SqFeet, " +
                    "Properties.Beds, " +
                    "Properties.Baths, " +
                    "Properties.YearBuilt " +
                "FROM " +
                    "Properties " +
                "ORDER BY " +
                    "Properties.ListPrice Asc";

            return sql;
        }

        private List<Property> createList(IDataReader dr)
        {
            List<Property> temp = new List<Property>();

            while (dr.Read())
            {
                double price = dr.GetDouble(0);
                double sqFeet = dr.GetDouble(1);
                double beds = dr.GetDouble(2);
                double baths = dr.GetDouble(3);
                double year = dr.GetDouble(4);
                Property tempProp = new Property(price, sqFeet, beds, baths, year);
                temp.Add(tempProp);
            }

            return temp;
        }

        private string printProperties(List<Property> properties)
        {
            string msg = "";

            if(rblSortType.SelectedValue == "Price")
            {
                properties = properties.OrderBy(i => i.ListPrice).ToList();
            }
            else
            {
                properties = properties.OrderBy(i => i.SqFeet).ToList();
            }

            foreach(Property pr in properties)
            {
                msg += pr.toString();
            }

            return msg;
        }

        private void calculations(List<Property> properties)
        {
            int count = 0;
            double allPrices = 0;
            double avgPrice = 0;
            int numAboveAvg = 0;
            foreach(Property pr in properties)
            {
                count++;
                allPrices += pr.ListPrice;
            }
            avgPrice = allPrices / count;
            foreach(Property pr in properties)
            {
                if(pr.ListPrice >= avgPrice)
                {
                    numAboveAvg++;
                }
            }
            lblNumProperties.Text = count.ToString();
            lblAveragePrice.Text = $"{avgPrice:C}";
            lblNumAboveAvgPrice.Text = numAboveAvg.ToString();
        }
	}
}