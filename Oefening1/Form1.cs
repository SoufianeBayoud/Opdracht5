namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void redCTRLRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;

        }

        private void blueCtrlBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void smallCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Segou UI", 6);
        }

        private void normalCtrlNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Segou UI", 10);
        }

        private void largeCtrlLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Segou UI", 20);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}