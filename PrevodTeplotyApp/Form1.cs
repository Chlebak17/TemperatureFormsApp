namespace PrevodTeplotyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double toCelsius(double temp)
        {
            double plus = temp - 32;
            double totoReturn = Math.Round(plus * 5 / 9, 2);
            return totoReturn;

        }

        public double toFarenheit(double temp)
        {

            double totoReturn = 32 + temp * 9 / 5;
            return totoReturn;
        }

        private void buttonPreved_Click(object sender, EventArgs e)
        {
            double num = (double)numericUpDown1.Value;
            if (switchTemp.Text.Equals("°F->°C"))
            {
                num = toCelsius(num);
                //Math.Round(num,1);
                textBox1.Text = num.ToString();
            }
            else
            {
                num = toFarenheit(num);
                textBox1.Text = num.ToString();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                numericUpDown1.ForeColor = Color.Red;
            }
            else if (numericUpDown1.Value < 0)
            {
                numericUpDown1.ForeColor = Color.Blue;
            }
            else
            {
                numericUpDown1.ForeColor = Color.Black;
            }


        }

        private void switchTemp_Click(object sender, EventArgs e)
        {
            if (switchTemp.Text.Equals("°F->°C"))
            {
                switchTemp.Text = "°C->°F";
                label1.Text = "°C=";
                label2.Text = "°F=";
            }
            else
            {
                switchTemp.Text = "°F->°C";
                label1.Text = "°F=";
                label2.Text = "°C=";
            }

        }

        private void ender_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}