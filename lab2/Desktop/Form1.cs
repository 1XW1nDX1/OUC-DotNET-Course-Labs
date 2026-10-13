namespace Desktop
{
    public partial class Form1 : Form
    {
        //输入
        double width = 0;
        double height = 0;
        double border = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("请输入数值！\nError:空值", "警告");
                return;
            }
            else if (!double.TryParse(textBox1.Text, out width) || !double.TryParse(textBox2.Text, out height) || !double.TryParse(textBox3.Text, out border))
            {
                MessageBox.Show("请输入有效的数值！\nError:非数字", "警告");
                return;
            }
            else
            {
                if(!double.IsFinite(width) || !double.IsFinite(height) || !double.IsFinite(border))
                {
                    MessageBox.Show("请输入有效的数值！\nError:无限数值", "警告");
                    return;
                }
                else if (width <= 0 || height <= 0 || border <= 0 || width > 10000 || border > 10000)
                {
                    MessageBox.Show("请输入有效的数值！\nError:数值为负或过大", "警告");
                    return;
                }
                else if (border * 2 >= width || border * 2 >= height)
                {
                    MessageBox.Show("不满足几何约束，无法计算！\nError:不满足几何约束", "警告");
                    return;
                }
            }

            double innerWidth = width - 2 * border;
            double innerHeight = height - 2 * border;

            double usableArea = innerWidth * innerHeight;

            double borderArea = width * height - usableArea;

            double perimeter = 2 * (width + height);

            label7.Text = $"内部宽度 = {innerWidth:F2} 平方厘米\n内部高度 = {innerHeight:F2} 平方厘米";
            label8.Text = $"可用展示面积 = {usableArea:F2} 平方厘米";

            label9.Text = $"边框材料面积 = {borderArea:F2} 平方厘米";

            label10.Text = $"外边缘周长 = {perimeter:F2} 平方厘米";
        }
    }
}
