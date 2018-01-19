namespace TeacherClient
{
    partial class Main_form
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
            this.MenuBar_panel = new System.Windows.Forms.Panel();
            this.MenuBarChoosed_Panel = new System.Windows.Forms.Panel();
            this.logo_panel = new System.Windows.Forms.Panel();
            this.info_panel = new System.Windows.Forms.Panel();
            this.Posts_panel = new System.Windows.Forms.Panel();
            this.ShowPost_Panel = new System.Windows.Forms.Panel();
            this.PostAuthor_Label = new System.Windows.Forms.Label();
            this.PostText_TextBox = new System.Windows.Forms.TextBox();
            this.PostTitle_label = new System.Windows.Forms.Label();
            this.PostsOnlyTitles_Panel = new System.Windows.Forms.Panel();
            this.PostsFolders_Panel = new System.Windows.Forms.Panel();
            this.PostsFolsersTitle_label = new System.Windows.Forms.Label();
            this.PostsFoldersChoosed_panel = new System.Windows.Forms.Panel();
            this.AllPostsShow_Button = new System.Windows.Forms.Button();
            this.NewPostsShow_Button = new System.Windows.Forms.Button();
            this.PostFrom_Label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Importancy_Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title_Label = new System.Windows.Forms.Label();
            this.HidePostPanel_Button = new System.Windows.Forms.Button();
            this.TeacherProfile_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SettingsShow_Button = new System.Windows.Forms.Button();
            this.FeedBackShow_Button = new System.Windows.Forms.Button();
            this.PostsShow_Button = new System.Windows.Forms.Button();
            this.MenuBar_panel.SuspendLayout();
            this.info_panel.SuspendLayout();
            this.Posts_panel.SuspendLayout();
            this.ShowPost_Panel.SuspendLayout();
            this.PostsOnlyTitles_Panel.SuspendLayout();
            this.PostsFolders_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar_panel
            // 
            this.MenuBar_panel.Controls.Add(this.MenuBarChoosed_Panel);
            this.MenuBar_panel.Controls.Add(this.SettingsShow_Button);
            this.MenuBar_panel.Controls.Add(this.FeedBackShow_Button);
            this.MenuBar_panel.Controls.Add(this.PostsShow_Button);
            this.MenuBar_panel.Controls.Add(this.logo_panel);
            this.MenuBar_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBar_panel.Location = new System.Drawing.Point(0, 0);
            this.MenuBar_panel.Name = "MenuBar_panel";
            this.MenuBar_panel.Size = new System.Drawing.Size(184, 632);
            this.MenuBar_panel.TabIndex = 0;
            // 
            // MenuBarChoosed_Panel
            // 
            this.MenuBarChoosed_Panel.BackColor = System.Drawing.Color.White;
            this.MenuBarChoosed_Panel.ForeColor = System.Drawing.Color.White;
            this.MenuBarChoosed_Panel.Location = new System.Drawing.Point(12, 135);
            this.MenuBarChoosed_Panel.Name = "MenuBarChoosed_Panel";
            this.MenuBarChoosed_Panel.Size = new System.Drawing.Size(10, 100);
            this.MenuBarChoosed_Panel.TabIndex = 4;
            // 
            // logo_panel
            // 
            this.logo_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_panel.Location = new System.Drawing.Point(0, 0);
            this.logo_panel.Name = "logo_panel";
            this.logo_panel.Size = new System.Drawing.Size(184, 128);
            this.logo_panel.TabIndex = 0;
            // 
            // info_panel
            // 
            this.info_panel.Controls.Add(this.TeacherProfile_Button);
            this.info_panel.Controls.Add(this.Exit_Button);
            this.info_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.info_panel.Location = new System.Drawing.Point(184, 0);
            this.info_panel.Name = "info_panel";
            this.info_panel.Size = new System.Drawing.Size(1170, 84);
            this.info_panel.TabIndex = 1;
            // 
            // Posts_panel
            // 
            this.Posts_panel.AutoScroll = true;
            this.Posts_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.Posts_panel.Controls.Add(this.ShowPost_Panel);
            this.Posts_panel.Controls.Add(this.PostsFolders_Panel);
            this.Posts_panel.Controls.Add(this.PostFrom_Label);
            this.Posts_panel.Controls.Add(this.panel3);
            this.Posts_panel.Controls.Add(this.label1);
            this.Posts_panel.Controls.Add(this.panel2);
            this.Posts_panel.Controls.Add(this.Importancy_Label);
            this.Posts_panel.Controls.Add(this.panel1);
            this.Posts_panel.Controls.Add(this.Title_Label);
            this.Posts_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Posts_panel.Location = new System.Drawing.Point(184, 84);
            this.Posts_panel.Name = "Posts_panel";
            this.Posts_panel.Size = new System.Drawing.Size(1170, 548);
            this.Posts_panel.TabIndex = 2;
            // 
            // ShowPost_Panel
            // 
            this.ShowPost_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.ShowPost_Panel.Controls.Add(this.PostAuthor_Label);
            this.ShowPost_Panel.Controls.Add(this.PostText_TextBox);
            this.ShowPost_Panel.Controls.Add(this.PostTitle_label);
            this.ShowPost_Panel.Controls.Add(this.PostsOnlyTitles_Panel);
            this.ShowPost_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowPost_Panel.Location = new System.Drawing.Point(145, 0);
            this.ShowPost_Panel.Name = "ShowPost_Panel";
            this.ShowPost_Panel.Size = new System.Drawing.Size(1025, 548);
            this.ShowPost_Panel.TabIndex = 18;
            this.ShowPost_Panel.Visible = false;
            // 
            // PostAuthor_Label
            // 
            this.PostAuthor_Label.AutoSize = true;
            this.PostAuthor_Label.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostAuthor_Label.ForeColor = System.Drawing.Color.White;
            this.PostAuthor_Label.Location = new System.Drawing.Point(172, 75);
            this.PostAuthor_Label.Name = "PostAuthor_Label";
            this.PostAuthor_Label.Size = new System.Drawing.Size(159, 30);
            this.PostAuthor_Label.TabIndex = 10;
            this.PostAuthor_Label.Text = "Jame Johnson";
            // 
            // PostText_TextBox
            // 
            this.PostText_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(89)))));
            this.PostText_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PostText_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostText_TextBox.ForeColor = System.Drawing.Color.White;
            this.PostText_TextBox.Location = new System.Drawing.Point(169, 181);
            this.PostText_TextBox.Multiline = true;
            this.PostText_TextBox.Name = "PostText_TextBox";
            this.PostText_TextBox.Size = new System.Drawing.Size(844, 355);
            this.PostText_TextBox.TabIndex = 9;
            this.PostText_TextBox.Text = "Текст, Текст, Текст";
            // 
            // PostTitle_label
            // 
            this.PostTitle_label.AutoSize = true;
            this.PostTitle_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostTitle_label.ForeColor = System.Drawing.Color.White;
            this.PostTitle_label.Location = new System.Drawing.Point(537, 30);
            this.PostTitle_label.Name = "PostTitle_label";
            this.PostTitle_label.Size = new System.Drawing.Size(69, 30);
            this.PostTitle_label.TabIndex = 8;
            this.PostTitle_label.Text = "Тема";
            // 
            // PostsOnlyTitles_Panel
            // 
            this.PostsOnlyTitles_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.PostsOnlyTitles_Panel.Controls.Add(this.HidePostPanel_Button);
            this.PostsOnlyTitles_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PostsOnlyTitles_Panel.Location = new System.Drawing.Point(0, 0);
            this.PostsOnlyTitles_Panel.Name = "PostsOnlyTitles_Panel";
            this.PostsOnlyTitles_Panel.Size = new System.Drawing.Size(160, 548);
            this.PostsOnlyTitles_Panel.TabIndex = 0;
            // 
            // PostsFolders_Panel
            // 
            this.PostsFolders_Panel.AutoScroll = true;
            this.PostsFolders_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.PostsFolders_Panel.Controls.Add(this.PostsFolsersTitle_label);
            this.PostsFolders_Panel.Controls.Add(this.PostsFoldersChoosed_panel);
            this.PostsFolders_Panel.Controls.Add(this.AllPostsShow_Button);
            this.PostsFolders_Panel.Controls.Add(this.NewPostsShow_Button);
            this.PostsFolders_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PostsFolders_Panel.Location = new System.Drawing.Point(0, 0);
            this.PostsFolders_Panel.Name = "PostsFolders_Panel";
            this.PostsFolders_Panel.Size = new System.Drawing.Size(145, 548);
            this.PostsFolders_Panel.TabIndex = 1;
            // 
            // PostsFolsersTitle_label
            // 
            this.PostsFolsersTitle_label.AutoSize = true;
            this.PostsFolsersTitle_label.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostsFolsersTitle_label.ForeColor = System.Drawing.Color.White;
            this.PostsFolsersTitle_label.Location = new System.Drawing.Point(27, 30);
            this.PostsFolsersTitle_label.Name = "PostsFolsersTitle_label";
            this.PostsFolsersTitle_label.Size = new System.Drawing.Size(81, 30);
            this.PostsFolsersTitle_label.TabIndex = 6;
            this.PostsFolsersTitle_label.Text = "Папки";
            // 
            // PostsFoldersChoosed_panel
            // 
            this.PostsFoldersChoosed_panel.BackColor = System.Drawing.Color.White;
            this.PostsFoldersChoosed_panel.ForeColor = System.Drawing.Color.White;
            this.PostsFoldersChoosed_panel.Location = new System.Drawing.Point(12, 91);
            this.PostsFoldersChoosed_panel.Name = "PostsFoldersChoosed_panel";
            this.PostsFoldersChoosed_panel.Size = new System.Drawing.Size(10, 60);
            this.PostsFoldersChoosed_panel.TabIndex = 5;
            // 
            // AllPostsShow_Button
            // 
            this.AllPostsShow_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AllPostsShow_Button.FlatAppearance.BorderSize = 0;
            this.AllPostsShow_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllPostsShow_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllPostsShow_Button.ForeColor = System.Drawing.Color.White;
            this.AllPostsShow_Button.Location = new System.Drawing.Point(12, 91);
            this.AllPostsShow_Button.Name = "AllPostsShow_Button";
            this.AllPostsShow_Button.Size = new System.Drawing.Size(110, 60);
            this.AllPostsShow_Button.TabIndex = 2;
            this.AllPostsShow_Button.Text = "Все";
            this.AllPostsShow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AllPostsShow_Button.UseVisualStyleBackColor = true;
            this.AllPostsShow_Button.Click += new System.EventHandler(this.AllPostsShow_Button_Click);
            // 
            // NewPostsShow_Button
            // 
            this.NewPostsShow_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NewPostsShow_Button.FlatAppearance.BorderSize = 0;
            this.NewPostsShow_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewPostsShow_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPostsShow_Button.ForeColor = System.Drawing.Color.White;
            this.NewPostsShow_Button.Location = new System.Drawing.Point(12, 170);
            this.NewPostsShow_Button.Name = "NewPostsShow_Button";
            this.NewPostsShow_Button.Size = new System.Drawing.Size(110, 60);
            this.NewPostsShow_Button.TabIndex = 1;
            this.NewPostsShow_Button.Text = "Новые";
            this.NewPostsShow_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NewPostsShow_Button.UseVisualStyleBackColor = true;
            this.NewPostsShow_Button.Click += new System.EventHandler(this.NewPostsShow_Button_Click);
            // 
            // PostFrom_Label
            // 
            this.PostFrom_Label.AutoSize = true;
            this.PostFrom_Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostFrom_Label.ForeColor = System.Drawing.Color.Silver;
            this.PostFrom_Label.Location = new System.Drawing.Point(224, 17);
            this.PostFrom_Label.Name = "PostFrom_Label";
            this.PostFrom_Label.Size = new System.Drawing.Size(34, 26);
            this.PostFrom_Label.TabIndex = 17;
            this.PostFrom_Label.Text = "От";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(381, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(1038, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дата";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(965, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 14;
            // 
            // Importancy_Label
            // 
            this.Importancy_Label.AutoSize = true;
            this.Importancy_Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Importancy_Label.ForeColor = System.Drawing.Color.Silver;
            this.Importancy_Label.Location = new System.Drawing.Point(783, 17);
            this.Importancy_Label.Name = "Importancy_Label";
            this.Importancy_Label.Size = new System.Drawing.Size(101, 26);
            this.Importancy_Label.TabIndex = 13;
            this.Importancy_Label.Text = "Важность";
            this.Importancy_Label.Click += new System.EventHandler(this.Importancy_Label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(687, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 12;
            // 
            // Title_Label
            // 
            this.Title_Label.AutoSize = true;
            this.Title_Label.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title_Label.ForeColor = System.Drawing.Color.Silver;
            this.Title_Label.Location = new System.Drawing.Point(497, 17);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(59, 26);
            this.Title_Label.TabIndex = 11;
            this.Title_Label.Text = "Тема";
            this.Title_Label.Click += new System.EventHandler(this.Title_Label_Click);
            // 
            // HidePostPanel_Button
            // 
            this.HidePostPanel_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HidePostPanel_Button.FlatAppearance.BorderSize = 0;
            this.HidePostPanel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HidePostPanel_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HidePostPanel_Button.ForeColor = System.Drawing.Color.White;
            this.HidePostPanel_Button.Image = global::TeacherClient.Properties.Resources.left_arrow__1_;
            this.HidePostPanel_Button.Location = new System.Drawing.Point(3, 12);
            this.HidePostPanel_Button.Name = "HidePostPanel_Button";
            this.HidePostPanel_Button.Size = new System.Drawing.Size(150, 64);
            this.HidePostPanel_Button.TabIndex = 3;
            this.HidePostPanel_Button.Text = "Все письма";
            this.HidePostPanel_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HidePostPanel_Button.UseVisualStyleBackColor = true;
            this.HidePostPanel_Button.Click += new System.EventHandler(this.HidePostPanel_Button_Click);
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
            this.TeacherProfile_Button.Text = "Фамлия Имя";
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
            this.FeedBackShow_Button.Click += new System.EventHandler(this.FeedBackShow_Button_Click);
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
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1354, 632);
            this.Controls.Add(this.Posts_panel);
            this.Controls.Add(this.info_panel);
            this.Controls.Add(this.MenuBar_panel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Главная";
            this.MenuBar_panel.ResumeLayout(false);
            this.info_panel.ResumeLayout(false);
            this.Posts_panel.ResumeLayout(false);
            this.Posts_panel.PerformLayout();
            this.ShowPost_Panel.ResumeLayout(false);
            this.ShowPost_Panel.PerformLayout();
            this.PostsOnlyTitles_Panel.ResumeLayout(false);
            this.PostsFolders_Panel.ResumeLayout(false);
            this.PostsFolders_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuBar_panel;
        private System.Windows.Forms.Panel info_panel;
        private System.Windows.Forms.Panel Posts_panel;
        private System.Windows.Forms.Panel logo_panel;
        private System.Windows.Forms.Button PostsShow_Button;
        private System.Windows.Forms.Button FeedBackShow_Button;
        private System.Windows.Forms.Button SettingsShow_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button TeacherProfile_Button;
        private System.Windows.Forms.Panel PostsFolders_Panel;
        private System.Windows.Forms.Button AllPostsShow_Button;
        private System.Windows.Forms.Button NewPostsShow_Button;
        private System.Windows.Forms.Panel MenuBarChoosed_Panel;
        private System.Windows.Forms.Label Title_Label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Importancy_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PostFrom_Label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PostsFoldersChoosed_panel;
        private System.Windows.Forms.Panel ShowPost_Panel;
        private System.Windows.Forms.Panel PostsOnlyTitles_Panel;
        private System.Windows.Forms.Label PostsFolsersTitle_label;
        private System.Windows.Forms.Label PostAuthor_Label;
        private System.Windows.Forms.TextBox PostText_TextBox;
        private System.Windows.Forms.Label PostTitle_label;
        private System.Windows.Forms.Button HidePostPanel_Button;
    }
}

