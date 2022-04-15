namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Kursznach = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kurs = new System.Windows.Forms.TextBox();
            this.Sumkonv = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.itogval = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ishodval = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.sumkonv2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doit = new System.Windows.Forms.Button();
            this.Clozz = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.Sost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Kursznach);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Kurs);
            this.groupBox1.Controls.Add(this.Sumkonv);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // Kursznach
            // 
            this.Kursznach.AutoSize = true;
            this.Kursznach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Kursznach.ForeColor = System.Drawing.Color.Black;
            this.Kursznach.Location = new System.Drawing.Point(6, 64);
            this.Kursznach.Name = "Kursznach";
            this.Kursznach.Size = new System.Drawing.Size(149, 17);
            this.Kursznach.TabIndex = 3;
            this.Kursznach.Text = "Курс обмена (руб./$):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сумма конвертации :";
            // 
            // Kurs
            // 
            this.Kurs.Location = new System.Drawing.Point(158, 64);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(95, 20);
            this.Kurs.TabIndex = 1;
            this.Kurs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Kurs_KeyPress);
            // 
            // Sumkonv
            // 
            this.Sumkonv.Location = new System.Drawing.Point(158, 27);
            this.Sumkonv.Name = "Sumkonv";
            this.Sumkonv.Size = new System.Drawing.Size(95, 20);
            this.Sumkonv.TabIndex = 0;
            this.Sumkonv.TextChanged += new System.EventHandler(this.Sumkonv_TextChanged);
            this.Sumkonv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sumkonv_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.itogval);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ishodval);
            this.groupBox3.Controls.Add(this.result);
            this.groupBox3.Controls.Add(this.sumkonv2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(31, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат конвертации";
            // 
            // itogval
            // 
            this.itogval.AutoSize = true;
            this.itogval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itogval.ForeColor = System.Drawing.Color.Black;
            this.itogval.Location = new System.Drawing.Point(244, 54);
            this.itogval.Name = "itogval";
            this.itogval.Size = new System.Drawing.Size(35, 17);
            this.itogval.TabIndex = 4;
            this.itogval.Text = "руб.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(155, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // ishodval
            // 
            this.ishodval.AutoSize = true;
            this.ishodval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ishodval.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ishodval.Location = new System.Drawing.Point(85, 56);
            this.ishodval.Name = "ishodval";
            this.ishodval.Size = new System.Drawing.Size(16, 17);
            this.ishodval.TabIndex = 2;
            this.ishodval.Text = "$";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(180, 53);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(58, 20);
            this.result.TabIndex = 1;
            // 
            // sumkonv2
            // 
            this.sumkonv2.Location = new System.Drawing.Point(24, 53);
            this.sumkonv2.Name = "sumkonv2";
            this.sumkonv2.ReadOnly = true;
            this.sumkonv2.Size = new System.Drawing.Size(55, 20);
            this.sumkonv2.TabIndex = 0;
            this.sumkonv2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sumkonv2_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(332, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 133);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Направление конвертации";
            // 
            // doit
            // 
            this.doit.Location = new System.Drawing.Point(332, 215);
            this.doit.Name = "doit";
            this.doit.Size = new System.Drawing.Size(155, 35);
            this.doit.TabIndex = 4;
            this.doit.Text = "Конвертировать";
            this.doit.UseVisualStyleBackColor = true;
            this.doit.Click += new System.EventHandler(this.doit_Click);
            // 
            // Clozz
            // 
            this.Clozz.Location = new System.Drawing.Point(496, 214);
            this.Clozz.Name = "Clozz";
            this.Clozz.Size = new System.Drawing.Size(157, 36);
            this.Clozz.TabIndex = 5;
            this.Clozz.Text = "Закрыть";
            this.Clozz.UseVisualStyleBackColor = true;
            this.Clozz.Click += new System.EventHandler(this.Clozz_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(6, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Доллары в рубли";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(6, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Рубли в доллары";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Black;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Евро в рубли";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Black;
            this.radioButton4.Location = new System.Drawing.Point(6, 95);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Рубли в евро";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Sost
            // 
            this.Sost.Location = new System.Drawing.Point(511, 29);
            this.Sost.Name = "Sost";
            this.Sost.Size = new System.Drawing.Size(132, 150);
            this.Sost.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 262);
            this.Controls.Add(this.Sost);
            this.Controls.Add(this.Clozz);
            this.Controls.Add(this.doit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AMP оператора обменного пункта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Kursznach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Kurs;
        private System.Windows.Forms.TextBox Sumkonv;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label itogval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ishodval;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox sumkonv2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button doit;
        private System.Windows.Forms.Button Clozz;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label Sost;

    }
}

