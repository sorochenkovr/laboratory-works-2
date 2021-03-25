
namespace lr15
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonFont = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonMath = new System.Windows.Forms.Button();
            this.textMath1 = new System.Windows.Forms.TextBox();
            this.textMath2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.textMath3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonColor.Location = new System.Drawing.Point(43, 12);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(140, 23);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.Text = "Выбор цвета";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.Location = new System.Drawing.Point(43, 66);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(140, 23);
            this.buttonFont.TabIndex = 0;
            this.buttonFont.Text = "Выбор шрифта";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(43, 121);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(140, 23);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Выбор файла";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(43, 179);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(140, 23);
            this.buttonFolder.TabIndex = 0;
            this.buttonFolder.Text = "Выбор каталога";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(298, 12);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(274, 23);
            this.panelColor.TabIndex = 1;
            // 
            // textBoxFont
            // 
            this.textBoxFont.Location = new System.Drawing.Point(298, 66);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(274, 22);
            this.textBoxFont.TabIndex = 2;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(298, 122);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(274, 22);
            this.textBoxFile.TabIndex = 2;
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(298, 179);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(274, 22);
            this.textBoxFolder.TabIndex = 2;
            // 
            // buttonMath
            // 
            this.buttonMath.Location = new System.Drawing.Point(43, 239);
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.Size = new System.Drawing.Size(140, 23);
            this.buttonMath.TabIndex = 3;
            this.buttonMath.Text = "Вычислить ";
            this.buttonMath.UseVisualStyleBackColor = true;
            this.buttonMath.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // textMath1
            // 
            this.textMath1.Location = new System.Drawing.Point(318, 232);
            this.textMath1.Name = "textMath1";
            this.textMath1.Size = new System.Drawing.Size(62, 22);
            this.textMath1.TabIndex = 4;
            this.textMath1.Text = "0";
            this.textMath1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMath1_KeyPress);
            // 
            // textMath2
            // 
            this.textMath2.Location = new System.Drawing.Point(409, 232);
            this.textMath2.Name = "textMath2";
            this.textMath2.Size = new System.Drawing.Size(62, 22);
            this.textMath2.TabIndex = 4;
            this.textMath2.Text = "0";
            this.textMath2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMath2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(295, 270);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(18, 17);
            this.txtResult.TabIndex = 5;
            this.txtResult.Text = "U";
            // 
            // textMath3
            // 
            this.textMath3.Location = new System.Drawing.Point(318, 267);
            this.textMath3.Name = "textMath3";
            this.textMath3.ReadOnly = true;
            this.textMath3.Size = new System.Drawing.Size(254, 22);
            this.textMath3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textMath3);
            this.Controls.Add(this.textMath2);
            this.Controls.Add(this.textMath1);
            this.Controls.Add(this.buttonMath);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.buttonColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.TextBox textMath1;
        private System.Windows.Forms.TextBox textMath2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.TextBox textMath3;
    }
}

