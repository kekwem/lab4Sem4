
namespace lambda_i_metody_rozszerzajace
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.potegaButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.napisButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 0;
            // 
            // potegaButton
            // 
            this.potegaButton.Location = new System.Drawing.Point(618, 11);
            this.potegaButton.Name = "potegaButton";
            this.potegaButton.Size = new System.Drawing.Size(75, 23);
            this.potegaButton.TabIndex = 1;
            this.potegaButton.Text = "Potega";
            this.potegaButton.UseVisualStyleBackColor = true;
            this.potegaButton.Click += new System.EventHandler(this.potegaButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(102, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 3;
            // 
            // napisButton
            // 
            this.napisButton.Location = new System.Drawing.Point(618, 40);
            this.napisButton.Name = "napisButton";
            this.napisButton.Size = new System.Drawing.Size(75, 23);
            this.napisButton.TabIndex = 4;
            this.napisButton.Text = "Napis";
            this.napisButton.UseVisualStyleBackColor = true;
            this.napisButton.Click += new System.EventHandler(this.napisButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Potega2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.napisButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.potegaButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "LiMR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button potegaButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button napisButton;
        private System.Windows.Forms.Button button1;
    }
}

