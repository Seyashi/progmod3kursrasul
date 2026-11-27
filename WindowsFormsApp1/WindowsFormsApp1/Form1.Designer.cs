namespace WindowsFormsApp1
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
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxAnimalType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(221, 382);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(134, 40);
            this.buttonAddAnimal.TabIndex = 0;
            this.buttonAddAnimal.Text = "button1";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.Location = new System.Drawing.Point(83, 24);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(639, 303);
            this.listBoxAnimals.TabIndex = 1;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(83, 392);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAge.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(376, 393);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(131, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // comboBoxAnimalType
            // 
            this.comboBoxAnimalType.FormattingEnabled = true;
            this.comboBoxAnimalType.Location = new System.Drawing.Point(530, 393);
            this.comboBoxAnimalType.Name = "comboBoxAnimalType";
            this.comboBoxAnimalType.Size = new System.Drawing.Size(192, 21);
            this.comboBoxAnimalType.TabIndex = 4;
            this.comboBoxAnimalType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выбор типа  животного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Добавление животного";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(401, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Имя животного:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выбрать тип животного";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAnimalType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.buttonAddAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxAnimalType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

