namespace omron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hlpbtn_Click(object sender, EventArgs e)
        {

        }

        private bool isClicked = false;
        private void darkbtn_Click(object sender, EventArgs e)
        {

            if (isClicked)
            {
                this.BackColor = Color.White;
                darkbtn.Text = "Dark Mode";
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                isClicked = false;
                
            }
            else
            {
                this.BackColor = Color.FromArgb(64, 66, 88);
                darkbtn.Text = "Light Mode";
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                isClicked = true;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}