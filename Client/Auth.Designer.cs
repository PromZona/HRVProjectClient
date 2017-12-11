namespace Client
{
    partial class Auth
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
            this.Name_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TeacherName_TB = new System.Windows.Forms.TextBox();
            this.SendAuth_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(195, 9);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(114, 28);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Ласточка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите Фамилию имя";
            // 
            // TeacherName_TB
            // 
            this.TeacherName_TB.Location = new System.Drawing.Point(157, 125);
            this.TeacherName_TB.Name = "TeacherName_TB";
            this.TeacherName_TB.Size = new System.Drawing.Size(197, 20);
            this.TeacherName_TB.TabIndex = 2;
            // 
            // SendAuth_BTN
            // 
            this.SendAuth_BTN.Location = new System.Drawing.Point(215, 177);
            this.SendAuth_BTN.Name = "SendAuth_BTN";
            this.SendAuth_BTN.Size = new System.Drawing.Size(75, 23);
            this.SendAuth_BTN.TabIndex = 3;
            this.SendAuth_BTN.Text = "Войти";
            this.SendAuth_BTN.UseVisualStyleBackColor = true;
            this.SendAuth_BTN.Click += new System.EventHandler(this.SendAuth_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(424, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Проблемы?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendAuth_BTN);
            this.Controls.Add(this.TeacherName_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_Label);
            this.Name = "Auth";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TeacherName_TB;
        private System.Windows.Forms.Button SendAuth_BTN;
        private System.Windows.Forms.Label label2;
    }
}

