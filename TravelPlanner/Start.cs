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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NewJourney form2 = new NewJourney();
            this.Hide();
            form2.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            JourneysTable form4 = new JourneysTable();
            this.Hide();
            form4.Show();
        }

        

        
    }
}
