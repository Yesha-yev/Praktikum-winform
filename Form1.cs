namespace Praktikum_winform
{
    public partial class Form1 : Form
    {
        private string Username;
        private string Admin = "Fia";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        { 
            //labelatas.Text = textBox1.Text;
            Username = textBox1.Text;
            labelatas.Text = Username;

            if (textBox1.Text.Length <= 0)
            {
                textBox1.Text = "Salah Username mu KOCAK!!";
            }
            else if (textBox1.Text == "admin")
            {
                textBox2.Text = "Welcome Admin";
            }
            else if (textBox1.Text == "user")
            {
                textBox2.Text = "Welcome User";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Apaya.Text = textBox2.Text;   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello " + Username, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Username.Length > 0)
            {
                if (Username == Admin)
                {
                    Form FormDashboard = new Form2(Username);
                    FormDashboard.ShowDialog();
                    //MessageBox.Show($"Hello {Username} Kamu adalah seorang admin");
                }
                else
                {
                    MessageBox.Show($"Hello {Username}");
                }
            }
        }
    }
}
