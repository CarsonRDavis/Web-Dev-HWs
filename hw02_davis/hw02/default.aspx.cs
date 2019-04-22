using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hw02
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ListItem[] availableCourses = buildAvailableCourseList();
                lbxAvailableClasses.DataSource = availableCourses;
                lbxAvailableClasses.DataTextField = "Text";
                lbxAvailableClasses.DataValueField = "Value";
                lbxAvailableClasses.DataBind();
            }
        }

        private ListItem[] buildAvailableCourseList()
        {
            ListItem[] tempList = { new ListItem("CS 1301-4", "CS 1301-4"),
                                new ListItem("CS 1302-4", "CS 1302-4"),
                                new ListItem("CS 1303-4", "CS 1303-4"),
                                new ListItem("CS 2202-2", "CS 2202-2"),
                                new ListItem("CS 2224-2", "CS 2224-2"),
                                new ListItem("CS 3300-3", "CS 3300-3"),
                                new ListItem("CS 3301-1", "CS 3301-1"),
                                new ListItem("CS 3302-1", "CS 3302-1"),
                                new ListItem("CS 3340-3", "CS 3340-3"),
                                new ListItem("CS 4321-3", "CS 4321-3"),
                                new ListItem("CS 4322-3", "CS 4322-3")
                              };
            return tempList;
        }

        protected void btnAdd_Click1(object sender, EventArgs e)
        {
            foreach(ListItem li in lbxAvailableClasses.Items)
            {
                if (li.Selected)
                {
                    if (OverHours(li))
                    {
                        lblError1.Text = "Cannot register for more than 19 hours.";
                    }
                    else
                    {
                        lbxRegisteredClasses.Items.Add(li);
                        lblError1.Text = "";
                    }
                }
            }

            for(int i = lbxAvailableClasses.Items.Count - 1; i >= 0; i--)
            {
                foreach(ListItem li in lbxRegisteredClasses.Items)
                {
                    if (li.Equals(lbxAvailableClasses.Items[i]))
                    {
                        lbxAvailableClasses.Items.RemoveAt(i);
                    }
                }
            }

            double hours = HoursRegisteredFor();
            lblHours.Text = hours.ToString();
            lblCost.Text = "$" + ((hours * 100) + ExtraOptions());
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in lbxRegisteredClasses.Items)
            {
                if (li.Selected)
                {
                    lbxAvailableClasses.Items.Add(li);
                }
            }
            for (int i = lbxRegisteredClasses.Items.Count - 1; i >= 0; i--)
            {
                ListItem li = lbxRegisteredClasses.Items[i];
                if (li.Selected)
                {
                    lbxRegisteredClasses.Items.Remove(li);
                    lblError1.Text = "";
                }
            }

            double hours = HoursRegisteredFor();
            lblHours.Text = hours.ToString();
            lblCost.Text = "$" + ((hours * 100) + ExtraOptions());
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = lbxAvailableClasses.Items.Count - 1; i >= 0; i--)
            {
                ListItem li = lbxAvailableClasses.Items[i];
                lbxAvailableClasses.Items.Remove(li);
            }

            for (int i = lbxRegisteredClasses.Items.Count - 1; i >= 0; i--)
            {
                ListItem li = lbxRegisteredClasses.Items[i];
                lbxRegisteredClasses.Items.Remove(li);
            }

            ListItem[] availableCourses = buildAvailableCourseList();
            lbxAvailableClasses.DataSource = availableCourses;
            lbxAvailableClasses.DataTextField = "Text";
            lbxAvailableClasses.DataValueField = "Value";
            lbxAvailableClasses.DataBind();

            lblHours.Text = "";
            lblCost.Text = "";

            foreach (ListItem li in cblExtras.Items)
            {
                if (li.Selected)
                {
                    li.Selected = false;
                }
            }

            lblError1.Text = "";
            lblError2.Text = "";

            tbxClassNumber.Text = "";
            tbxCredits.Text = "";

        }

        protected int HoursRegisteredFor()
        {
            int hours = 0;

            foreach(ListItem li in lbxRegisteredClasses.Items)
            {
                string temp = li.Text;
                string[] hoursTemp = temp.Split('-');
                hours += int.Parse(hoursTemp[1]);
            }

            return hours;
        }

        protected int ExtraOptions()
        {
            int total = 0;

            foreach(ListItem li in cblExtras.Items)
            {
                if (li.Selected)
                {
                    total += int.Parse(li.Value);
                }
            }

            return total;
        }

        protected void btnMakeAvailable_Click(object sender, EventArgs e)
        {
            string newClass = tbxClassNumber.Text + "-" + tbxCredits.Text;

            string tempInput = tbxClassNumber.Text;

            if (tbxCredits.Text.Equals(""))
            {
                lblError2.Text = "Enter a value for credits";
                return;
            }

            foreach(ListItem li in lbxAvailableClasses.Items)
            {
                string temp = li.ToString();
                string className = temp.Substring(0, 7);
                if(className.Equals(tempInput))
                {
                    lblError2.Text = "Not added. Course already added.";
                    return;
                }
            }

            foreach (ListItem li in lbxRegisteredClasses.Items)
            {
                string temp = li.ToString();
                string className = temp.Substring(0, 7);
                if (className.Equals(tempInput))
                {
                    lblError2.Text = "Not added. Course already exists.";
                    return;
                }
            }
            
            lbxAvailableClasses.Items.Add(new ListItem(newClass, newClass));
            lblError2.Text = "";
        }

        protected void btnRemoveAvailable_Click(object sender, EventArgs e)
        {
            string temp = tbxClassNumber.Text;

            for(int i = lbxAvailableClasses.Items.Count - 1; i >=0; i--)
            {
                String tempClass = lbxAvailableClasses.Items[i].ToString();
                String tempClassName = tempClass.Substring(0, 7);
                if (tempClassName.Equals(temp))
                {
                    lbxAvailableClasses.Items.RemoveAt(i);
                    return;
                }
            }

            foreach(ListItem li in lbxRegisteredClasses.Items)
            {
                String tempClass1 = li.ToString();
                String tempClassName1 = tempClass1.Substring(0, 7);
                if (tempClassName1.Equals(temp))
                {
                    lblError2.Text = "Not removed. Course is registered for.";
                    return;
                }
            }

            lblError2.Text = "Course not found";
        }

        protected Boolean OverHours(ListItem li)
        {
            Boolean over = false;
            int hours = 0;

            string value1 = li.ToString().Substring(8);
            int temp = int.Parse(value1);

            foreach(ListItem li1 in lbxRegisteredClasses.Items)
            {
                string value = li1.ToString().Substring(8);
                hours += int.Parse(value);
            }

            if((hours + temp) > 19)
            {
                over = true;
            }

            return over;
        }
    }
}