namespace ExpoDesktop
{
    public partial class Form1 : Form
    {
        private String _name;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                _name = textBox1.Text;
            }
            
            MessageBox.Show($"欢迎参观海洋科技展区的{_name}展位。","展位提示");
        }
    }
}
