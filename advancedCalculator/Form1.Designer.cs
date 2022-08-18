namespace advancedCalculator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.zeroButton = new System.Windows.Forms.Button();
            this.plusMinusButton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zeroButton.Location = new System.Drawing.Point(176, 652);
            this.zeroButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Padding = new System.Windows.Forms.Padding(1);
            this.zeroButton.Size = new System.Drawing.Size(158, 114);
            this.zeroButton.TabIndex = 0;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // plusMinusButton
            // 
            this.plusMinusButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusMinusButton.Location = new System.Drawing.Point(12, 652);
            this.plusMinusButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.plusMinusButton.Name = "plusMinusButton";
            this.plusMinusButton.Padding = new System.Windows.Forms.Padding(1);
            this.plusMinusButton.Size = new System.Drawing.Size(158, 114);
            this.plusMinusButton.TabIndex = 1;
            this.plusMinusButton.Text = "+/-";
            this.plusMinusButton.UseVisualStyleBackColor = true;
            // 
            // decimalButton
            // 
            this.decimalButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decimalButton.Location = new System.Drawing.Point(340, 652);
            this.decimalButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Padding = new System.Windows.Forms.Padding(1);
            this.decimalButton.Size = new System.Drawing.Size(158, 114);
            this.decimalButton.TabIndex = 2;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equalButton.Location = new System.Drawing.Point(504, 652);
            this.equalButton.MinimumSize = new System.Drawing.Size(158, 114);
            this.equalButton.Name = "equalButton";
            this.equalButton.Padding = new System.Windows.Forms.Padding(1);
            this.equalButton.Size = new System.Drawing.Size(158, 114);
            this.equalButton.TabIndex = 3;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 778);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.decimalButton);
            this.Controls.Add(this.plusMinusButton);
            this.Controls.Add(this.zeroButton);
            this.MinimumSize = new System.Drawing.Size(692, 834);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Resize += new System.EventHandler(this.Calculator_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Button zeroButton;
        private Button plusMinusButton;
        private Button decimalButton;
        private Button equalButton;
    }
}