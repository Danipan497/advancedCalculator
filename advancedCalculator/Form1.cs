using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advancedCalculator
{
    //Buttons (as rectangles) declarations method. 

    public partial class Calculator : Form
    {
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle oneButtonOriginalRectangle;
        private Rectangle twoButtonOriginalRectangle;
        private Rectangle threeButtonOriginalRectangle;
        private Rectangle fourButtonOriginalRectangle;
        private Rectangle fiveButtonOriginalRectangle;
        private Rectangle sixButtonOriginalRectangle;
        private Rectangle sevenButtonOriginalRectangle;
        private Rectangle eightButtonOriginalRectangle;
        private Rectangle nineButtonOriginalRectangle;
        private Rectangle plusButtonOriginalRectangle;
        private Rectangle minusButtonOriginalRectangle;
        private Rectangle multiplyButtonOriginalRectangle;
        private Rectangle divideButtonOriginalRectangle;
        private Rectangle squareRootButtonOriginalRectangle;
        private Rectangle plusMinusButtonOriginalRectangle;
        private Rectangle equalButtonOriginalRectangle;
        private Rectangle decimalButtonOriginalRectangle;
        private Rectangle clearButtonOriginalRectangle;
        private Rectangle backspaceButtonOriginalRectangle;
        private Rectangle displayLabelOriginalRectangle;
        private Rectangle calculationTrackRectangle;
        private Size originalFormSize;

        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        //Storage of general rectangle parameteres (buttons).

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            zeroButtonOriginalRectangle = new Rectangle(zeroButton.Location.X, zeroButton.Location.Y, zeroButton.Width, zeroButton.Height);
            oneButtonOriginalRectangle = new Rectangle(oneButton.Location.X, oneButton.Location.Y, oneButton.Width, oneButton.Height);
            twoButtonOriginalRectangle = new Rectangle(twoButton.Location.X, twoButton.Location.Y, twoButton.Width, twoButton.Height);
            threeButtonOriginalRectangle = new Rectangle(threeButton.Location.X, threeButton.Location.Y, threeButton.Width, threeButton.Height);
            fourButtonOriginalRectangle = new Rectangle(fourButton.Location.X, fourButton.Location.Y, fourButton.Width, fourButton.Height);
            fiveButtonOriginalRectangle = new Rectangle(fiveButton.Location.X, fiveButton.Location.Y, fiveButton.Width, fiveButton.Height);
            sixButtonOriginalRectangle = new Rectangle(sixButton.Location.X, sixButton.Location.Y, sixButton.Width, sixButton.Height);
            sevenButtonOriginalRectangle = new Rectangle(sevenButton.Location.X, sevenButton.Location.Y, sevenButton.Width, sevenButton.Height);
            eightButtonOriginalRectangle = new Rectangle(eightButton.Location.X, eightButton.Location.Y, eightButton.Width, eightButton.Height);
            nineButtonOriginalRectangle = new Rectangle(nineButton.Location.X, nineButton.Location.Y, nineButton.Width, nineButton.Height);
            plusButtonOriginalRectangle = new Rectangle(plusButton.Location.X, plusButton.Location.Y, plusButton.Width, plusButton.Height);
            minusButtonOriginalRectangle = new Rectangle(minusButton.Location.X, minusButton.Location.Y, minusButton.Width, minusButton.Height);
            multiplyButtonOriginalRectangle = new Rectangle(multiplyButton.Location.X, multiplyButton.Location.Y, multiplyButton.Width, multiplyButton.Height);
            divideButtonOriginalRectangle = new Rectangle(divideButton.Location.X, divideButton.Location.Y, divideButton.Width, divideButton.Height);
            squareRootButtonOriginalRectangle = new Rectangle(squareRootButton.Location.X, squareRootButton.Location.Y, squareRootButton.Width, squareRootButton.Height);
            plusMinusButtonOriginalRectangle = new Rectangle(plusMinusButton.Location.X, plusMinusButton.Location.Y, plusMinusButton.Width, plusMinusButton.Height);
            equalButtonOriginalRectangle = new Rectangle(equalButton.Location.X, equalButton.Location.Y, equalButton.Width, equalButton.Height);
            decimalButtonOriginalRectangle = new Rectangle(decimalButton.Location.X, decimalButton.Location.Y, decimalButton.Width, decimalButton.Height);
            clearButtonOriginalRectangle = new Rectangle(clearButton.Location.X, clearButton.Location.Y, clearButton.Width, clearButton.Height);
            backspaceButtonOriginalRectangle = new Rectangle(backspaceButton.Location.X, backspaceButton.Location.Y, backspaceButton.Width, backspaceButton.Height);
            displayLabelOriginalRectangle = new Rectangle(displayLabel.Location.X, displayLabel.Location.Y, displayLabel.Width, displayLabel.Height);
            calculationTrackRectangle = new Rectangle(calculationTrack.Location.X, calculationTrack.Location.Y, calculationTrack.Width, calculationTrack.Height);
        }

        //Rectangle resize method.
        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(zeroButtonOriginalRectangle, zeroButton);
            resizeControl(oneButtonOriginalRectangle, oneButton);
            resizeControl(twoButtonOriginalRectangle, twoButton);
            resizeControl(threeButtonOriginalRectangle, threeButton);
            resizeControl(fourButtonOriginalRectangle, fourButton);
            resizeControl(fiveButtonOriginalRectangle, fiveButton);
            resizeControl(sixButtonOriginalRectangle, sixButton);
            resizeControl(sevenButtonOriginalRectangle, sevenButton);
            resizeControl(eightButtonOriginalRectangle, eightButton);
            resizeControl(nineButtonOriginalRectangle, nineButton);
            resizeControl(plusButtonOriginalRectangle, plusButton);
            resizeControl(minusButtonOriginalRectangle, minusButton);
            resizeControl(multiplyButtonOriginalRectangle, multiplyButton);
            resizeControl(divideButtonOriginalRectangle, divideButton);
            resizeControl(squareRootButtonOriginalRectangle, squareRootButton);
            resizeControl(plusMinusButtonOriginalRectangle, plusMinusButton);
            resizeControl(equalButtonOriginalRectangle, equalButton);
            resizeControl(decimalButtonOriginalRectangle, decimalButton);
            resizeControl(clearButtonOriginalRectangle, clearButton);
            resizeControl(backspaceButtonOriginalRectangle, backspaceButton);
            resizeControl(displayLabelOriginalRectangle, displayLabel);
            resizeControl(calculationTrackRectangle, calculationTrack);
        }

        //Resize equations.
        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xAxis = (float)(this.Width) / (float)(originalFormSize.Width);
            float yAxis = (float)(this.Height) / (float)(originalFormSize.Height);

            int newXPosition = (int)(OriginalControlRect.X * xAxis);
            int newYPosition = (int)(OriginalControlRect.Y * yAxis);

            int newWidth = (int)(OriginalControlRect.Width * xAxis);
            int newHeight = (int)(OriginalControlRect.Height * yAxis);

            control.Location = new Point(newXPosition, newYPosition);
            control.Size = new Size(newWidth, newHeight);
        }

        //Variables declaration.

        float num1, num2, result;
        char operation;
        bool dec = false;
        private int stringLength;

        //Counting method.
        private void changeLabel(int numPressed)
        {
            if (dec == true)
            {
                int decimalCount = 0;
                foreach(char c in displayLabel.Text)
                {
                    if (c == ',')
                    {
                        decimalCount++;
                    }
                }
                if (decimalCount < 1)
                {
                    displayLabel.Text = displayLabel.Text + ",";
                }
                dec = false;
            }
            else
            {
                if (displayLabel.Text.Equals("0") == true && displayLabel.Text != null)
                {
                    displayLabel.Text = numPressed.ToString();
                }
                else if (displayLabel.Text.Equals("-0") == true)
                {
                    displayLabel.Text = "-" + numPressed.ToString();
                }
                else
                {
                    displayLabel.Text = displayLabel.Text + numPressed.ToString();
                }
            }
        }

        //All buttons declarations.

        private void zeroButton_Click(object sender, EventArgs e)
        {
            changeLabel(0);
        }
        private void oneButton_Click(object sender, EventArgs e)
        {
            changeLabel(1);
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            changeLabel(2);
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            changeLabel(3);
        }
        private void fourButton_Click(object sender, EventArgs e)
        {
            changeLabel(4);
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            changeLabel(5);
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            changeLabel(6);
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            changeLabel(7);
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            changeLabel(8);
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            changeLabel(9);
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
                num1 = float.Parse(displayLabel.Text);
                operation = '+';
                displayLabel.Text = "";
                calculationTrack.Text = num1.ToString() + " + ";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '-';
            displayLabel.Text = "";
            calculationTrack.Text = num1.ToString() + " - ";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '*';
            displayLabel.Text = "";
            calculationTrack.Text = num1.ToString() + " * ";
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            operation = '/';
            displayLabel.Text = "";
            calculationTrack.Text = num1.ToString() + " / ";
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(displayLabel.Text);
            if (num1 > 0)
            {
                double sqrt = Math.Sqrt(num1);
                displayLabel.Text = sqrt.ToString();
            }
        }
        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            int stringLenght = displayLabel.Text.Length;
            if (displayLabel.Text.Equals("0"))
            {
                displayLabel.Text = displayLabel.Text;
            }
            else if (displayLabel.Text.Contains("-") && stringLenght > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(1, 1 - stringLength);
            }
            else
            {
                displayLabel.Text = "-" + displayLabel.Text;
            }
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            result = 0;
            if (displayLabel.Text.Equals("0") == false)
            {
                switch (operation)
                {
                    case '+':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 + num2;
                        calculationTrack.Text = num1.ToString() + " + " + num2.ToString();
                        break;
                    case '-':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 - num2;
                        calculationTrack.Text = num1.ToString() + " - " + num2.ToString();
                        break;
                    case '*':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 * num2;
                        calculationTrack.Text = num1.ToString() + " * " + num2.ToString();
                        break;
                    case '/':
                        num2 = float.Parse(displayLabel.Text);
                        result = num1 / num2;
                        calculationTrack.Text = num1.ToString() + " / " + num2.ToString();
                        break;
                    default:
                        break;
                }
            }
            displayLabel.Text = result.ToString();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            if (displayLabel.Text.Contains(','))
            {
                displayLabel.Text = result.ToString();
            }
            else
            {
                dec = true;
                changeLabel(10);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
            calculationTrack.Text="";
            num1 = 0;
            num2 = 0;
            result = 0;
            operation = '\0';
            dec = false;

        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            int stringLength = displayLabel.Text.Length;
            if (stringLength > 1)
            {
                displayLabel.Text = displayLabel.Text.Substring(0, stringLength - 1);
            }
            else
            {
                displayLabel.Text = "0";
            }
        }

        private void displayLabel_Click(object sender, EventArgs e)
        {

        }
        private void calculationTrack_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        //Keyboard control.
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    zeroButton.PerformClick();
                    break;
                case Keys.D0:
                    zeroButton.PerformClick();
                    break;
                case Keys.NumPad1:
                    oneButton.PerformClick();
                    break;
                case Keys.D1:
                    oneButton.PerformClick();
                    break;
                case Keys.NumPad2:
                    twoButton.PerformClick();
                    break;
                case Keys.D2:
                    twoButton.PerformClick();
                    break;
                case Keys.NumPad3:
                    threeButton.PerformClick();
                    break;
                case Keys.D3:
                    threeButton.PerformClick();
                    break;
                case Keys.NumPad4:
                    fourButton.PerformClick();
                    break;
                case Keys.D4:
                    fourButton.PerformClick();
                    break;
                case Keys.NumPad5:
                    fiveButton.PerformClick();
                    break;
                case Keys.D5:
                    fiveButton.PerformClick();
                    break;
                case Keys.NumPad6:
                    sixButton.PerformClick();
                    break;
                case Keys.D6:
                    sixButton.PerformClick();
                    break;
                case Keys.NumPad7:
                    sevenButton.PerformClick();
                    break;
                case Keys.D7:
                    sevenButton.PerformClick();
                    break;
                case Keys.NumPad8:
                    eightButton.PerformClick();
                    break;
                case Keys.D8:
                    eightButton.PerformClick();
                    break;
                case Keys.NumPad9:
                    nineButton.PerformClick();
                    break;
                case Keys.D9:
                    nineButton.PerformClick();
                    break;
                case Keys.Add:
                    plusButton.PerformClick();
                    break;
                case Keys.Subtract:
                    minusButton.PerformClick();
                    break;
                case Keys.Multiply:
                    multiplyButton.PerformClick();
                    break;
                case Keys.Divide:
                    divideButton.PerformClick();
                    break;
                default:
                    break;
            }
        }
        private void Calculator_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    equalButton.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}