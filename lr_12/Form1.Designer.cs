
namespace lr_12
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
            this.tB3 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.tB1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tB4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "XCoordinate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "YCoordinate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tB3
            // 
            this.tB3.Location = new System.Drawing.Point(331, 210);
            this.tB3.Name = "tB3";
            this.tB3.ReadOnly = true;
            this.tB3.Size = new System.Drawing.Size(121, 22);
            this.tB3.TabIndex = 4;
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(372, 99);
            this.tB2.Name = "tB2";
            this.tB2.ReadOnly = true;
            this.tB2.Size = new System.Drawing.Size(80, 22);
            this.tB2.TabIndex = 5;
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(372, 52);
            this.tB1.Name = "tB1";
            this.tB1.ReadOnly = true;
            this.tB1.Size = new System.Drawing.Size(80, 22);
            this.tB1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "q_value";
            // 
            // tB4
            // 
            this.tB4.Location = new System.Drawing.Point(373, 143);
            this.tB4.Name = "tB4";
            this.tB4.ReadOnly = true;
            this.tB4.Size = new System.Drawing.Size(79, 22);
            this.tB4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(532, 373);
            this.Controls.Add(this.tB4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(850, 535);
            this.MinimumSize = new System.Drawing.Size(550, 420);
            this.Name = "Form1";
            this.Text = "LR_12";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB3;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB4;
    }
}

