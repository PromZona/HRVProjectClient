namespace Client
{
    partial class PostControll
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.Important = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(3, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(43, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            this.Title.MouseEnter += new System.EventHandler(this.Title_MouseEnter);
            this.Title.MouseLeave += new System.EventHandler(this.Title_MouseLeave);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            // 
            // Important
            // 
            this.Important.AutoSize = true;
            this.Important.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Important.Location = new System.Drawing.Point(446, 5);
            this.Important.Name = "Important";
            this.Important.Size = new System.Drawing.Size(87, 20);
            this.Important.TabIndex = 1;
            this.Important.Text = "Important";
            this.Important.Click += new System.EventHandler(this.Important_Click);
            this.Important.MouseEnter += new System.EventHandler(this.Important_MouseEnter);
            this.Important.MouseLeave += new System.EventHandler(this.Important_MouseLeave);
            this.Important.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Important_MouseMove);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(621, 5);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 20);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            this.Date.MouseEnter += new System.EventHandler(this.Date_MouseEnter);
            this.Date.MouseLeave += new System.EventHandler(this.Date_MouseLeave);
            this.Date.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Date_MouseMove);
            // 
            // PostControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Important);
            this.Controls.Add(this.Title);
            this.Name = "PostControll";
            this.Size = new System.Drawing.Size(735, 35);
            this.Load += new System.EventHandler(this.Post_Load);
            this.Click += new System.EventHandler(this.PostControll_Click);
            this.DoubleClick += new System.EventHandler(this.PostControll_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.PostControll_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PostControll_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PostControll_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Important;
        public System.Windows.Forms.Label Date;
    }
}
