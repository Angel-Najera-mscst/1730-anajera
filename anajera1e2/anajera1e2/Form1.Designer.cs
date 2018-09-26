namespace anajera1e2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttest1 = new System.Windows.Forms.TextBox();
            this.txttest2 = new System.Windows.Forms.TextBox();
            this.txttest3 = new System.Windows.Forms.TextBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaverage = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test 3:";
            // 
            // txttest1
            // 
            this.txttest1.AccessibleName = "";
            this.txttest1.Location = new System.Drawing.Point(80, 22);
            this.txttest1.Name = "txttest1";
            this.txttest1.Size = new System.Drawing.Size(48, 20);
            this.txttest1.TabIndex = 0;
            this.txttest1.Tag = "";
            this.txttest1.Text = "0";
            this.txttest1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttest2
            // 
            this.txttest2.AccessibleName = "";
            this.txttest2.Location = new System.Drawing.Point(80, 45);
            this.txttest2.Name = "txttest2";
            this.txttest2.Size = new System.Drawing.Size(48, 20);
            this.txttest2.TabIndex = 1;
            this.txttest2.Tag = "";
            this.txttest2.Text = "0";
            this.txttest2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttest3
            // 
            this.txttest3.AccessibleName = "";
            this.txttest3.Location = new System.Drawing.Point(80, 70);
            this.txttest3.Name = "txttest3";
            this.txttest3.Size = new System.Drawing.Size(48, 20);
            this.txttest3.TabIndex = 2;
            this.txttest3.Tag = "";
            this.txttest3.Text = "0";
            this.txttest3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncalculate
            // 
            this.btncalculate.Location = new System.Drawing.Point(158, 20);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(73, 20);
            this.btncalculate.TabIndex = 3;
            this.btncalculate.Text = "&Calculate";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.Btncalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average:";
            // 
            // txtaverage
            // 
            this.txtaverage.Location = new System.Drawing.Point(81, 111);
            this.txtaverage.Name = "txtaverage";
            this.txtaverage.ReadOnly = true;
            this.txtaverage.Size = new System.Drawing.Size(47, 20);
            this.txtaverage.TabIndex = 6;
            this.txtaverage.Tag = "";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(158, 44);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(73, 21);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(158, 69);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(73, 20);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 175);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtaverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.txttest3);
            this.Controls.Add(this.txttest2);
            this.Controls.Add(this.txttest1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "anajera1e2: Average Test score";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttest1;
        private System.Windows.Forms.TextBox txttest2;
        private System.Windows.Forms.TextBox txttest3;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaverage;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

