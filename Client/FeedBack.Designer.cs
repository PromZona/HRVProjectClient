namespace Client
{
    partial class FeedBack
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
            this.label1 = new System.Windows.Forms.Label();
            this.Back_BTN = new System.Windows.Forms.Button();
            this.Tit_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_TB = new System.Windows.Forms.TextBox();
            this.Send_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема: ";
            // 
            // Back_BTN
            // 
            this.Back_BTN.Location = new System.Drawing.Point(10, 12);
            this.Back_BTN.Name = "Back_BTN";
            this.Back_BTN.Size = new System.Drawing.Size(63, 21);
            this.Back_BTN.TabIndex = 1;
            this.Back_BTN.Text = "Назад";
            this.Back_BTN.UseVisualStyleBackColor = true;
            this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
            // 
            // Tit_TB
            // 
            this.Tit_TB.Location = new System.Drawing.Point(79, 59);
            this.Tit_TB.Name = "Tit_TB";
            this.Tit_TB.Size = new System.Drawing.Size(493, 20);
            this.Tit_TB.TabIndex = 2;
            this.Tit_TB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Текст: ";
            // 
            // Text_TB
            // 
            this.Text_TB.Location = new System.Drawing.Point(79, 94);
            this.Text_TB.Multiline = true;
            this.Text_TB.Name = "Text_TB";
            this.Text_TB.Size = new System.Drawing.Size(493, 169);
            this.Text_TB.TabIndex = 4;
            // 
            // Send_BTN
            // 
            this.Send_BTN.Location = new System.Drawing.Point(504, 276);
            this.Send_BTN.Name = "Send_BTN";
            this.Send_BTN.Size = new System.Drawing.Size(75, 23);
            this.Send_BTN.TabIndex = 5;
            this.Send_BTN.Text = "Отправить";
            this.Send_BTN.UseVisualStyleBackColor = true;
            this.Send_BTN.Click += new System.EventHandler(this.Send_BTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(185, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Задать свой вопрос!";
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Send_BTN);
            this.Controls.Add(this.Text_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tit_TB);
            this.Controls.Add(this.Back_BTN);
            this.Controls.Add(this.label1);
            this.Name = "FeedBack";
            this.Text = "FeedBack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedBack_FormClosing);
            this.Load += new System.EventHandler(this.FeedBack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back_BTN;
        private System.Windows.Forms.TextBox Tit_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_TB;
        private System.Windows.Forms.Button Send_BTN;
        private System.Windows.Forms.Label label3;
    }
}