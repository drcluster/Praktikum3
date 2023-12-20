namespace Praktikum3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = float.Parse(textBox1.Text)/2.205;
            double height = float.Parse(textBox2.Text)/100*2.54;
            double bmi = Math.Round((weight / (height * height)), 2);
            richTextBox1.Text = "BMI: " + bmi.ToString();
            if(bmi < 18.5)
            {
                richTextBox1.Text += Environment.NewLine + "Status: underweight.";
            }
            else if(bmi > 25)
            {
                richTextBox1.Text += Environment.NewLine + "Status: overweight.";
            }
            else
            {
                richTextBox1.Text += Environment.NewLine + "Status: optimal.";
            }
        }
    }
}
