namespace calculator_5
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
            this.button_plus = new System.Windows.Forms.Button();
            this.button_multiplication = new System.Windows.Forms.Button();
            this.button_division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button_substraction = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_sqrt = new System.Windows.Forms.Button();
            this.button_exp = new System.Windows.Forms.Button();
            this.button_lg = new System.Windows.Forms.Button();
            this.button_x2 = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.button_tg = new System.Windows.Forms.Button();
            this.button_inv = new System.Windows.Forms.Button();
            this.button_pow = new System.Windows.Forms.Button();
            this.button_arcsin = new System.Windows.Forms.Button();
            this.button_abs = new System.Windows.Forms.Button();
            this.button_ln = new System.Windows.Forms.Button();
            this.button_percent = new System.Windows.Forms.Button();
            this.button_arccos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(143, 46);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(30, 35);
            this.button_plus.TabIndex = 0;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_Click);
            // 
            // button_multiplication
            // 
            this.button_multiplication.Location = new System.Drawing.Point(143, 128);
            this.button_multiplication.Name = "button_multiplication";
            this.button_multiplication.Size = new System.Drawing.Size(30, 35);
            this.button_multiplication.TabIndex = 1;
            this.button_multiplication.Text = "*";
            this.button_multiplication.UseVisualStyleBackColor = true;
            this.button_multiplication.Click += new System.EventHandler(this.button_Click);
            // 
            // button_division
            // 
            this.button_division.Location = new System.Drawing.Point(143, 169);
            this.button_division.Name = "button_division";
            this.button_division.Size = new System.Drawing.Size(30, 35);
            this.button_division.TabIndex = 2;
            this.button_division.Text = "/";
            this.button_division.UseVisualStyleBackColor = true;
            this.button_division.Click += new System.EventHandler(this.button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(95, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(42, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(95, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button_substraction
            // 
            this.button_substraction.Location = new System.Drawing.Point(143, 87);
            this.button_substraction.Name = "button_substraction";
            this.button_substraction.Size = new System.Drawing.Size(30, 35);
            this.button_substraction.TabIndex = 11;
            this.button_substraction.Text = "-";
            this.button_substraction.UseVisualStyleBackColor = true;
            this.button_substraction.Click += new System.EventHandler(this.button_Click);
            // 
            // button_sin
            // 
            this.button_sin.Location = new System.Drawing.Point(179, 46);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(40, 35);
            this.button_sin.TabIndex = 12;
            this.button_sin.Text = "sin";
            this.button_sin.UseVisualStyleBackColor = true;
            this.button_sin.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_cos
            // 
            this.button_cos.Location = new System.Drawing.Point(179, 87);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(40, 35);
            this.button_cos.TabIndex = 13;
            this.button_cos.Text = "cos";
            this.button_cos.UseVisualStyleBackColor = true;
            this.button_cos.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_sqrt
            // 
            this.button_sqrt.Location = new System.Drawing.Point(225, 169);
            this.button_sqrt.Name = "button_sqrt";
            this.button_sqrt.Size = new System.Drawing.Size(40, 35);
            this.button_sqrt.TabIndex = 14;
            this.button_sqrt.Text = "sqrt";
            this.button_sqrt.UseVisualStyleBackColor = true;
            this.button_sqrt.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_exp
            // 
            this.button_exp.Location = new System.Drawing.Point(179, 169);
            this.button_exp.Name = "button_exp";
            this.button_exp.Size = new System.Drawing.Size(40, 35);
            this.button_exp.TabIndex = 15;
            this.button_exp.Text = "exp";
            this.button_exp.UseVisualStyleBackColor = true;
            this.button_exp.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_lg
            // 
            this.button_lg.Location = new System.Drawing.Point(225, 46);
            this.button_lg.Name = "button_lg";
            this.button_lg.Size = new System.Drawing.Size(40, 35);
            this.button_lg.TabIndex = 16;
            this.button_lg.Text = "lg";
            this.button_lg.UseVisualStyleBackColor = true;
            this.button_lg.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_x2
            // 
            this.button_x2.Location = new System.Drawing.Point(225, 87);
            this.button_x2.Name = "button_x2";
            this.button_x2.Size = new System.Drawing.Size(40, 35);
            this.button_x2.TabIndex = 17;
            this.button_x2.Text = "x^2";
            this.button_x2.UseVisualStyleBackColor = true;
            this.button_x2.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(225, 128);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(40, 35);
            this.button_log.TabIndex = 18;
            this.button_log.Text = "log";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.button_Click);
            // 
            // button_tg
            // 
            this.button_tg.Location = new System.Drawing.Point(179, 128);
            this.button_tg.Name = "button_tg";
            this.button_tg.Size = new System.Drawing.Size(40, 35);
            this.button_tg.TabIndex = 19;
            this.button_tg.Text = "tg";
            this.button_tg.UseVisualStyleBackColor = true;
            this.button_tg.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_inv
            // 
            this.button_inv.Location = new System.Drawing.Point(143, 210);
            this.button_inv.Name = "button_inv";
            this.button_inv.Size = new System.Drawing.Size(30, 35);
            this.button_inv.TabIndex = 20;
            this.button_inv.Text = "-x";
            this.button_inv.UseVisualStyleBackColor = true;
            this.button_inv.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_pow
            // 
            this.button_pow.Location = new System.Drawing.Point(179, 210);
            this.button_pow.Name = "button_pow";
            this.button_pow.Size = new System.Drawing.Size(40, 35);
            this.button_pow.TabIndex = 21;
            this.button_pow.Text = "x^y";
            this.button_pow.UseVisualStyleBackColor = true;
            this.button_pow.Click += new System.EventHandler(this.button_Click);
            // 
            // button_arcsin
            // 
            this.button_arcsin.Location = new System.Drawing.Point(271, 46);
            this.button_arcsin.Name = "button_arcsin";
            this.button_arcsin.Size = new System.Drawing.Size(50, 35);
            this.button_arcsin.TabIndex = 22;
            this.button_arcsin.Text = "arcsin";
            this.button_arcsin.UseVisualStyleBackColor = true;
            this.button_arcsin.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_abs
            // 
            this.button_abs.Location = new System.Drawing.Point(225, 210);
            this.button_abs.Name = "button_abs";
            this.button_abs.Size = new System.Drawing.Size(40, 35);
            this.button_abs.TabIndex = 23;
            this.button_abs.Text = "abs";
            this.button_abs.UseVisualStyleBackColor = true;
            this.button_abs.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_ln
            // 
            this.button_ln.Location = new System.Drawing.Point(271, 128);
            this.button_ln.Name = "button_ln";
            this.button_ln.Size = new System.Drawing.Size(50, 35);
            this.button_ln.TabIndex = 24;
            this.button_ln.Text = "ln";
            this.button_ln.UseVisualStyleBackColor = true;
            this.button_ln.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_percent
            // 
            this.button_percent.Location = new System.Drawing.Point(271, 169);
            this.button_percent.Name = "button_percent";
            this.button_percent.Size = new System.Drawing.Size(50, 35);
            this.button_percent.TabIndex = 25;
            this.button_percent.Text = "%";
            this.button_percent.UseVisualStyleBackColor = true;
            this.button_percent.Click += new System.EventHandler(this.one_button_Click);
            // 
            // button_arccos
            // 
            this.button_arccos.Location = new System.Drawing.Point(271, 88);
            this.button_arccos.Name = "button_arccos";
            this.button_arccos.Size = new System.Drawing.Size(50, 32);
            this.button_arccos.TabIndex = 26;
            this.button_arccos.Text = "arccos";
            this.button_arccos.UseVisualStyleBackColor = true;
            this.button_arccos.Click += new System.EventHandler(this.one_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(380, 282);
            this.Controls.Add(this.button_arccos);
            this.Controls.Add(this.button_percent);
            this.Controls.Add(this.button_ln);
            this.Controls.Add(this.button_abs);
            this.Controls.Add(this.button_arcsin);
            this.Controls.Add(this.button_pow);
            this.Controls.Add(this.button_inv);
            this.Controls.Add(this.button_tg);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_x2);
            this.Controls.Add(this.button_lg);
            this.Controls.Add(this.button_exp);
            this.Controls.Add(this.button_sqrt);
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.button_substraction);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_division);
            this.Controls.Add(this.button_multiplication);
            this.Controls.Add(this.button_plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_multiplication;
        private System.Windows.Forms.Button button_division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button_substraction;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_sqrt;
        private System.Windows.Forms.Button button_exp;
        private System.Windows.Forms.Button button_lg;
        private System.Windows.Forms.Button button_x2;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_tg;
        private System.Windows.Forms.Button button_inv;
        private System.Windows.Forms.Button button_pow;
        private System.Windows.Forms.Button button_arcsin;
        private System.Windows.Forms.Button button_abs;
        private System.Windows.Forms.Button button_ln;
        private System.Windows.Forms.Button button_percent;
        private System.Windows.Forms.Button button_arccos;
    }
}

