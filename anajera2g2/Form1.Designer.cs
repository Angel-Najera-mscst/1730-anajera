namespace anajera2g2
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
            this.input1aTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultSwitch01TextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.resultif01TextBox = new System.Windows.Forms.TextBox();
            this.resultelseif01TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input1aTextBox
            // 
            this.input1aTextBox.Location = new System.Drawing.Point(172, 18);
            this.input1aTextBox.Name = "input1aTextBox";
            this.input1aTextBox.Size = new System.Drawing.Size(60, 20);
            this.input1aTextBox.TabIndex = 0;
            this.input1aTextBox.Text = "R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1) Switch R/C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2) if R/C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "3) Else if R/C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "4) Nested if else";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "5) Switch w/default";
            // 
            // resultSwitch01TextBox
            // 
            this.resultSwitch01TextBox.Location = new System.Drawing.Point(285, 18);
            this.resultSwitch01TextBox.Name = "resultSwitch01TextBox";
            this.resultSwitch01TextBox.ReadOnly = true;
            this.resultSwitch01TextBox.Size = new System.Drawing.Size(58, 20);
            this.resultSwitch01TextBox.TabIndex = 6;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(172, 256);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 7;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // resultif01TextBox
            // 
            this.resultif01TextBox.Location = new System.Drawing.Point(285, 50);
            this.resultif01TextBox.Name = "resultif01TextBox";
            this.resultif01TextBox.ReadOnly = true;
            this.resultif01TextBox.Size = new System.Drawing.Size(58, 20);
            this.resultif01TextBox.TabIndex = 8;
            // 
            // resultelseif01TextBox
            // 
            this.resultelseif01TextBox.Location = new System.Drawing.Point(285, 85);
            this.resultelseif01TextBox.Name = "resultelseif01TextBox";
            this.resultelseif01TextBox.ReadOnly = true;
            this.resultelseif01TextBox.Size = new System.Drawing.Size(58, 20);
            this.resultelseif01TextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.resultelseif01TextBox);
            this.Controls.Add(this.resultif01TextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultSwitch01TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input1aTextBox);
            this.Name = "Form1";
            this.Text = "anajera2g2 Switch, if-else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1aTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resultSwitch01TextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox resultif01TextBox;
        private System.Windows.Forms.TextBox resultelseif01TextBox;
    }
}

