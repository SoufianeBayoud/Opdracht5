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
    public partial class DialoogVenster : Form
    {
        public string waarde { get; set; }

        public DialoogVenster()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            waarde = tb_InputValue.Text;
        }

        private void tb_InputValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
