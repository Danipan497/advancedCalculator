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
    public partial class Calculator : Form
    {
        private Rectangle zeroButtonOriginalRectangle;
        private Rectangle plusMinusButtonOriginalRectangle;
        private Rectangle decimalButtonOriginalRectangle;
        private Rectangle equalButtonOriginalRectangle;
        private Rectangle oneButtonOriginalRectangle;
        private Rectangle twoButtonOriginalRectangle;
        private Rectangle threeButtonOriginalRectangle;
        private Rectangle plusButtonOriginalRectangle;
        private Size originalFormSize;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            zeroButtonOriginalRectangle = new Rectangle(zeroButton.Location.X, zeroButton.Location.Y, zeroButton.Width, zeroButton.Height);
            plusMinusButtonOriginalRectangle = new Rectangle(plusMinusButton.Location.X, plusMinusButton.Location.Y, plusMinusButton.Width, plusMinusButton.Height);
            decimalButtonOriginalRectangle = new Rectangle(decimalButton.Location.X, decimalButton.Location.Y, decimalButton.Width, decimalButton.Height);
            equalButtonOriginalRectangle = new Rectangle(equalButton.Location.X, equalButton.Location.Y, equalButton.Width, equalButton.Height);
            oneButtonOriginalRectangle = new Rectangle(oneButton.Location.X, oneButton.Location.Y, oneButton.Width, oneButton.Height);
            twoButtonOriginalRectangle = new Rectangle(twoButton.Location.X, twoButton.Location.Y, twoButton.Width, twoButton.Height);
            threeButtonOriginalRectangle = new Rectangle(threeButton.Location.X, threeButton.Location.Y, threeButton.Width, threeButton.Height);
            plusButtonOriginalRectangle = new Rectangle(plusButton.Location.X, plusButton.Location.Y, plusButton.Width, plusButton.Height);
        }

        private void Calculator_Resize(object sender, EventArgs e)
        {
            resizeControl(zeroButtonOriginalRectangle, zeroButton);
            resizeControl(plusMinusButtonOriginalRectangle, plusMinusButton);
            resizeControl(decimalButtonOriginalRectangle, decimalButton);
            resizeControl(equalButtonOriginalRectangle, equalButton);
            resizeControl(oneButtonOriginalRectangle, oneButton);
            resizeControl(twoButtonOriginalRectangle, twoButton);
            resizeControl(threeButtonOriginalRectangle, threeButton);
            resizeControl(plusButtonOriginalRectangle, plusButton);
        }
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

        private void zeroButton_Click(object sender, EventArgs e)
        {

        }
    }
}