namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_res = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.lb_sign = new System.Windows.Forms.Label();
            this.lb_equal_sigh = new System.Windows.Forms.Label();
            this.bt_plus = new System.Windows.Forms.Button();
            this.bt_div = new System.Windows.Forms.Button();
            this.bt_minus = new System.Windows.Forms.Button();
            this.bt_mult = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_1.Location = new System.Drawing.Point(25, 71);
            this.tb_1.Multiline = true;
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(134, 59);
            this.tb_1.TabIndex = 0;
            // 
            // tb_res
            // 
            this.tb_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_res.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_res.Location = new System.Drawing.Point(490, 71);
            this.tb_res.Multiline = true;
            this.tb_res.Name = "tb_res";
            this.tb_res.Size = new System.Drawing.Size(134, 59);
            this.tb_res.TabIndex = 1;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_2.Location = new System.Drawing.Point(246, 71);
            this.tb_2.Multiline = true;
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(134, 59);
            this.tb_2.TabIndex = 2;
            // 
            // lb_sign
            // 
            this.lb_sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_sign.Location = new System.Drawing.Point(176, 74);
            this.lb_sign.Name = "lb_sign";
            this.lb_sign.Size = new System.Drawing.Size(54, 47);
            this.lb_sign.TabIndex = 3;
            // 
            // lb_equal_sigh
            // 
            this.lb_equal_sigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lb_equal_sigh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_equal_sigh.Location = new System.Drawing.Point(414, 74);
            this.lb_equal_sigh.Name = "lb_equal_sigh";
            this.lb_equal_sigh.Size = new System.Drawing.Size(42, 47);
            this.lb_equal_sigh.TabIndex = 4;
            this.lb_equal_sigh.Text = "=";
            // 
            // bt_plus
            // 
            this.bt_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_plus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_plus.Location = new System.Drawing.Point(25, 250);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(108, 95);
            this.bt_plus.TabIndex = 5;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = false;
            this.bt_plus.Click += new System.EventHandler(this.bt_plus_Click);
            // 
            // bt_div
            // 
            this.bt_div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_div.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_div.Location = new System.Drawing.Point(348, 250);
            this.bt_div.Name = "bt_div";
            this.bt_div.Size = new System.Drawing.Size(108, 95);
            this.bt_div.TabIndex = 6;
            this.bt_div.Text = "/";
            this.bt_div.UseVisualStyleBackColor = false;
            this.bt_div.Click += new System.EventHandler(this.bt_div_Click);
            // 
            // bt_minus
            // 
            this.bt_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_minus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_minus.Location = new System.Drawing.Point(184, 250);
            this.bt_minus.Name = "bt_minus";
            this.bt_minus.Size = new System.Drawing.Size(108, 95);
            this.bt_minus.TabIndex = 7;
            this.bt_minus.Text = "-";
            this.bt_minus.UseVisualStyleBackColor = false;
            this.bt_minus.Click += new System.EventHandler(this.bt_minus_Click);
            // 
            // bt_mult
            // 
            this.bt_mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_mult.Location = new System.Drawing.Point(516, 250);
            this.bt_mult.Name = "bt_mult";
            this.bt_mult.Size = new System.Drawing.Size(108, 95);
            this.bt_mult.TabIndex = 8;
            this.bt_mult.Text = "*";
            this.bt_mult.UseVisualStyleBackColor = false;
            this.bt_mult.Click += new System.EventHandler(this.bt_mult_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(220, 410);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 76);
            this.button5.TabIndex = 9;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 537);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bt_mult);
            this.Controls.Add(this.bt_minus);
            this.Controls.Add(this.bt_div);
            this.Controls.Add(this.bt_plus);
            this.Controls.Add(this.lb_equal_sigh);
            this.Controls.Add(this.lb_sign);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_res);
            this.Controls.Add(this.tb_1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_res;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label lb_sign;
        private System.Windows.Forms.Label lb_equal_sigh;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.Button bt_div;
        private System.Windows.Forms.Button bt_minus;
        private System.Windows.Forms.Button bt_mult;
        private System.Windows.Forms.Button button5;
    }
}

