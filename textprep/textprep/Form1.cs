namespace textprep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);

            answer = (firstTextBoxNumber) + (secondTextBoxNumber);

            
            MessageBox.Show (answer.ToString());



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
