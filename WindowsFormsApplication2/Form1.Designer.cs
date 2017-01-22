namespace WindowsFormsApplication2
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
            this.button1 = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.cityname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Узнать время";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(12, 67);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(702, 215);
            this.browser.TabIndex = 2;
            // 
            // cityname
            // 
            this.cityname.Location = new System.Drawing.Point(277, 15);
            this.cityname.Name = "cityname";
            this.cityname.Size = new System.Drawing.Size(114, 20);
            this.cityname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название города(анг.раскладка, нижний регистр)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название страны(анг.раскладка, нижний регистр)";
            // 
            // countryname
            // 
            this.countryname.Location = new System.Drawing.Point(277, 41);
            this.countryname.Name = "countryname";
            this.countryname.Size = new System.Drawing.Size(114, 20);
            this.countryname.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 292);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityname);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TimeShower v0.1 | YOUGAME.BIZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.TextBox cityname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryname;
    }
}

