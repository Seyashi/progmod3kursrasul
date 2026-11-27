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
            this.lblRasul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRasul = new System.Windows.Forms.TextBox();
            this.txtRasul1 = new System.Windows.Forms.TextBox();
            this.txtRasul2 = new System.Windows.Forms.TextBox();
            this.lblRasul1 = new System.Windows.Forms.Label();
            this.lblRasul2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRasul
            // 
            this.lblRasul.AutoSize = true;
            this.lblRasul.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRasul.ForeColor = System.Drawing.Color.Black;
            this.lblRasul.Location = new System.Drawing.Point(207, 81);
            this.lblRasul.Name = "lblRasul";
            this.lblRasul.Size = new System.Drawing.Size(51, 23);
            this.lblRasul.TabIndex = 0;
            this.lblRasul.Text = "label";
            this.lblRasul.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Serif Georgian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(87, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRasul
            // 
            this.txtRasul.Location = new System.Drawing.Point(87, 81);
            this.txtRasul.Name = "txtRasul";
            this.txtRasul.Size = new System.Drawing.Size(100, 20);
            this.txtRasul.TabIndex = 2;
            this.txtRasul.Text = "Введите имя";
            // 
            // txtRasul1
            // 
            this.txtRasul1.Location = new System.Drawing.Point(87, 128);
            this.txtRasul1.Name = "txtRasul1";
            this.txtRasul1.Size = new System.Drawing.Size(100, 20);
            this.txtRasul1.TabIndex = 3;
            this.txtRasul1.Text = "Введите фамилию";
            this.txtRasul1.TextChanged += new System.EventHandler(this.txtRasul1_TextChanged);
            // 
            // txtRasul2
            // 
            this.txtRasul2.Location = new System.Drawing.Point(87, 172);
            this.txtRasul2.Name = "txtRasul2";
            this.txtRasul2.Size = new System.Drawing.Size(100, 20);
            this.txtRasul2.TabIndex = 4;
            this.txtRasul2.Text = "Введите отчество";
            // 
            // lblRasul1
            // 
            this.lblRasul1.AutoSize = true;
            this.lblRasul1.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRasul1.ForeColor = System.Drawing.Color.Black;
            this.lblRasul1.Location = new System.Drawing.Point(207, 128);
            this.lblRasul1.Name = "lblRasul1";
            this.lblRasul1.Size = new System.Drawing.Size(0, 23);
            this.lblRasul1.TabIndex = 5;
            // 
            // lblRasul2
            // 
            this.lblRasul2.AutoSize = true;
            this.lblRasul2.Font = new System.Drawing.Font("Noto Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRasul2.ForeColor = System.Drawing.Color.Black;
            this.lblRasul2.Location = new System.Drawing.Point(207, 172);
            this.lblRasul2.Name = "lblRasul2";
            this.lblRasul2.Size = new System.Drawing.Size(0, 23);
            this.lblRasul2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRasul2);
            this.Controls.Add(this.lblRasul1);
            this.Controls.Add(this.txtRasul2);
            this.Controls.Add(this.txtRasul1);
            this.Controls.Add(this.txtRasul);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRasul);
            this.Name = "Form1";
            this.Text = "RasulGuseynov";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRasul;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRasul;
        private System.Windows.Forms.TextBox txtRasul1;
        private System.Windows.Forms.TextBox txtRasul2;
        private System.Windows.Forms.Label lblRasul1;
        private System.Windows.Forms.Label lblRasul2;
    }
}

