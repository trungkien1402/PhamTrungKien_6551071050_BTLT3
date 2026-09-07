namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.DoubleClick += label3_DoubleClick;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label3_DoubleClick(object? sender, EventArgs e)
        {
            label3.Text = "";
        }
    }
}
