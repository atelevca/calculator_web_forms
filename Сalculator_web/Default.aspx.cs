using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Сalculator_web
{
    public partial class _Default : Page
    {
        private string _numType = "d";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TextBoxResult.Text = "0";
            }
        }

        protected void ButtonNumericOperation_Click(object sender, EventArgs e)
        {
            string lastChar = TextBoxResult.Text.Last().ToString();
            Button num = (Button)sender;

            if (lastChar == "0" && TextBoxResult.Text.Length == 1)
            {
                TextBoxResult.Text = num.Text.ToString();
                return;
            }


            if (lastChar == "." && num.Text.ToString() == "." || num.Text.ToString() == "." && TextBoxResult.Text.Length == 0) return;

            TextBoxResult.Text += num.Text.ToString();
        }

        protected void Operation_Click(object sender, EventArgs e)
        {

            if (EndsWithOperator(TextBoxResult.Text.ToString())) TextBoxResult.Text = TextBoxResult.Text.Substring(0, TextBoxResult.Text.Length - 1);

            runOperation();

            TextBoxResult.Text += ((Button)sender).Text.ToString();
        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            runOperation();
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = "0";

        }

        private void runOperation()
        {
            ParseInput(TextBoxResult.Text, out double firstValue, out string operation, out double secondValue);

            string result;

            switch (operation)
            {
                case "+":
                    result = (firstValue + secondValue).ToString();
                    break;
                case "-":
                    result = (firstValue - secondValue).ToString();
                    break;
                case "*":
                    result = (firstValue * secondValue).ToString();
                    break;
                case "/":
                    result = (firstValue / secondValue).ToString();
                    break;
                case "exception":
                    result = TextBoxResult.Text;
                    break;
                default:
                    result = "Invalid operation";
                    break;
            }

            TextBoxResult.Text = result;


        }

        private static bool EndsWithOperator(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            char lastChar = input[input.Length - 1];
            return lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/';
        }

        private static void ParseInput(string input, out double firstValue, out string operation, out double secondValue)
        {
            Regex regex = new Regex(@"(-?\d*\.?\d+)\s*(\+|\-|\*|\/|MOD|EXP)\s*(-?\d*\.?\d+)");
            Match match = regex.Match(input);

            if (match.Success)
            {
                firstValue = double.Parse(match.Groups[1].Value);
                operation = match.Groups[2].Value;
                secondValue = double.Parse(match.Groups[3].Value);
            }
            else
            {
                firstValue = 0;
                operation = "exception";
                secondValue = 0;
            }
        }

        protected void ButtonPi_Click(object sender, EventArgs e)
        {

            TextBoxResult.Text = Math.PI.ToString();
        }

        protected void ButtonLog_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Log10(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonSqrt_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonPower2_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(TextBoxResult.Text), 2));

        }

        protected void ButtonPower3_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Pow(Convert.ToDouble(TextBoxResult.Text), 3));

        }

        protected void ButtonSinh_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Sinh(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonSin_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Sin(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonDec_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "d", TextBoxResult.Text);

            TextBoxResult.Text = res;

            _numType = "d";
        }

        protected void ButtonCosh_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Cosh(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonCos_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Cos(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonBin_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "b", TextBoxResult.Text);

            TextBoxResult.Text = res;

            _numType = "b";
        }

        protected void ButtonOneDivideX_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Convert.ToDouble(1.0 / Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonMod_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Abs(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonFact_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(FactorialRecursive((int)Math.Floor(Convert.ToDouble(TextBoxResult.Text))));

        }

        private static int FactorialRecursive(int number)
        {
            if (number <= 1) return 1;
            else return number * FactorialRecursive(number - 1);
        }

        private void factorialCalculation(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(FactorialRecursive((int)Math.Floor(Convert.ToDouble(TextBoxResult.Text))));
        }

        protected void ButtonOct_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "o", TextBoxResult.Text);

            TextBoxResult.Text = res;

            _numType = "o";

        }

        protected void ButtonPercent_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Convert.ToDouble(TextBoxResult.Text) / Convert.ToDouble(100));

        }

        protected void ButtonTanh_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Tanh(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonTan_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();

            TextBoxResult.Text = Convert.ToString(Math.Tan(Convert.ToDouble(TextBoxResult.Text)));

        }

        protected void ButtonHex_Click(object sender, EventArgs e)
        {
            string res = ConvertNumber(_numType, "h", TextBoxResult.Text);

            TextBoxResult.Text = res;

            _numType = "h";
        }

        protected void ButtonLn_Click(object sender, EventArgs e)
        {
            UpdateTextBoxResult();
            TextBoxResult.Text = Convert.ToString(Math.Log(Convert.ToDouble(TextBoxResult.Text)));

        }

        public static string ConvertNumber(string from, string to, string value)
        {
            int decimalNumber = ConvertToDecimal(value, from);
            return ConvertFromDecimal(decimalNumber, to);
        }


        private static int ConvertToDecimal(string number, string fromBase)
        {
            fromBase = fromBase.ToLower();

            switch (fromBase)
            {
                case "b":
                    return Convert.ToInt32(number, 2);
                case "o":
                    return Convert.ToInt32(number, 8);
                case "d":
                    return int.Parse(number);
                case "h":
                    return Convert.ToInt32(number, 16);
                default:
                    throw new ArgumentException("Invalid source base.");
            }
        }

        private static string ConvertFromDecimal(int decimalNumber, string toBase)
        {
            toBase = toBase.ToLower();

            switch (toBase)
            {
                case "b":
                    return Convert.ToString(decimalNumber, 2);
                case "o":
                    return Convert.ToString(decimalNumber, 8);
                case "d":
                    return decimalNumber.ToString();
                case "h":
                    return Convert.ToString(decimalNumber, 16).ToUpper();
                default:
                    throw new ArgumentException("Invalid target base.");
            }
        }

        private void UpdateTextBoxResult()
        {
            if (EndsWithOperator(TextBoxResult.Text))
            {
                TextBoxResult.Text = TextBoxResult.Text.Substring(0, TextBoxResult.Text.Length - 1);
            }
        }
    }
}