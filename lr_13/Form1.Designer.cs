
namespace lr_13
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rB1 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rB2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "P";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "N";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(118, 74);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(100, 22);
            this.tB2.TabIndex = 2;
            this.tB2.Text = "0";
            this.tB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB2_KeyPress);
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(118, 25);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(100, 22);
            this.tB1.TabIndex = 2;
            this.tB1.Text = "0";
            this.tB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB1_KeyPress);
            // 
            // tB3
            // 
            this.tB3.Location = new System.Drawing.Point(118, 124);
            this.tB3.Name = "tB3";
            this.tB3.Size = new System.Drawing.Size(100, 22);
            this.tB3.TabIndex = 2;
            this.tB3.Text = "0";
            this.tB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB3_KeyPress);
            // 
            // tB4
            // 
            this.tB4.Location = new System.Drawing.Point(417, 225);
            this.tB4.Name = "tB4";
            this.tB4.ReadOnly = true;
            this.tB4.Size = new System.Drawing.Size(100, 22);
            this.tB4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Z";
            // 
            // rB1
            // 
            this.rB1.AutoSize = true;
            this.rB1.Checked = true;
            this.rB1.Location = new System.Drawing.Point(26, 37);
            this.rB1.Name = "rB1";
            this.rB1.Size = new System.Drawing.Size(113, 21);
            this.rB1.TabIndex = 3;
            this.rB1.TabStop = true;
            this.rB1.Text = "Уравнение 1";
            this.rB1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0,01",
            "0,1",
            "10",
            "100",
            "1000",
            "10000"});
            this.comboBox1.Location = new System.Drawing.Point(333, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "a";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "0,5",
            "5",
            "55",
            "555",
            "5555"});
            this.listBox1.Location = new System.Drawing.Point(333, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 5;
            // 
            // rB2
            // 
            this.rB2.AutoSize = true;
            this.rB2.Location = new System.Drawing.Point(26, 64);
            this.rB2.Name = "rB2";
            this.rB2.Size = new System.Drawing.Size(113, 21);
            this.rB2.TabIndex = 3;
            this.rB2.Text = "Уравнение 2";
            this.rB2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB1);
            this.groupBox1.Controls.Add(this.rB2);
            this.groupBox1.Location = new System.Drawing.Point(491, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор уравнения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 316);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.TextBox tB4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rB1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rB2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

