using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    public partial class GemiddeldeMDI : Form
    {
        public GemiddeldeMDI()
        {
            InitializeComponent();
        }

        private void btn_NewValue_Click(object sender, EventArgs e)
        {
            DialoogVenster dialoogVenster = new DialoogVenster();
            dialoogVenster.ShowDialog();
            double waarde = double.Parse(dialoogVenster.waarde);
            ToevoegenWaarde(waarde);
            Gemiddelde();

        }

        private void ToevoegenWaarde(double waarde)
        {
            listBox_Values.Items.Add(waarde);
        }

        private void Gemiddelde()
        {
            double totaal = 0;
            int lengte = listBox_Values.Items.Count;
            double gemiddelde;
            for(int i = 0; i < lengte; i++)
            {
                totaal += double.Parse(listBox_Values.Items[i].ToString());
                
            }
            gemiddelde = totaal / lengte;
            tb_Gemiddelde.Text = gemiddelde.ToString();

        }
    }
}
