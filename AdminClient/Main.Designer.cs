namespace AdminClient
{
    partial class Main
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
            this.CreatePost_BTN = new System.Windows.Forms.Button();
            this.Title_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Imortant_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Text_TB = new System.Windows.Forms.TextBox();
            this.FeedBack_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePost_BTN
            // 
            this.CreatePost_BTN.Location = new System.Drawing.Point(49, 12);
            this.CreatePost_BTN.Name = "CreatePost_BTN";
            this.CreatePost_BTN.Size = new System.Drawing.Size(215, 73);
            this.CreatePost_BTN.TabIndex = 0;
            this.CreatePost_BTN.Text = "СОЗДАТЬ";
            this.CreatePost_BTN.UseVisualStyleBackColor = true;
            this.CreatePost_BTN.Click += new System.EventHandler(this.CreatePost_BTN_Click);
            // 
            // Title_TB
            // 
            this.Title_TB.Location = new System.Drawing.Point(12, 133);
            this.Title_TB.Name = "Title_TB";
            this.Title_TB.Size = new System.Drawing.Size(100, 20);
            this.Title_TB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тема";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(170, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Важность";
            // 
            // Imortant_TB
            // 
            this.Imortant_TB.Location = new System.Drawing.Point(169, 133);
            this.Imortant_TB.Name = "Imortant_TB";
            this.Imortant_TB.Size = new System.Drawing.Size(100, 20);
            this.Imortant_TB.TabIndex = 3;
            this.Imortant_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Imortant_TB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(261, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Текст";
            // 
            // Text_TB
            // 
            this.Text_TB.Location = new System.Drawing.Point(12, 192);
            this.Text_TB.Multiline = true;
            this.Text_TB.Name = "Text_TB";
            this.Text_TB.Size = new System.Drawing.Size(560, 108);
            this.Text_TB.TabIndex = 5;
            this.Text_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text_TB_KeyPress);
            // 
            // FeedBack_BTN
            // 
            this.FeedBack_BTN.Location = new System.Drawing.Point(353, 12);
            this.FeedBack_BTN.Name = "FeedBack_BTN";
            this.FeedBack_BTN.Size = new System.Drawing.Size(203, 73);
            this.FeedBack_BTN.TabIndex = 7;
            this.FeedBack_BTN.Text = "Показать отзывы Учителей";
            this.FeedBack_BTN.UseVisualStyleBackColor = true;
            this.FeedBack_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 312);
            this.Controls.Add(this.FeedBack_BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Text_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imortant_TB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title_TB);
            this.Controls.Add(this.CreatePost_BTN);
            this.Name = "Main";
            this.Text = "Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePost_BTN;
        private System.Windows.Forms.TextBox Title_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Imortant_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Text_TB;
        private System.Windows.Forms.Button FeedBack_BTN;
    }
}

