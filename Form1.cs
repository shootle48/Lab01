namespace Lab1
{
    public partial class Form1 : Form
    {
        //class variable
        double input1 = 0.00;
        double input2 = 0.00;
        string Ops = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void divide_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Input.Text);
            this.Ops = "/";
            this.nums_before.Text = string.Format("{0:N2}", input1) + "÷";
            this.Input.Text = "";
        }
        private void multi_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Input.Text);
            this.Ops = "*";
            this.nums_before.Text = string.Format("{0:N2}", input1) + "x";
            this.Input.Text = "";
        }
        private void minut_Click(object sender, EventArgs e)
        {
            this.input1 = double.Parse(this.Input.Text);
            this.Ops = "-";
            this.nums_before.Text = string.Format("{0:N2}", input1) + "-";
            this.Input.Text = "";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            //assign value to class variable
            this.input1 = double.Parse(this.Input.Text);
            this.Ops = "+"; 
            this.nums_before.Text = string.Format("{0:N2}", input1) + "+";
            //clear input text
            this.Input.Text = "";
        }

        private void Ans_Click(object sender, EventArgs e)
        {
            if (this.Ops == "+")
            {
                this.input2 = double.Parse(this.Input.Text);
                this.Input.Text = string.Format("{0:N2}", input1 + input2);
            }
            else if (this.Ops == "-")
            {
                this.input2 = double.Parse(this.Input.Text);
                this.Input.Text = string.Format("{0:N2}", input1 - input2);
            }
            else if (this.Ops == "*")
            {
                this.input2 = double.Parse(this.Input.Text);
                this.Input.Text = string.Format("{0:N2}", input1 * input2);
            }
            else if (this.Ops == "/")
            {
                this.input2 = double.Parse(this.Input.Text);
                this.Input.Text = string.Format("{0:N2}", input1 / input2);
            }
            this.nums_before.Text = this.nums_before.Text + string.Format("{0:N2}", input2) + "=";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "9";
            if(this.Input.Text.Length % 4 == 0) 
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "8";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "7";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "6";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "5";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "4";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "3";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "2";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "1";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text)); 
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + "0";
            if (this.Input.Text.Length % 4 == 0)
            {
                this.Input.Text = string.Format("{0:N0}", double.Parse(this.Input.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Input.Text = "";
            this.nums_before.Text = "";
        }

        private void point_Click(object sender, EventArgs e)
        {
            this.Input.Text = this.Input.Text + ".";
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void nums_before_TextChanged(object sender, EventArgs e)
        {

        }
    }
}