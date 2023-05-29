using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace midnightCafe
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Christian" && textBox2.Text == "123")
            {
                MessageBox.Show("Welcome to CoffeeCafe Shop!");
                Menu n = new Menu();
                n.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You put invalid Account name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registration n = new registration();
            n.Show();
            this.Hide();
        }
    }
}