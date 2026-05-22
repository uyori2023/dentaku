using System.Drawing.Text;

namespace dentaku
{
    public partial class Form1 : Form
    {
        public string _mode = "";
        public string _label1text = "";
        public string _label3text = "";

        private void newallClear()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            _label1text = "";
            _label3text = "";
            _mode = "";
        }

        private void newRefresh()
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
            newRefresh();
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
            if (string.IsNullOrEmpty(label2.Text))
            {
                _label1text += "1";
                newRefresh();
            }
            else
            {
                _label3text += "1";
                newRefresh();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            newallClear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int mode = int.Parse(_mode);

            int label1int = int.Parse(_label1text);
            int label3int = int.Parse(_label3text);

            if (mode == 1)
            {
                int anser = label1int + label3int;

                label4.Text = $"= {anser}";
            }
        }
    }
}
