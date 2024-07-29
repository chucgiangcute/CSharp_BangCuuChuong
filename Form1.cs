using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;

namespace CSharp_BangCuuChuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            BCC.Text = NUMBER.Value.ToString();
        }

        private void TINH_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(BCC.Text);
            for (int i = 1; i <= 10; i++)
            {
                lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BCC.Text = TRACKBAR.Value.ToString();
        }

        private void so_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            lbkq.Text = "";
            if (rd1.Checked)
            {
                int a = 1;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }

            }
            if (rd2.Checked)
            {
                int a = 2;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd3.Checked)
            {
                int a = 3;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd4.Checked)
            {
                int a = 4;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd5.Checked)
            {
                int a = 5;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd6.Checked)
            {
                int a = 6;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd7.Checked)
            {
                int a = 7;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd8.Checked)
            {
                int a = 8;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd9.Checked)
            {
                int a = 9;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
            if (rd10.Checked)
            {
                int a = 10;
                for (int i = 1; i <= 10; i++)
                {
                    lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                    listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
                }
            }
        }
    }
    /*private void kiemtraRDO(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        lbkq.Text = "";
        RadioButton r = (RadioButton)sender;

        {
            int a = Convert.ToInt32(r.Text);
            for (int i = 1; i <= 10; i++)
            {
                lbkq.Text += Environment.NewLine + a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString();
                listBox1.Items.Add(a.ToString() + "x" + i.ToString() + "=" + (a * i).ToString());
            }
        }
    }*/
}
