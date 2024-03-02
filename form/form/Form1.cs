namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Brown;
            button3.BackColor = Color.Brown;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Gold;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
