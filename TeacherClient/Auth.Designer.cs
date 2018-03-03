namespace TeacherClient
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enter_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PostTitle_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pswrd_TB = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Enter_Button
            // 
            this.Enter_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.Enter_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Enter_Button.FlatAppearance.BorderSize = 0;
            this.Enter_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Button.ForeColor = System.Drawing.Color.White;
            this.Enter_Button.Location = new System.Drawing.Point(467, 209);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(103, 43);
            this.Enter_Button.TabIndex = 2;
            this.Enter_Button.Text = "Войти";
            this.Enter_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Enter_Button.UseVisualStyleBackColor = false;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.textBox1.Location = new System.Drawing.Point(259, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 32);
            this.textBox1.TabIndex = 3;
            // 
            // PostTitle_label
            // 
            this.PostTitle_label.AutoSize = true;
            this.PostTitle_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 20F);
            this.PostTitle_label.ForeColor = System.Drawing.Color.White;
            this.PostTitle_label.Location = new System.Drawing.Point(207, 2);
            this.PostTitle_label.Name = "PostTitle_label";
            this.PostTitle_label.Size = new System.Drawing.Size(127, 34);
            this.PostTitle_label.TabIndex = 9;
            this.PostTitle_label.Text = "Ласточка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите имя фамилию:";
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Image = global::TeacherClient.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(507, 2);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(80, 76);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Пароль:";
            // 
            // pswrd_TB
            // 
            this.pswrd_TB.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.pswrd_TB.Location = new System.Drawing.Point(259, 156);
            this.pswrd_TB.Name = "pswrd_TB";
            this.pswrd_TB.PasswordChar = '*';
            this.pswrd_TB.Size = new System.Drawing.Size(194, 32);
            this.pswrd_TB.TabIndex = 12;
            this.pswrd_TB.TextChanged += new System.EventHandler(this.pswrd_TB_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(12, 219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 28);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Запомнить меня";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(582, 264);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pswrd_TB);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PostTitle_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label PostTitle_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pswrd_TB;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}