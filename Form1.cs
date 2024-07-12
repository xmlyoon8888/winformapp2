
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None, Add, Subtract, Multiply, Divide, Result
        }
        Operators currentOperator;
        object firstOperand = 0;
        object secondOperand = 0;
        bool operatorChangeFlag = false;

        public Form1()
        {
            InitializeComponent();
        }


        private void displayJust(int num)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            display.Text += $"{num}";
            System.Diagnostics.Debug.WriteLine(display.Text);
            string strNumber = display.Text;
            object opNumber;
            if(strNumber.Contains('.'))
            {
                opNumber = float.Parse(strNumber);
            } else
            {
                opNumber = int.Parse(strNumber);
            }
            
            display.Text = opNumber.ToString();
        }
        private void displayPoint(string num)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            display.Text += $"{num}";
            System.Diagnostics.Debug.WriteLine(display.Text);
            string strNumber = display.Text;
            object opNumber;
            if (strNumber.Contains('.'))
            {
                opNumber = float.Parse(strNumber);
            }
            else
            {
                opNumber = int.Parse(strNumber);
            }

            display.Text = opNumber.ToString();
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            displayJust(0);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            displayJust(1);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            displayJust(2);
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            displayJust(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            displayJust(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            displayJust(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            displayJust(6);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            displayJust(7);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            displayJust(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            displayJust(9);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            display.Text = "";
            firstOperand = 0; 
            secondOperand = 0;
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            displayPoint(".");
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            firstOperand = float.Parse(display.Text);
            currentOperator = Operators.Add;
            operatorChangeFlag = true;
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            firstOperand = float.Parse(display.Text);
            currentOperator = Operators.Subtract;
            operatorChangeFlag = true;
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            firstOperand = float.Parse(display.Text);
            currentOperator = Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            firstOperand = float.Parse(display.Text);
            currentOperator = Operators.Divide;
            operatorChangeFlag = true;
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            secondOperand = float.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                float result = (float)firstOperand + (float)secondOperand;
                display.Text = result.ToString();
            } else if (currentOperator == Operators.Subtract)
            {
                float result = (float)firstOperand - (float)secondOperand;
                display.Text = result.ToString();
            } else if (currentOperator == Operators.Multiply) 
            {
                float result = (float)firstOperand * (float)secondOperand;
                display.Text = result.ToString();
            } else if (currentOperator == Operators.Divide)
            {
                float result = (float)firstOperand / (float)secondOperand;
                display.Text = result.ToString();
            }
        }
    }
}
