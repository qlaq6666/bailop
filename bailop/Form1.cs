namespace bailop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = tb1.Text;
            pass = tb2.Text;
            if (string.IsNullOrEmpty(tb1.Text) && string.IsNullOrEmpty(tb2.Text))
            {
                tb1.Text = "Vui lòng nhập đầy đủ thông tin";
                tb2.Text = "Vui lòng nhập đầy đủ thông tin";
                Console.Read();
            }
             else if (user == "admin" && pass == "123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                tb1.Text = "sai tên đăng nhập hoặc mật khẩu";
                tb2.Text = "sai tên đăng nhập hoặc mật khẩu";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có muốn thoát ứng dụng", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            ;
        }
    }
}
