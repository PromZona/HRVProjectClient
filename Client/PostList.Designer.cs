namespace Client
{
    partial class PostList
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
            this.Importancy = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.Location = new System.Drawing.Point(3, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(45, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // Importancy
            // 
            this.Importancy.AutoSize = true;
            this.Importancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Importancy.Location = new System.Drawing.Point(105, 9);
            this.Importancy.Name = "Importancy";
            this.Importancy.Size = new System.Drawing.Size(102, 24);
            this.Importancy.TabIndex = 1;
            this.Importancy.Text = "Importancy";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(264, 9);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(48, 24);
            this.Date.TabIndex = 2;
            this.Date.Text = "Date";
            // 
            // PostList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Importancy);
            this.Controls.Add(this.Title);
            this.Name = "PostList";
            this.Size = new System.Drawing.Size(358, 45);
            this.Load += new System.EventHandler(this.PostList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Importancy;
        private System.Windows.Forms.Label Date;
    }
}
