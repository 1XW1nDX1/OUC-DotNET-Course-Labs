namespace Workbench
{
    public enum Operator
    {
        Add,
        Subtract,
        Multiply,
        Divide,
        Square,
        SquareRoot,
        Reciprocal,
        Log10,
        Ln,
        Factorial,
        Power,
        Root
    }

    public partial class Workbench : Form
    {
        bool canOperate = false;

        readonly List<string> history = new List<string>();

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

        private void Load1(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            if (canOperate)
            {
                listBox1.Items.Add("错误：已经加载");
                return;
            }
            if (!TryReadNumber(input, out double initialValue))
            {
                listBox1.Items.Add("错误：请输入有效的有限实数");
                return;
            }

            currentA = initialValue;
            textBox1.Clear();
            canOperate = true;
            status1.Checked = true;
            current.Text = currentA.ToString("G8");

            label1.Show();
            current.Show();
            operator1.Show();
            label2.Text = "请输入B：";

            AddHistory($"已加载：{currentA:G8}");
        }

        private void SelectOp(object sender, EventArgs e)
        {
            if (operator1.SelectedIndex < 0)
                return;

            currentOperator = (Operator)operator1.SelectedIndex;

            bool showInput = !canOperate || RequiresB(currentOperator);
            textBox1.Visible = showInput;
            label2.Visible = showInput;
            label2.Text = !canOperate ? "初始值"
                : currentOperator == Operator.Root ? "请输入y："
                : "请输入B：";
        }

        private void Do(object sender, EventArgs e)
        {
            double inputB = 0;

            if (!canOperate)
            {
                listBox1.Items.Add("错误：请先载入初始值！");
                return;
            }

            if (RequiresB(currentOperator)
                && !TryReadNumber(textBox1.Text, out inputB))
            {
                listBox1.Items.Add("错误：请输入有效的第二操作数");
                return;
            }

            if (!TryOperate(currentOperator, currentA, inputB,
                out double result, out string error))
            {
                listBox1.Items.Add($"错误：{error}");
                return;
            }

            string expression = Describe(currentOperator, currentA, inputB);
            currentA = result;
            current.Text = currentA.ToString("G8");
            AddHistory($"{expression} = {currentA:G8}");
            textBox1.Clear();
        }

        private void Reset(object sender, EventArgs e)
        {
            currentOperator = Operator.Add;
            currentA = 0;
            label2.Text = "初始值";

            canOperate = false;
            status1.Checked = false;
            operator1.SelectedIndex = 0;
            textBox1.Clear();
            current.Text = "0";

            label1.Hide();
            current.Hide();
            operator1.Hide();
            textBox1.Show();
            label2.Show();

            history.Add("--------------------");
            listBox1.Items.Clear();
            listBox1.Items.Add("已重置");
        }

        private static bool RequiresB(Operator op)
        {
            return op == Operator.Add || op == Operator.Subtract
                || op == Operator.Multiply || op == Operator.Divide
                || op == Operator.Power || op == Operator.Root;
        }

        private static bool TryReadNumber(string input, out double value)
        {
            return double.TryParse(input, out value) && double.IsFinite(value);
        }

        private static bool TryOperate(Operator op, double a, double b,
            out double result, out string error)
        {
            result = 0;
            error = "";

            if (!double.IsFinite(a) || (RequiresB(op) && !double.IsFinite(b)))
            {
                error = "操作数必须是有限实数！";
                return false;
            }

            if (op == Operator.Divide && b == 0)
            {
                error = "除数不能为零！";
                return false;
            }
            if (op == Operator.Reciprocal && a == 0)
            {
                error = "零不能求倒数！";
                return false;
            }
            if (op == Operator.SquareRoot && a < 0)
            {
                error = "不能对负数开平方根！";
                return false;
            }
            if ((op == Operator.Log10 || op == Operator.Ln) && a <= 0)
            {
                error = "对数的真数必须大于零！";
                return false;
            }
            if (op == Operator.Factorial && (a < 0 || a != Math.Truncate(a)))
            {
                error = "阶乘只支持非负整数！";
                return false;
            }
            if (op == Operator.Factorial && a > 170)
            {
                error = "阶乘只支持 0～170，超过此范围会溢出！";
                return false;
            }
            if (op == Operator.Power)
            {
                if (a == 0 && b <= 0)
                {
                    error = "零的指数必须大于零！";
                    return false;
                }
                if (a < 0 && b != Math.Truncate(b))
                {
                    error = "负底数的乘方只支持整数指数！";
                    return false;
                }
            }
            if (op == Operator.Root)
            {
                if (b == 0)
                {
                    error = "根指数 y 不能为零！";
                    return false;
                }
                if (a == 0 && b < 0)
                {
                    error = "零不能开负数次根！";
                    return false;
                }
                if (a < 0 && (b != Math.Truncate(b) || Math.Abs(b % 2) != 1))
                {
                    error = "负数只支持开奇整数次根！";
                    return false;
                }
            }

            switch (op)
            {
                case Operator.Add:
                    result = a + b;
                    break;
                case Operator.Subtract:
                    result = a - b;
                    break;
                case Operator.Multiply:
                    result = a * b;
                    break;
                case Operator.Divide:
                    result = a / b;
                    break;
                case Operator.Square:
                    result = a * a;
                    break;
                case Operator.SquareRoot:
                    result = Math.Sqrt(a);
                    break;
                case Operator.Reciprocal:
                    result = 1.0 / a;
                    break;
                case Operator.Log10:
                    result = Math.Log10(a);
                    break;
                case Operator.Ln:
                    result = Math.Log(a);
                    break;
                case Operator.Factorial:
                    result = 1;
                    for (int i = 2; i <= a; i++)
                        result *= i;
                    break;
                case Operator.Power:
                    result = Math.Pow(a, b);
                    break;
                case Operator.Root:
                    // 先对绝对值开根，再恢复负数奇次根的符号。
                    result = a < 0 ? -Math.Pow(-a, 1.0 / b) : Math.Pow(a, 1.0 / b);
                    break;
                default:
                    error = "不支持的运算类型！";
                    return false;
            }

            if (!double.IsFinite(result))
            {
                error = "运算结果无效或超出 double 的有效范围！";
                return false;
            }
            return true;
        }

        private static string Describe(Operator op, double a, double b)
        {
            return op switch
            {
                Operator.Add => $"{a:G17} + ({b:G17})",
                Operator.Subtract => $"{a:G17} - ({b:G17})",
                Operator.Multiply => $"{a:G17} × ({b:G17})",
                Operator.Divide => $"{a:G17} ÷ ({b:G17})",
                Operator.Square => $"({a:G17})²",
                Operator.SquareRoot => $"√({a:G17})",
                Operator.Reciprocal => $"1 / ({a:G17})",
                Operator.Log10 => $"log10({a:G17})",
                Operator.Ln => $"ln({a:G17})",
                Operator.Factorial => $"({a:G17})!",
                Operator.Power => $"({a:G17}) ^ ({b:G17})",
                Operator.Root => $"({a:G17}) 的 ({b:G17}) 次根",
                _ => "未知运算"
            };
        }

        private void AddHistory(string record)
        {
            history.Add(record);
            listBox1.Items.Add(record);
        }

        private void ShowHistory(object sender, EventArgs e)
        {
            string message = history.Count == 0
                ? "暂无运算历史。"
                : string.Join(Environment.NewLine, history);

            MessageBox.Show(this, message, "运算历史");
        }
    }
}
