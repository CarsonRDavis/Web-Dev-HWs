using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace hw03_davis
{
    public partial class summary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (event1 == null)
                {
                    tbxDisplay.Text = "No Events";
                }
                else
                {
                    printTicketHolders();
                    ddlAttendees.DataSource = event1.attendees;
                    ddlAttendees.DataTextField = "Name";
                    ddlAttendees.DataValueField = "seatNumber";
                    ddlAttendees.DataBind();
                    ddlAttendees.Items.Insert(0, new ListItem("--Select Attendee--", "Ignore"));
                    lblEventName.Text = event1.name;
                }
            }
        }

        public Event event1
        {
            get { return (Event)Session["Event"]; }
            set { Session["Event"] = value; }
        }

        public void printTicketHolders()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("Name\t\t" + "Seat\t" + "Age\t" + "Price" + Environment.NewLine);
            builder.Append("-----------------------------------------" + Environment.NewLine);

            if (int.Parse(rblSort.SelectedValue) == 0)
            {
                builder.Append(purchaseOrderSort());
            }
            else if (int.Parse(rblSort.SelectedValue) == 1)
            {
                builder.Append(nameSort());
            }
            else
            {
                builder.Append(seatNumberSort());
            }

            tbxDisplay.Text = builder.ToString();
        }

        protected void btnPurchaseTickets_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        public string availableSeats()
        {
            string msg = "";

            for (int i = 0; i < event1.seatNumbers.Count(); i++)
            {
                msg += event1.seatNumbers[i].ToString() + ", ";
            }

            return msg;
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            int seatNum = int.Parse(ddlAttendees.SelectedValue);
            Attendee a = event1.attendees.Find(x => x.seatNumber == seatNum);
            event1.seatNumbers.Add(a.seatNumber);
            event1.attendees.Remove(a);

            printTicketHolders();
            ddlAttendees.DataSource = event1.attendees;
            ddlAttendees.DataTextField = "Name";
            ddlAttendees.DataValueField = "seatNumber";
            ddlAttendees.DataBind();
            ddlAttendees.Items.Insert(0, new ListItem("--Select Attendee--", "Ignore"));
            lblEventName.Text = event1.name;
        }

        protected StringBuilder purchaseOrderSort()
        {
            StringBuilder builder = new StringBuilder();

            int count = 0;
            double price = 0;
            double average = 0;

            foreach (Attendee a in event1.attendees)
            {
                builder.Append(a.toString());
                count++;
                price += a.ticketPrice;
                average = price / count;
            }

            builder.Append("-----------------------------------------" + Environment.NewLine);
            builder.Append("Tickets sold: " + count + Environment.NewLine);
            builder.Append("Tickets Available: " + (event1.lastSeat - event1.firstSeat - count + 1).ToString() + Environment.NewLine);
            builder.Append("Total Ticket Prices: " + $"{price:C}" + Environment.NewLine);
            builder.Append("Average Ticket Prices: " + $"{average:C}" + Environment.NewLine);
            builder.Append("Available Seats: " + availableSeats() + Environment.NewLine);

            return builder;
        }

        protected StringBuilder nameSort()
        {
            StringBuilder builder = new StringBuilder();

            int count = 0;
            double price = 0;
            double average = 0;

            List<Attendee> temp = event1.attendees;

            temp = temp.OrderBy(i => i.name).ToList();

            foreach (Attendee a in temp)
            {
                builder.Append(a.toString());
                count++;
                price += a.ticketPrice;
                average = price / count;
            }

            builder.Append("-----------------------------------------" + Environment.NewLine);
            builder.Append("Tickets sold: " + count + Environment.NewLine);
            builder.Append("Tickets Available: " + (event1.lastSeat - event1.firstSeat - count + 1).ToString() + Environment.NewLine);
            builder.Append("Total Ticket Prices: " + $"{price:C}" + Environment.NewLine);
            builder.Append("Average Ticket Prices: " + $"{average:C}" + Environment.NewLine);
            builder.Append("Available Seats: " + availableSeats() + Environment.NewLine);

            return builder;
        }

        protected StringBuilder seatNumberSort()
        {
            StringBuilder builder = new StringBuilder();

            int count = 0;
            double price = 0;
            double average = 0;

            List<Attendee> temp = event1.attendees;

            temp = temp.OrderBy(i => i.seatNumber).ToList();

            foreach (Attendee a in temp)
            {
                builder.Append(a.toString());
                count++;
                price += a.ticketPrice;
                average = price / count;
            }

            builder.Append("-----------------------------------------" + Environment.NewLine);
            builder.Append("Tickets sold: " + count + Environment.NewLine);
            builder.Append("Tickets Available: " + (event1.lastSeat - event1.firstSeat - count + 1).ToString() + Environment.NewLine);
            builder.Append("Total Ticket Prices: " + $"{price:C}" + Environment.NewLine);
            builder.Append("Average Ticket Prices: " + $"{average:C}" + Environment.NewLine);
            builder.Append("Available Seats: " + availableSeats() + Environment.NewLine);

            return builder;
        }

        protected void rblSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            printTicketHolders();
        }
    }
}