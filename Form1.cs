using System.Drawing.Text;

namespace dentaku
{
    public partial class Form1 : Form
    {
        public string _mode = "";
        public string _label1text = "";
        public string _label3text = "";

        private void Newnumplus(string num)
        {
            if (string.IsNullOrEmpty(_mode))
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
            _mode = "";
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
            label2.Text = "";
            label4.Text = "";
            NewRefresh();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            _mode = "1";
            label2.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _mode = "2";
            label2.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            _mode = "3";
            label2.Text = "×";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _mode = "4";
            label2.Text = "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Newnumplus(button10.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            NewallClear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int mode = int.Parse(_mode);

            int label1int = int.Parse(_label1text);
            int label3int = int.Parse(_label3text);
            int anser;

            if (mode == 1)
            {
                anser = label1int + label3int;

                label4.Text = $"= {anser}";
            } else if (mode == 2)
            {
                anser = label1int - label3int;
                label4.Text = $"= {anser}";
            } else if (mode == 3)
            {
                anser = label1int * label3int;
                label4.Text = $"= {anser}";
            } else if (mode == 4)
            {
                try
                {
                    anser = label1int / label3int;
                    label4.Text = $"= {anser}";
                } catch
                {
                    label4.Text = "計算エラー";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Newnumplus(button11.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Newnumplus(button9.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Newnumplus(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Newnumplus(button7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Newnumplus(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Newnumplus(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Newnumplus(button4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Newnumplus(button3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Newnumplus(button1.Text);
        }
    }
}
