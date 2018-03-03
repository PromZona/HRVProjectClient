namespace TeacherClient
{
    partial class Question
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
            this.MenuBar_panel = new System.Windows.Forms.Panel();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.MenuBarChoosed_Panel = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.WorkArea_Panel = new System.Windows.Forms.Panel();
            this.Sucess_label = new System.Windows.Forms.Label();
            this.Text_label = new System.Windows.Forms.Label();
            this.Text_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title_TextBox = new System.Windows.Forms.TextBox();
            this.AskQuestion_label = new System.Windows.Forms.Label();
            this.SendQuestion_Button = new System.Windows.Forms.Button();
            this.TeacherProfile_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SettingsShow_Button = new System.Windows.Forms.Button();
            this.FeedBackShow_Button = new System.Windows.Forms.Button();
            this.PostsShow_Button = new System.Windows.Forms.Button();
            this.MenuBar_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.WorkArea_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar_panel
            // 
            this.MenuBar_panel.Controls.Add(this.logo_panel);
            this.MenuBar_panel.Controls.Add(this.MenuBarChoosed_Panel);
            this.MenuBar_panel.Controls.Add(this.SettingsShow_Button);
            this.MenuBar_panel.Controls.Add(this.FeedBackShow_Button);
            this.MenuBar_panel.Controls.Add(this.PostsShow_Button);
            this.MenuBar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar_panel.Location = new System.Drawing.Point(0, 0);
            this.MenuBar_panel.Name = "MenuBar_panel";
            this.MenuBar_panel.Size = new System.Drawing.Size(184, 632);
            this.MenuBar_panel.TabIndex = 3;
            this.MenuBar_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuBar_panel_Paint);
            // 
            // logo_panel
            // 
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(184, 128);
            this.logo_panel.TabIndex = 5;
            this.logo_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.logo_panel_Paint);
            // 
            // MenuBarChoosed_Panel
            // 
            this.MenuBarChoosed_Panel.BackColor = System.Drawing.Color.White;
            this.MenuBarChoosed_Panel.ForeColor = System.Drawing.Color.White;
            this.MenuBarChoosed_Panel.Location = new System.Drawing.Point(12, 265);
            this.MenuBarChoosed_Panel.Name = "MenuBarChoosed_Panel";
            this.MenuBarChoosed_Panel.Size = new System.Drawing.Size(10, 100);
            this.MenuBarChoosed_Panel.TabIndex = 4;
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.TeacherProfile_Button);
            this.info_panel.Controls.Add(this.Exit_Button);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Location = new System.Drawing.Point(184, 0);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(1170, 84);
            this.info_panel.TabIndex = 4;
            this.info_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.info_panel_Paint);
            // 
            // WorkArea_Panel
            // 
            this.WorkArea_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.WorkArea_Panel.Controls.Add(this.Sucess_label);
            this.WorkArea_Panel.Controls.Add(this.SendQuestion_Button);
            this.WorkArea_Panel.Controls.Add(this.Text_label);
            this.WorkArea_Panel.Controls.Add(this.Text_TextBox);
            this.WorkArea_Panel.Controls.Add(this.label1);
            this.WorkArea_Panel.Controls.Add(this.Title_TextBox);
            this.WorkArea_Panel.Controls.Add(this.AskQuestion_label);
            this.WorkArea_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkArea_Panel.Location = new System.Drawing.Point(184, 84);
            this.WorkArea_Panel.Name = "WorkArea_Panel";
            this.WorkArea_Panel.Size = new System.Drawing.Size(1170, 548);
            this.WorkArea_Panel.TabIndex = 5;
            // 
            // Sucess_label
            // 
            this.Sucess_label.AutoSize = true;
            this.Sucess_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sucess_label.ForeColor = System.Drawing.Color.White;
            this.Sucess_label.Location = new System.Drawing.Point(901, 181);
            this.Sucess_label.Name = "Sucess_label";
            this.Sucess_label.Size = new System.Drawing.Size(0, 26);
            this.Sucess_label.TabIndex = 15;
            // 
            // Text_label
            // 
            this.Text_label.AutoSize = true;
            this.Text_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.Text_label.ForeColor = System.Drawing.Color.White;
            this.Text_label.Location = new System.Drawing.Point(42, 181);
            this.Text_label.Name = "Text_label";
            this.Text_label.Size = new System.Drawing.Size(91, 28);
            this.Text_label.TabIndex = 13;
            this.Text_label.Text = "Вопрос:";
            // 
            // Text_TextBox
            // 
            this.Text_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.Text_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_TextBox.ForeColor = System.Drawing.Color.White;
            this.Text_TextBox.Location = new System.Drawing.Point(37, 219);
            this.Text_TextBox.Multiline = true;
            this.Text_TextBox.Name = "Text_TextBox";
            this.Text_TextBox.Size = new System.Drawing.Size(1107, 317);
            this.Text_TextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Тема:";
            // 
            // Title_TextBox
            // 
            this.Title_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.Title_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Title_TextBox.ForeColor = System.Drawing.Color.White;
            this.Title_TextBox.Location = new System.Drawing.Point(37, 124);
            this.Title_TextBox.Name = "Title_TextBox";
            this.Title_TextBox.Size = new System.Drawing.Size(353, 27);
            this.Title_TextBox.TabIndex = 10;
            // 
            // AskQuestion_label
            // 
            this.AskQuestion_label.AutoSize = true;
            this.AskQuestion_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskQuestion_label.ForeColor = System.Drawing.Color.White;
            this.AskQuestion_label.Location = new System.Drawing.Point(487, 51);
            this.AskQuestion_label.Name = "AskQuestion_label";
            this.AskQuestion_label.Size = new System.Drawing.Size(169, 30);
            this.AskQuestion_label.TabIndex = 9;
            this.AskQuestion_label.Text = "Задать вопрос";
            // 
            // SendQuestion_Button
            // 
            this.SendQuestion_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.SendQuestion_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendQuestion_Button.FlatAppearance.BorderSize = 0;
            this.SendQuestion_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendQuestion_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.SendQuestion_Button.ForeColor = System.Drawing.Color.White;
            this.SendQuestion_Button.Image = global::TeacherClient.Properties.Resources.forward_arrow;
            this.SendQuestion_Button.Location = new System.Drawing.Point(669, 107);
            this.SendQuestion_Button.Name = "SendQuestion_Button";
            this.SendQuestion_Button.Size = new System.Drawing.Size(193, 100);
            this.SendQuestion_Button.TabIndex = 14;
            this.SendQuestion_Button.Text = "Отправить";
            this.SendQuestion_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SendQuestion_Button.UseVisualStyleBackColor = false;
            this.SendQuestion_Button.Click += new System.EventHandler(this.SendQuestion_Button_Click);
            // 
            // TeacherProfile_Button
            // 
            this.TeacherProfile_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TeacherProfile_Button.FlatAppearance.BorderSize = 0;
            this.TeacherProfile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherProfile_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherProfile_Button.ForeColor = System.Drawing.Color.White;
            this.TeacherProfile_Button.Image = global::TeacherClient.Properties.Resources.avatar;
            this.TeacherProfile_Button.Location = new System.Drawing.Point(710, 3);
            this.TeacherProfile_Button.Name = "TeacherProfile_Button";
            this.TeacherProfile_Button.Size = new System.Drawing.Size(360, 75);
            this.TeacherProfile_Button.TabIndex = 4;
            this.TeacherProfile_Button.Text = "Сергей Есенин";
            this.TeacherProfile_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TeacherProfile_Button.UseVisualStyleBackColor = true;
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.Image = global::TeacherClient.Properties.Resources.exit;
            this.Exit_Button.Location = new System.Drawing.Point(1090, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(80, 78);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // SettingsShow_Button
            // 
            this.SettingsShow_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingsShow_Button.FlatAppearance.BorderSize = 0;
            this.SettingsShow_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsShow_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsShow_Button.ForeColor = System.Drawing.Color.White;
            this.SettingsShow_Button.Image = global::TeacherClient.Properties.Resources.settings;
            this.SettingsShow_Button.Location = new System.Drawing.Point(12, 520);
            this.SettingsShow_Button.Name = "SettingsShow_Button";
            this.SettingsShow_Button.Size = new System.Drawing.Size(166, 100);
            this.SettingsShow_Button.TabIndex = 3;
            this.SettingsShow_Button.Text = "Настройки";
            this.SettingsShow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingsShow_Button.UseVisualStyleBackColor = true;
            this.SettingsShow_Button.Click += new System.EventHandler(this.SettingsShow_Button_Click);
            // 
            // FeedBackShow_Button
            // 
            this.FeedBackShow_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FeedBackShow_Button.FlatAppearance.BorderSize = 0;
            this.FeedBackShow_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FeedBackShow_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FeedBackShow_Button.ForeColor = System.Drawing.Color.White;
            this.FeedBackShow_Button.Image = global::TeacherClient.Properties.Resources.question_sign;
            this.FeedBackShow_Button.Location = new System.Drawing.Point(12, 265);
            this.FeedBackShow_Button.Name = "FeedBackShow_Button";
            this.FeedBackShow_Button.Size = new System.Drawing.Size(166, 100);
            this.FeedBackShow_Button.TabIndex = 2;
            this.FeedBackShow_Button.Text = "Вопросы";
            this.FeedBackShow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.FeedBackShow_Button.UseVisualStyleBackColor = true;
            // 
            // PostsShow_Button
            // 
            this.PostsShow_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PostsShow_Button.FlatAppearance.BorderSize = 0;
            this.PostsShow_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PostsShow_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostsShow_Button.ForeColor = System.Drawing.Color.White;
            this.PostsShow_Button.Image = global::TeacherClient.Properties.Resources.envelope;
            this.PostsShow_Button.Location = new System.Drawing.Point(12, 135);
            this.PostsShow_Button.Name = "PostsShow_Button";
            this.PostsShow_Button.Size = new System.Drawing.Size(166, 100);
            this.PostsShow_Button.TabIndex = 0;
            this.PostsShow_Button.Text = "Сообщения";
            this.PostsShow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PostsShow_Button.UseVisualStyleBackColor = true;
            this.PostsShow_Button.Click += new System.EventHandler(this.PostsShow_Button_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1354, 632);
            this.Controls.Add(this.WorkArea_Panel);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.MenuBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Question";
            this.Text = "Question";
            this.MenuBar_panel.ResumeLayout(false);
            this.info_panel.ResumeLayout(false);
            this.WorkArea_Panel.ResumeLayout(false);
            this.WorkArea_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuBar_panel;
        private System.Windows.Forms.Panel MenuBarChoosed_Panel;
        private System.Windows.Forms.Button SettingsShow_Button;
        private System.Windows.Forms.Button FeedBackShow_Button;
        private System.Windows.Forms.Button PostsShow_Button;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Button TeacherProfile_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel WorkArea_Panel;
        private System.Windows.Forms.Label AskQuestion_label;
        private System.Windows.Forms.TextBox Title_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_TextBox;
        private System.Windows.Forms.Label Text_label;
        private System.Windows.Forms.Button SendQuestion_Button;
        private System.Windows.Forms.Label Sucess_label;
    }
}