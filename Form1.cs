using System.Data;

namespace calculate2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) => listBox1.Items.Add("1");
        private void btn2_Click(object sender, EventArgs e) => listBox1.Items.Add("2");
        private void btn3_Click(object sender, EventArgs e) => listBox1.Items.Add("3");
        private void btn4_Click(object sender, EventArgs e) => listBox1.Items.Add("4");
        private void btn5_Click(object sender, EventArgs e) => listBox1.Items.Add("5");
        private void btn6_Click(object sender, EventArgs e) => listBox1.Items.Add("6");
        private void btn7_Click(object sender, EventArgs e) => listBox1.Items.Add("7");
        private void btn8_Click(object sender, EventArgs e) => listBox1.Items.Add("8");
        private void btn9_Click(object sender, EventArgs e) => listBox1.Items.Add("9");
        private void btn0_Click(object sender, EventArgs e) => listBox1.Items.Add("0");

        private void topla_Click(object sender, EventArgs e) => listBox1.Items.Add("+");
        private void cix_Click(object sender, EventArgs e) => listBox1.Items.Add("-");
        private void vur_Click(object sender, EventArgs e) => listBox1.Items.Add("*");
        private void devide_Click(object sender, EventArgs e) => listBox1.Items.Add("/");
        private void qaliq_Click(object sender, EventArgs e) => listBox1.Items.Add("%");

        private void AC_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            try
            {

                string expression = string.Join("", listBox1.Items.Cast<string>());


                DataTable dt = new DataTable();
                var result = dt.Compute(expression, "");


                listBox1.Items.Clear();
                listBox1.Items.Add(result?.ToString() ?? "sehv ifade");


                string historyItem = expression + " = " + result?.ToString();
                listBox2.Items.Add(historyItem);
            }
            catch
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex!= -1)
            {
                int selectedIndex = listBox2.SelectedIndex;
                listBox2.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }
}
