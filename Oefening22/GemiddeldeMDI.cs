using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening22
{
    public partial class GemiddeldeMDI : Form
    {
        public GemiddeldeMDI()
        {
            InitializeComponent();
        }

        private void btn_newbutton_Click(object sender, EventArgs e)
        {
            DialoogVenster dialoogVenster = new DialoogVenster();
            dialoogVenster.ShowDialog();

        }

        private void ToevoegenWaarde(double waarde)
        {
            listBox1.Items.Add(waarde);
        }

        private void Gemiddelde()
        {
            double totaal = 0; 

        }
    }
}
