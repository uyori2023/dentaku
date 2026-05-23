namespace dentaku
{
    public partial class Form1 : Form
    {
        private enum _num
        {
            none,
            plus,
            minus,
            kakeru,
            waru,
        }

        private int _mode = 0;

        /// <summary> 左の数字を保持するフィールド変数 </summary>
        public string _label1text = "";

        /// <summary> 右の数字を保持するフィールド変数 </summary>
        public string _label3text = "";

        private void Newnumplus(string num)
        {
            if (_mode == (int)_num.none)
            {
                _label1text += num;
                NewRefresh();
            }
            else
            {
                _label3text += num;
                NewRefresh();
            }
        }

        /// <summary>
        /// ラベルクリア
        /// </summary>
        private void AllClear()
        {
            lblLeft.Text = "";
            lblShisoku.Text = "";
            lblRight.Text = "";
            lblAnswer.Text = "";
            _label1text = "";
            _label3text = "";
            _mode = (int)_num.none;
        }

        /// <summary>
        /// 再表示
        /// </summary>
        private void NewRefresh()
        {
            lblLeft.Text = _label1text;
            lblRight.Text = _label3text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mode = (int)_num.none;
            lblShisoku.Text = "";
            lblAnswer.Text = "";
            NewRefresh();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            _mode = (int)_num.plus;
            lblShisoku.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _mode = (int)_num.minus;
            lblShisoku.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _mode = (int)_num.kakeru;
            lblShisoku.Text = "×";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _mode = (int)_num.waru;
            lblShisoku.Text = "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Newnumplus(numb1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AllClear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int label1int = int.Parse(lblLeft.Text);
            int label3int = int.Parse(lblRight.Text);

            lblAnswer.Text = "=" + doCalc(label1int, label3int).ToString(); ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Newnumplus(btn.Text);
        }

        /// <summary>
        /// 計算をする
        /// </summary>
        /// <param name="left">左辺</param>
        /// <param name="right">右辺</param>
        /// <returns>計算結果</returns>
        public int doCalc(int left, int right)
        {
            int answer = 0;
            if (_mode == (int)_num.plus)
            {
                answer = left + right;
            }
            else if (_mode == (int)_num.minus)
            {
                answer = left - right;
            }
            else if (_mode == (int)_num.kakeru)
            {
                answer = left * right;
            }
            else if (_mode == (int)_num.waru)
            {
                answer = left / right;
            }

            return answer;
        }
    }
}
