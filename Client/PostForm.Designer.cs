namespace Client
{
    partial class PostForm
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
            this.Back_But = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.Text_TB = new System.Windows.Forms.TextBox();
            this.Important_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back_But
            // 
            this.Back_But.Location = new System.Drawing.Point(12, 12);
            this.Back_But.Name = "Back_But";
            this.Back_But.Size = new System.Drawing.Size(75, 23);
            this.Back_But.TabIndex = 0;
            this.Back_But.Text = "Назад";
            this.Back_But.UseVisualStyleBackColor = true;
            this.Back_But.Click += new System.EventHandler(this.Back_But_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_label.Location = new System.Drawing.Point(12, 53);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(43, 20);
            this.Title_label.TabIndex = 1;
            this.Title_label.Text = "Title";
            // 
            // Text_TB
            // 
            this.Text_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_TB.Location = new System.Drawing.Point(12, 97);
            this.Text_TB.Multiline = true;
            this.Text_TB.Name = "Text_TB";
            this.Text_TB.ReadOnly = true;
            this.Text_TB.Size = new System.Drawing.Size(560, 182);
            this.Text_TB.TabIndex = 2;
            this.Text_TB.Text = "TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT T" +
    "EXT TEXT TEXT TEXT\r\nTEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT " +
    "TEXT TEXT TEXT TEXT TEXT TEXT TEXT TEXT";
            // 
            // Important_label
            // 
            this.Important_label.AutoSize = true;
            this.Important_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Important_label.Location = new System.Drawing.Point(206, 53);
            this.Important_label.Name = "Important_label";
            this.Important_label.Size = new System.Drawing.Size(19, 20);
            this.Important_label.TabIndex = 3;
            this.Important_label.Text = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(489, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Проблемы?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_Label.Location = new System.Drawing.Point(384, 53);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(99, 20);
            this.Date_Label.TabIndex = 7;
            this.Date_Label.Text = "11.11.1111";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Important_label);
            this.Controls.Add(this.Text_TB);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Back_But);
            this.Name = "PostForm";
            this.Text = "PostForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostForm_FormClosed);
            this.Load += new System.EventHandler(this.PostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_But;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.TextBox Text_TB;
        private System.Windows.Forms.Label Important_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Date_Label;
    }
}