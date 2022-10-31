namespace Oefening2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_childmdi_Click(object sender, EventArgs e)
        {
            GemiddeldeMDI newMDIChild = new GemiddeldeMDI();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            btn_childmdi.Visible = false;
        }
    }
}