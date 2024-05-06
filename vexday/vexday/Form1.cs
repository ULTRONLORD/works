namespace vexday
{
    public partial class Form1 : Form
    {
        private int memory;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value1;
            value1 = textBox1.Text;

            int val1 = int.Parse(value1);



            string value2;
            value2 = textBox2.Text;

            int val2 = int.Parse(value2);

            int ans = val1 + val2;
            string ans1 = ans.ToString();

            //MessageBox.Show(ans1);
            label1.Text = ans1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory = int.Parse(label1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = memory.ToString();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
