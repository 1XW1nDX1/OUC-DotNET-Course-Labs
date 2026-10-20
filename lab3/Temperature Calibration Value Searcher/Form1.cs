
namespace Temperature_Calibration_Value_Searcher
{
    enum Difficulty
    {
        Easy = 1,
        Medium = 2,
        Hard = 3
    }

    public partial class Form1 : Form
    {
        Difficulty difficalty = Difficulty.Easy;

        int targetTemperature;

        int low = 20;
        int high = 80;

        bool isOK = false;

        List<Commits> records = new List<Commits>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewCircle(sender, e);

            Easy.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                targetTemperature = 53;
            }
        }



        private void StartNewCircle(object sender, EventArgs e)
        {
            isOK = false;
            records.Clear();
            var rand = new Random();

            int lowest;
            int highest;

            if (difficalty == Difficulty.Easy)
            {
                lowest = 20;
                highest = 80;
            }
            else if (difficalty == Difficulty.Medium)
            {
                lowest = 0;
                highest = 100;
            }
            else
            {
                lowest = 0;
                highest = 1000;
            }

            Range1.Text = $"[{lowest},{highest}]";
            targetTemperature = rand.Next(lowest, highest);
        }

        private void Commit(object sender, EventArgs e)
        {
            int g;
            string input = Input1.Text;

            if (isOK)
            {
                MessageBox.Show("本轮已完成，请点击“开始新一轮”按钮", "提示");
            }

            if (String.IsNullOrWhiteSpace(input)
                || !int.TryParse(input, out g)
                || g < low
                || g > high)
            {
                MessageBox.Show($"输入非法！");
                return;
            }

            if (g < targetTemperature)
            {
                low = g + 1;
                Range1.Text = $"[{low},{high}]";
                MessageBox.Show("需要调高", "提示");
                records.Add(new Commits(g, low, high, "需要调高"));
            }
            else if (g > targetTemperature)
            {
                high = g - 1;
                Range1.Text = $"[{low},{high}]";
                MessageBox.Show("需要调低", "提示");
                records.Add(new Commits(g, low, high, "需要调低"));
            }
            else
            {
                MessageBox.Show($"校准完成，本轮结束\n注：\n\t简单难度下，分级为1-3-5\n\t一般难度下，分级为1-4-6\n\t困难难度下，分级为1-5-9", "提示");
                isOK = true;
                records.Add(new Commits(g, -1, -1, "完成"));

                Evaluate();
            }

            return;
        }

        private void ChangeDifficulty(object sender, EventArgs e)
        {
            RadioButton current = (RadioButton)sender;

            if (!current.Checked)
                return;

            if (current == Easy)
            {
                difficalty = Difficulty.Easy;
                Console.WriteLine("Difficulty changed to Easy");
            }
            else if (current == Medium)
            {
                difficalty = Difficulty.Medium;
                Console.WriteLine("Difficulty changed to Medium");
            }
            else if (current == Hard)
            {
                difficalty = Difficulty.Hard;
                Console.WriteLine("Difficulty changed to Hard");
            }
        }

        private void Evaluate()
        {
            int total = records.Count;

            int good = 3;
            int bad = 5;

            if (difficalty == Difficulty.Medium)
            {
                good = 4;
                bad = 6;
            }
            else if (difficalty == Difficulty.Hard)
            {
                good = 5;
                bad = 9;
            }

            if (total <= good)
            {
                listBox1.Items.Add($"本轮共{total}次尝试，表现优秀");
            }
            else if (total <= bad)
            {
                listBox1.Items.Add($"本轮共{total}次尝试，表现良好");
            }
            else
            {
                listBox1.Items.Add($"本轮共{total}次尝试，表现一般");
            }

            listBox1.Items.Add($"目标温度为{targetTemperature}，以下为历史记录");
            listBox1.Height = Math.Min(listBox1.Items.Count * listBox1.ItemHeight + 4, 350);


            foreach (var record in records)
            {
                listBox1.Items.Add(record.GetCommitInfo());

                listBox1.Height = Math.Min(listBox1.Items.Count * listBox1.ItemHeight + 4, 350);
                this.ClientSize = new Size(this.ClientSize.Width, listBox1.Bottom + 10);
            }
        }

        public class Commits
        {
            int g;
            int neoLow;
            int neoHigh;

            string hint;

            public Commits(int g, int neoLow, int neoHigh, string hint)
            {
                this.g = g;
                this.neoLow = neoLow;
                this.neoHigh = neoHigh;
                this.hint = hint;
            }

            public string GetCommitInfo()
            {

                if (neoLow == -1 && neoHigh == -1)
                {
                    return $"输入温度:{g,4}|提示:{hint,-8}";
                }

                return $"输入温度:{g,4}|温度范围[{neoLow,2},{neoHigh,4}]|提示:{hint,-8}";
            }
        }
    }
}
