namespace rasllil
{
    partial class Rasul
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кошкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собакиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.птицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.формыToolStripMenuItem,
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кошкиToolStripMenuItem,
            this.собакиToolStripMenuItem,
            this.птицыToolStripMenuItem});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.формыToolStripMenuItem.Text = "Формы";
            this.формыToolStripMenuItem.Click += new System.EventHandler(this.формыToolStripMenuItem_Click);
            // 
            // кошкиToolStripMenuItem
            // 
            this.кошкиToolStripMenuItem.Name = "кошкиToolStripMenuItem";
            this.кошкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.кошкиToolStripMenuItem.Text = "Кошки";
            this.кошкиToolStripMenuItem.Click += new System.EventHandler(this.кошкиToolStripMenuItem_Click);
            // 
            // собакиToolStripMenuItem
            // 
            this.собакиToolStripMenuItem.Name = "собакиToolStripMenuItem";
            this.собакиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.собакиToolStripMenuItem.Text = "Собаки";
            this.собакиToolStripMenuItem.Click += new System.EventHandler(this.собакиToolStripMenuItem_Click);
            // 
            // птицыToolStripMenuItem
            // 
            this.птицыToolStripMenuItem.Name = "птицыToolStripMenuItem";
            this.птицыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.птицыToolStripMenuItem.Text = "Птицы";
            this.птицыToolStripMenuItem.Click += new System.EventHandler(this.птицыToolStripMenuItem_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // Rasul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Rasul";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кошкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собакиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem птицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}

