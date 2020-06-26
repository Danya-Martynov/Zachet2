namespace WindowsFormsApp3
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
            this.txtbNum1 = new System.Windows.Forms.TextBox();
            this.txtbNum2 = new System.Windows.Forms.TextBox();
            this.txtbNum4 = new System.Windows.Forms.TextBox();
            this.txtbNum3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVychisl = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnR = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbNum1
            // 
            this.txtbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbNum1.Location = new System.Drawing.Point(41, 102);
            this.txtbNum1.Name = "txtbNum1";
            this.txtbNum1.Size = new System.Drawing.Size(100, 24);
            this.txtbNum1.TabIndex = 0;
            this.txtbNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbNum1_KeyPress);
            // 
            // txtbNum2
            // 
            this.txtbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbNum2.Location = new System.Drawing.Point(41, 149);
            this.txtbNum2.Name = "txtbNum2";
            this.txtbNum2.Size = new System.Drawing.Size(100, 24);
            this.txtbNum2.TabIndex = 1;
            this.txtbNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtbNum4
            // 
            this.txtbNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbNum4.Location = new System.Drawing.Point(41, 246);
            this.txtbNum4.Name = "txtbNum4";
            this.txtbNum4.Size = new System.Drawing.Size(100, 24);
            this.txtbNum4.TabIndex = 3;
            this.txtbNum4.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtbNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtbNum3
            // 
            this.txtbNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtbNum3.Location = new System.Drawing.Point(41, 198);
            this.txtbNum3.Name = "txtbNum3";
            this.txtbNum3.Size = new System.Drawing.Size(100, 24);
            this.txtbNum3.TabIndex = 2;
            this.txtbNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите 4 числа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(128, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Вычислить наибольшее чётное";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnVychisl
            // 
            this.btnVychisl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVychisl.Location = new System.Drawing.Point(190, 361);
            this.btnVychisl.Name = "btnVychisl";
            this.btnVychisl.Size = new System.Drawing.Size(100, 38);
            this.btnVychisl.TabIndex = 6;
            this.btnVychisl.Text = "Вычислить";
            this.btnVychisl.UseVisualStyleBackColor = true;
            this.btnVychisl.Click += new System.EventHandler(this.btnVychisl_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(231, 411);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 7;
            // 
            // btnR
            // 
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnR.Location = new System.Drawing.Point(215, 59);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(75, 32);
            this.btnR.TabIndex = 8;
            this.btnR.Text = "red";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnG
            // 
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnG.Location = new System.Drawing.Point(296, 59);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(75, 32);
            this.btnG.TabIndex = 9;
            this.btnG.Text = "green";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnB.Location = new System.Drawing.Point(378, 58);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(75, 33);
            this.btnB.TabIndex = 10;
            this.btnB.Text = "blue";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 450);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnG);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnVychisl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbNum4);
            this.Controls.Add(this.txtbNum3);
            this.Controls.Add(this.txtbNum2);
            this.Controls.Add(this.txtbNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbNum1;
        private System.Windows.Forms.TextBox txtbNum2;
        private System.Windows.Forms.TextBox txtbNum4;
        private System.Windows.Forms.TextBox txtbNum3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVychisl;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnG;
        private System.Windows.Forms.Button btnB;
    }
}

