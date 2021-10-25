
namespace TRPO_ISP_2_20_Laykov_PR2
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
            this.lab1 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.textB1 = new System.Windows.Forms.TextBox();
            this.textB2 = new System.Windows.Forms.TextBox();
            this.pan1 = new System.Windows.Forms.Panel();
            this.radioe = new System.Windows.Forms.RadioButton();
            this.radiox = new System.Windows.Forms.RadioButton();
            this.radiosh = new System.Windows.Forms.RadioButton();
            this.PYSK = new System.Windows.Forms.Button();
            this.richTextB = new System.Windows.Forms.RichTextBox();
            this.pan1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(12, 24);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(20, 13);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "X=";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Location = new System.Drawing.Point(12, 58);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(20, 13);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Y=";
            // 
            // textB1
            // 
            this.textB1.Location = new System.Drawing.Point(38, 21);
            this.textB1.Name = "textB1";
            this.textB1.Size = new System.Drawing.Size(106, 20);
            this.textB1.TabIndex = 3;
            this.textB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB1_KeyPress);
            // 
            // textB2
            // 
            this.textB2.Location = new System.Drawing.Point(38, 55);
            this.textB2.Name = "textB2";
            this.textB2.Size = new System.Drawing.Size(106, 20);
            this.textB2.TabIndex = 5;
            this.textB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB2_KeyPress);
            // 
            // pan1
            // 
            this.pan1.Controls.Add(this.radioe);
            this.pan1.Controls.Add(this.radiox);
            this.pan1.Controls.Add(this.radiosh);
            this.pan1.Location = new System.Drawing.Point(190, 24);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(129, 106);
            this.pan1.TabIndex = 6;
            // 
            // radioe
            // 
            this.radioe.AutoSize = true;
            this.radioe.Location = new System.Drawing.Point(27, 76);
            this.radioe.Name = "radioe";
            this.radioe.Size = new System.Drawing.Size(68, 17);
            this.radioe.TabIndex = 2;
            this.radioe.Text = "f(x) = e^x";
            this.radioe.UseVisualStyleBackColor = true;
            // 
            // radiox
            // 
            this.radiox.AutoSize = true;
            this.radiox.Location = new System.Drawing.Point(27, 44);
            this.radiox.Name = "radiox";
            this.radiox.Size = new System.Drawing.Size(68, 17);
            this.radiox.TabIndex = 1;
            this.radiox.Text = "f(x) = x^2";
            this.radiox.UseVisualStyleBackColor = true;
            // 
            // radiosh
            // 
            this.radiosh.AutoSize = true;
            this.radiosh.Checked = true;
            this.radiosh.Location = new System.Drawing.Point(27, 12);
            this.radiosh.Name = "radiosh";
            this.radiosh.Size = new System.Drawing.Size(75, 17);
            this.radiosh.TabIndex = 0;
            this.radiosh.TabStop = true;
            this.radiosh.Text = "f(x) = Sh(x)";
            this.radiosh.UseVisualStyleBackColor = true;
            // 
            // PYSK
            // 
            this.PYSK.Location = new System.Drawing.Point(75, 291);
            this.PYSK.Name = "PYSK";
            this.PYSK.Size = new System.Drawing.Size(230, 23);
            this.PYSK.TabIndex = 7;
            this.PYSK.Text = "ПУСК";
            this.PYSK.UseVisualStyleBackColor = true;
            this.PYSK.Click += new System.EventHandler(this.PYSK_Click);
            // 
            // richTextB
            // 
            this.richTextB.Location = new System.Drawing.Point(75, 177);
            this.richTextB.Name = "richTextB";
            this.richTextB.Size = new System.Drawing.Size(230, 108);
            this.richTextB.TabIndex = 8;
            this.richTextB.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(372, 351);
            this.Controls.Add(this.richTextB);
            this.Controls.Add(this.PYSK);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.textB2);
            this.Controls.Add(this.textB1);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Практическая работа №2 (2 Вариант)";
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.TextBox textB1;
        private System.Windows.Forms.TextBox textB2;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.RadioButton radioe;
        private System.Windows.Forms.RadioButton radiox;
        private System.Windows.Forms.RadioButton radiosh;
        private System.Windows.Forms.Button PYSK;
        private System.Windows.Forms.RichTextBox richTextB;
    }
}

