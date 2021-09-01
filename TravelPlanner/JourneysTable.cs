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
   [Serializable]
    public partial class JourneysTable : Form
    {
        public static int i;
        public JourneysTable()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Program.Deserialize();
            foreach(Journey j in Program.journeys)
            {
                lbJourneys.Items.Add(j.StartingPoint + "-" + j.Destination + ", " + j.From + "-" + j.To);
            }
            lbJourneys.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Start form1 = new Start();
            this.Hide();
            form1.Show();
        }

        private void lbJourneys_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = lbJourneys.SelectedIndex;
            Travel form3 = new Travel();
            this.Hide();
            form3.Show();
           
        }

        
    }
}
