namespace TeacherClient
{
    partial class OnlyTitlePostButton
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
            this.Title = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.FlatAppearance.BorderSize = 0;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(155, 50);
            this.Title.TabIndex = 5;
            this.Title.Text = "Сообщения";
            this.Title.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Title.UseVisualStyleBackColor = true;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // OnlyTitlePostButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.Title);
            this.Name = "OnlyTitlePostButton";
            this.Size = new System.Drawing.Size(155, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Title;
    }
}
