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
    public partial class DialoogVenster : Form
    {
        private string waarde { get; set; }
        public DialoogVenster()
        {
            InitializeComponent();
        }

        private void tb_value_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            waarde = tb_value.Text;

        }
    }
}
