using System.Drawing.Text;
using System.IO.Pipes;

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
        public string _label1text = "";
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

        private void NewallClear()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            _label1text = "";
            _label3text = "";
        }

        private void NewRefresh()
        {
            label1.Text = _label1text;
            label3.Text = _label3text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _mode = (int)_num.none;
            label2.Text = "";
            label4.Text = "";
            NewRefresh();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            _mode = (int)_num.plus;
            label2.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _mode = (int)_num.minus;
            label2.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _mode = (int)_num.kakeru;
            label2.Text = "×";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _mode = (int)_num.waru;
            label2.Text = "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Newnumplus(numb1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            NewallClear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int label1int = int.Parse(label1.Text);
            int label3int = int.Parse(label3.Text);

            int anser = 0;

            switch (_mode)
            {
                case (int)_num.none:
                    return;
                case (int)_num.plus:
                    anser = label1int + label3int;
                    label4.Text = "=" + anser.ToString();
                    return;
                case (int)_num.minus:
                    anser = label1int - label3int;
                    label4.Text = "=" + anser.ToString();
                    return;
                case (int)_num.kakeru:
                    anser = label1int * label3int;
                    label4.Text = "=" + anser.ToString();
                    return;
                case (int)_num.waru:
                    anser = label1int / label3int;
                    label4.Text = "=" + anser.ToString();
                    return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Newnumplus(btn.Text);
        }
    }
}
