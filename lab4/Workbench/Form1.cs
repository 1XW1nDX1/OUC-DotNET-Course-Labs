namespace Workbench
{
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Power,
        SquareRoot,
        Reciprocal
    }

    public partial class Workbench : Form
    {
        bool canOperate = false;

        bool isBShow = true;

        double currentA;

        Operator currentOperator = Operator.Add;

        public Workbench()
        {
            InitializeComponent();
            operator1.SelectedIndex = 0;

            //隐藏其他元素
            label1.Hide();
            current.Hide();
            operator1.Hide();
        }

        private void Load(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (canOperate)
            {
                listBox1.Items.Add("错误：已经加载");
                return;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(input)
                    || !Double.TryParse(input, out currentA))
                {
                    listBox1.Items.Add("错误：请输入正确的数字");
                    return;
                }
                else
                {
                    currentA = Double.Parse(input);
                    textBox1.Text = "";
                }
            }

            canOperate = true;
            current.Text = currentA.ToString();

            label1.Show();
            current.Show();
            operator1.Show();

            listBox1.Items.Add($"已加载：{currentA}");

            return;
        }

        private void Do(object sender, EventArgs e)
        {
            double inputB = 0;
        }

        private void Reset(object sender, EventArgs e)
        {

        }
    }
}
