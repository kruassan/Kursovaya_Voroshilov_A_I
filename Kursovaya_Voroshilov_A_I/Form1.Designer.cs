namespace Kursovaya_Voroshilov_A_I
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
            this.label3 = new System.Windows.Forms.Label();
            this.Login_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Udal_IP_TB = new System.Windows.Forms.TextBox();
            this.Udal_Port_TB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Local_Rasp_TB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Local_RB = new System.Windows.Forms.RadioButton();
            this.Udal_RB = new System.Windows.Forms.RadioButton();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChangeDirectory = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Здраствуйте! Вас приветствует курсовая работа Ворошилова А.И. Под какой учетной з" +
    "аписью вы хотели бы войти?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(447, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Данное ПО обеспечивает доступ к базе данных, реализованной в БД Microsoft Access";
            // 
            // Login_TB
            // 
            this.Login_TB.Location = new System.Drawing.Point(213, 39);
            this.Login_TB.Name = "Login_TB";
            this.Login_TB.ReadOnly = true;
            this.Login_TB.Size = new System.Drawing.Size(200, 20);
            this.Login_TB.TabIndex = 5;
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(213, 65);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(200, 20);
            this.Password_TB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Логин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ip адрес";
            // 
            // Udal_IP_TB
            // 
            this.Udal_IP_TB.Location = new System.Drawing.Point(94, 91);
            this.Udal_IP_TB.Name = "Udal_IP_TB";
            this.Udal_IP_TB.ReadOnly = true;
            this.Udal_IP_TB.Size = new System.Drawing.Size(200, 20);
            this.Udal_IP_TB.TabIndex = 10;
            // 
            // Udal_Port_TB
            // 
            this.Udal_Port_TB.Location = new System.Drawing.Point(94, 117);
            this.Udal_Port_TB.Name = "Udal_Port_TB";
            this.Udal_Port_TB.ReadOnly = true;
            this.Udal_Port_TB.Size = new System.Drawing.Size(200, 20);
            this.Udal_Port_TB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Порт";
            // 
            // Local_Rasp_TB
            // 
            this.Local_Rasp_TB.Location = new System.Drawing.Point(340, 117);
            this.Local_Rasp_TB.Name = "Local_Rasp_TB";
            this.Local_Rasp_TB.Size = new System.Drawing.Size(200, 20);
            this.Local_Rasp_TB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Расположение";
            // 
            // Local_RB
            // 
            this.Local_RB.AutoSize = true;
            this.Local_RB.Checked = true;
            this.Local_RB.Location = new System.Drawing.Point(400, 143);
            this.Local_RB.Name = "Local_RB";
            this.Local_RB.Size = new System.Drawing.Size(106, 17);
            this.Local_RB.TabIndex = 17;
            this.Local_RB.TabStop = true;
            this.Local_RB.Text = "Войти локально";
            this.Local_RB.UseVisualStyleBackColor = true;
            // 
            // Udal_RB
            // 
            this.Udal_RB.AutoSize = true;
            this.Udal_RB.Location = new System.Drawing.Point(139, 143);
            this.Udal_RB.Name = "Udal_RB";
            this.Udal_RB.Size = new System.Drawing.Size(105, 17);
            this.Udal_RB.TabIndex = 18;
            this.Udal_RB.Text = "Войти удаленно";
            this.Udal_RB.UseVisualStyleBackColor = true;
            this.Udal_RB.CheckedChanged += new System.EventHandler(this.Udal_RB_CheckedChanged);
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(233, 177);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(150, 50);
            this.GoButton.TabIndex = 19;
            this.GoButton.Text = "Войти";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // ChangeDirectory
            // 
            this.ChangeDirectory.Location = new System.Drawing.Point(546, 115);
            this.ChangeDirectory.Name = "ChangeDirectory";
            this.ChangeDirectory.Size = new System.Drawing.Size(75, 23);
            this.ChangeDirectory.TabIndex = 20;
            this.ChangeDirectory.Text = "Изменить";
            this.ChangeDirectory.UseVisualStyleBackColor = true;
            this.ChangeDirectory.Click += new System.EventHandler(this.ChangeDirectory_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(518, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Логин";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Запомнить...";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(518, 220);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Расположение";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(536, 197);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.Text = "Пароль";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(518, 243);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(92, 17);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.Text = "Адрес и порт";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(629, 275);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ChangeDirectory);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.Udal_RB);
            this.Controls.Add(this.Local_RB);
            this.Controls.Add(this.Local_Rasp_TB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Udal_Port_TB);
            this.Controls.Add(this.Udal_IP_TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.Login_TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login_TB;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Udal_IP_TB;
        private System.Windows.Forms.TextBox Udal_Port_TB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Local_Rasp_TB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Local_RB;
        private System.Windows.Forms.RadioButton Udal_RB;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button ChangeDirectory;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}

