using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelPlanner
{
    public partial class Travel : Form
    {
        public Travel()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblStart.Text = Program.journeys[JourneysTable.i].StartingPoint;
            lblDest.Text = Program.journeys[JourneysTable.i].Destination;
            lblAcc.Text = Program.journeys[JourneysTable.i].Accomodation;
            lblBudg.Text = Program.journeys[JourneysTable.i].Budget.ToString();
            lblFrom.Text = Program.journeys[JourneysTable.i].From;
            lblTo.Text = Program.journeys[JourneysTable.i].To;
            
            foreach (string item in Program.journeys[JourneysTable.i].ToPack)
            {
                clbPacking.Items.Add(item);
            }
            foreach (string place in Program.journeys[JourneysTable.i].ToVisit)
            {
                clbVisit.Items.Add(place);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clbPacking.Items.Clear();
            clbVisit.Items.Clear();
            JourneysTable form1 = new JourneysTable();
            this.Hide();
            form1.Show();
            
        }

        
    }
}
