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
    
    public partial class NewJourney : Form
    {
        public static string start = "";
        public static string destination = "";
        public static string accomodation = "";
        public static float budget;
        public static string from = "";
        public static string to = "";
        public static List<string> packing = new List<string>();
        public static List<string> visiting = new List<string>();
        public NewJourney()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            start = tbStartingPoint.Text;
            destination = tbDestination.Text;
            accomodation = tbAccomodation.Text;
            budget = float.Parse(tbTransport.Text) + float.Parse(tbAccCost.Text) + float.Parse(tbPocketMoney.Text);
            from = calDate.SelectionRange.Start.ToShortDateString();
            to = calDate.SelectionRange.End.ToShortDateString();

            
                Journey j = new Journey(start, destination, accomodation, budget, from, to);
                foreach (string i in packing)
                {
                    j.AddItem(i);
                }
                packing.Clear();
                foreach (string i in visiting)
                {
                    j.AddPlace(i);
                }
                visiting.Clear();
               
                Program.journeys.Add(j);

                Start form1 = new Start();
                this.Hide();
                form1.Show();
            Program.Serialize();



        }

        private void btnNewPackItem_Click(object sender, EventArgs e)
        {
            string item = tbPackingItem.Text;
            packing.Add(item);
            tbPackingItem.Text = "";
        }

        private void btnAddSight_Click(object sender, EventArgs e)
        {
            string sight = tbNewSight.Text;
            visiting.Add(sight);
            tbNewSight.Text = "";
        }
    }
}
