namespace Oefening22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChildMDI_Click(object sender, EventArgs e)
        {
            GemiddeldeMDI newMDIChild = new GemiddeldeMDI();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            btn_ChildMDI.Visible = false;

        }
    }
}