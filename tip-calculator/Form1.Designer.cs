namespace tip_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mealPriceLabel = new System.Windows.Forms.Label();
            this.lowTipLabel = new System.Windows.Forms.Label();
            this.midTipLabel = new System.Windows.Forms.Label();
            this.highTipLabel = new System.Windows.Forms.Label();
            this.lowTipAmt = new System.Windows.Forms.Label();
            this.midTipAmt = new System.Windows.Forms.Label();
            this.highTipAmt = new System.Windows.Forms.Label();
            this.calcTipBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mealPriceLabel
            // 
            this.mealPriceLabel.AutoSize = true;
            this.mealPriceLabel.Location = new System.Drawing.Point(12, 22);
            this.mealPriceLabel.Name = "mealPriceLabel";
            this.mealPriceLabel.Size = new System.Drawing.Size(98, 13);
            this.mealPriceLabel.TabIndex = 0;
            this.mealPriceLabel.Text = "Enter price of meal:";
            this.mealPriceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lowTipLabel
            // 
            this.lowTipLabel.AutoSize = true;
            this.lowTipLabel.Location = new System.Drawing.Point(75, 48);
            this.lowTipLabel.Name = "lowTipLabel";
            this.lowTipLabel.Size = new System.Drawing.Size(27, 13);
            this.lowTipLabel.TabIndex = 1;
            this.lowTipLabel.Text = "15%";
            // 
            // midTipLabel
            // 
            this.midTipLabel.AutoSize = true;
            this.midTipLabel.Location = new System.Drawing.Point(75, 81);
            this.midTipLabel.Name = "midTipLabel";
            this.midTipLabel.Size = new System.Drawing.Size(27, 13);
            this.midTipLabel.TabIndex = 2;
            this.midTipLabel.Text = "18%";
            // 
            // highTipLabel
            // 
            this.highTipLabel.AutoSize = true;
            this.highTipLabel.Location = new System.Drawing.Point(75, 114);
            this.highTipLabel.Name = "highTipLabel";
            this.highTipLabel.Size = new System.Drawing.Size(27, 13);
            this.highTipLabel.TabIndex = 3;
            this.highTipLabel.Text = "20%";
            // 
            // lowTipAmt
            // 
            this.lowTipAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowTipAmt.Location = new System.Drawing.Point(131, 47);
            this.lowTipAmt.Name = "lowTipAmt";
            this.lowTipAmt.Size = new System.Drawing.Size(91, 21);
            this.lowTipAmt.TabIndex = 4;
            this.lowTipAmt.Text = "$0.00";
            this.lowTipAmt.Visible = false;
            // 
            // midTipAmt
            // 
            this.midTipAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midTipAmt.Location = new System.Drawing.Point(131, 113);
            this.midTipAmt.Name = "midTipAmt";
            this.midTipAmt.Size = new System.Drawing.Size(91, 20);
            this.midTipAmt.TabIndex = 5;
            this.midTipAmt.Text = "$0.00";
            this.midTipAmt.Visible = false;
            // 
            // highTipAmt
            // 
            this.highTipAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highTipAmt.Location = new System.Drawing.Point(131, 80);
            this.highTipAmt.Name = "highTipAmt";
            this.highTipAmt.Size = new System.Drawing.Size(91, 20);
            this.highTipAmt.TabIndex = 6;
            this.highTipAmt.Text = "$0.00";
            this.highTipAmt.Visible = false;
            // 
            // calcTipBtn
            // 
            this.calcTipBtn.Location = new System.Drawing.Point(99, 148);
            this.calcTipBtn.Name = "calcTipBtn";
            this.calcTipBtn.Size = new System.Drawing.Size(78, 23);
            this.calcTipBtn.TabIndex = 7;
            this.calcTipBtn.Text = "Calculate Tip";
            this.calcTipBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 197);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.calcTipBtn);
            this.Controls.Add(this.highTipAmt);
            this.Controls.Add(this.midTipAmt);
            this.Controls.Add(this.lowTipAmt);
            this.Controls.Add(this.highTipLabel);
            this.Controls.Add(this.midTipLabel);
            this.Controls.Add(this.lowTipLabel);
            this.Controls.Add(this.mealPriceLabel);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mealPriceLabel;
        private System.Windows.Forms.Label lowTipLabel;
        private System.Windows.Forms.Label midTipLabel;
        private System.Windows.Forms.Label highTipLabel;
        private System.Windows.Forms.Label lowTipAmt;
        private System.Windows.Forms.Label midTipAmt;
        private System.Windows.Forms.Label highTipAmt;
        private System.Windows.Forms.Button calcTipBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

