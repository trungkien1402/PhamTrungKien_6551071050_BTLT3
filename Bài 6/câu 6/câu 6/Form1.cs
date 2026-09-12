namespace câu_6
{
    public partial class Form1 : Form
    {
        public object MessageBoxDefaulButton { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            radRed.Checked = true;
            chkVisble.Checked = true;

            picBig.Location = picSmall.Location;
            picBig.Visible = true;
            picSmall.Visible = false;

            toolTip1.SetToolTip(picBig, "Click Me");
            toolTip2.SetToolTip(picSmall, "Click Me");

            this.AcceptButton = btnDisplay;
            this.CancelButton = btnExit;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked)
            {
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked)
            {
                lblMessage.ForeColor = Color.Green;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked)
            {
                lblMessage.ForeColor = Color.Blue;
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked)
            {
                lblMessage.ForeColor = Color.Black;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            lblMessage.Visible = chkVisble.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            picSmall.Visible = false;
            picBig.Visible = true;
        }
        private void picBig_Click(object sender, EventArgs e)
        {
            picBig.Visible = false;
            picSmall.Visible = true;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = txtName.Text + ":" + txtMessage.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
            txtName.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void frmDinhDang(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show(
                "Có chắc bạn muốn đóng ứng dụng?",
                "Thông báo!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
             );

            if (dl == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
