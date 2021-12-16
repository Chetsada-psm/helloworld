namespace TempeatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            //input
            //textBoxC.Text = "Hello";
            // get input from texbox
            string input = textBoxC.Text;

            // convert to f
            // f = c x 9/5 + 32
            double c = Convert.ToDouble(input); 
            double f = c * 9 / 5 + 32;

            // show input to texbox
            textBoxF.Text = f.ToString();

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ConvertF_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5/9;
            textBoxC.Text = c.ToString();
        }
    }
}