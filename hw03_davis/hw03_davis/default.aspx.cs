using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace hw03_davis
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (event1 != null)
                {
                    for (int i = 0; i < event1.seatNumbers.Count(); i++)
                    {
                        lbxAvailableSeats.Items.Add(new ListItem(event1.seatNumbers[i].ToString(), event1.seatNumbers[i].ToString()));
                        lblSeatsAvailable.Text = event1.seatNumbers.Count().ToString();
                    }
                }
            }
        }

        public Event event1
        {
            get { return (Event)Session["Event"]; }
            set { Session["Event"] = value; }
        }

        protected void btnMakeEvent_Click(object sender, EventArgs e)
        {
            int first = int.Parse(tbxFirstSeat.Text);
            int last = int.Parse(tbxLastSeat.Text);

            event1 = new Event(tbxEventName.Text, first, last);

            for(int i = first; i <= last; i++)
            {
                lbxAvailableSeats.Items.Add(new ListItem(i.ToString(), i.ToString()));
                event1.seatNumbers.Add(i);
            }

            lblSeatsAvailable.Text = (last - first + 1).ToString();

            tbxEventName.Text = null;
            tbxFirstSeat.Text = null;
            tbxLastSeat.Text = null;

        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            int ticketNum = 0;
            foreach(ListItem li in lbxAvailableSeats.Items)
            {
                if (li.Selected)
                {
                    ticketNum = int.Parse(li.Value);
                    li.Enabled = false;
                    for(int i = 0; i < event1.seatNumbers.Count(); i++)
                    {
                        if(int.Parse(li.Text) == event1.seatNumbers[i])
                        {
                            event1.seatNumbers.RemoveAt(i);
                        }
                    }
                }
            }

            Attendee temp = new Attendee(tbxTicketName.Text, ticketNum, int.Parse(tbxTicketAge.Text));
            event1.attendees.Add(temp);

            lblSeatsAvailable.Text = (int.Parse(lblSeatsAvailable.Text) - 1).ToString();

            tbxTicketName.Text = null;
            tbxTicketAge.Text = null;

        }

        protected void btnEventSummary_Click(object sender, EventArgs e)
        {
            Response.Redirect("summary.aspx");
        }

        protected void btnStartOver_Click(object sender, EventArgs e)
        {
            event1.attendees.Clear();
            lblSeatsAvailable.Text = "";
            lbxAvailableSeats.Items.Clear();
            event1 = null;
        }
    }
}