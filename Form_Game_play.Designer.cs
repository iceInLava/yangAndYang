namespace 鸡了个鸡
{
    partial class Form_Game_play
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Game_play));
            this.panel_result = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_restart = new System.Windows.Forms.Button();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.trackBar_effect = new System.Windows.Forms.TrackBar();
            this.lbl_effect_value = new System.Windows.Forms.Label();
            this.lbl_effect = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_back_to_title = new System.Windows.Forms.Button();
            this.lbl_volume_value = new System.Windows.Forms.Label();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.btn_continue = new System.Windows.Forms.Button();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_settings = new System.Windows.Forms.Button();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_score_value = new System.Windows.Forms.Label();
            this.wmp_bgm = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmp_effect = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_effect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_bgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_effect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_result
            // 
            this.panel_result.BackColor = System.Drawing.Color.Transparent;
            this.panel_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_result.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_result.Location = new System.Drawing.Point(156, 698);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(362, 59);
            this.panel_result.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_start.BackgroundImage")));
            this.btn_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_start.Location = new System.Drawing.Point(102, 807);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(150, 40);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "开始游戏";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_restart
            // 
            this.btn_restart.BackColor = System.Drawing.Color.Transparent;
            this.btn_restart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_restart.BackgroundImage")));
            this.btn_restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_restart.FlatAppearance.BorderSize = 0;
            this.btn_restart.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_restart.Location = new System.Drawing.Point(395, 807);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(150, 40);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "重新开始";
            this.btn_restart.UseVisualStyleBackColor = false;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.Color.Transparent;
            this.panel_content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_content.Location = new System.Drawing.Point(1, 50);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(632, 566);
            this.panel_content.TabIndex = 3;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.Black;
            this.panel_menu.BackgroundImage = global::鸡了个鸡.Properties.Resources.bg;
            this.panel_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.trackBar_effect);
            this.panel_menu.Controls.Add(this.lbl_effect_value);
            this.panel_menu.Controls.Add(this.lbl_effect);
            this.panel_menu.Controls.Add(this.btn_quit);
            this.panel_menu.Controls.Add(this.btn_back_to_title);
            this.panel_menu.Controls.Add(this.lbl_volume_value);
            this.panel_menu.Controls.Add(this.lbl_volume);
            this.panel_menu.Controls.Add(this.btn_continue);
            this.panel_menu.Controls.Add(this.trackBar_volume);
            this.panel_menu.Location = new System.Drawing.Point(42, 35);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(563, 657);
            this.panel_menu.TabIndex = 0;
            // 
            // trackBar_effect
            // 
            this.trackBar_effect.BackColor = System.Drawing.Color.YellowGreen;
            this.trackBar_effect.Location = new System.Drawing.Point(166, 274);
            this.trackBar_effect.Name = "trackBar_effect";
            this.trackBar_effect.Size = new System.Drawing.Size(244, 45);
            this.trackBar_effect.TabIndex = 8;
            // 
            // lbl_effect_value
            // 
            this.lbl_effect_value.AutoSize = true;
            this.lbl_effect_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_effect_value.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_effect_value.Location = new System.Drawing.Point(421, 274);
            this.lbl_effect_value.Name = "lbl_effect_value";
            this.lbl_effect_value.Size = new System.Drawing.Size(29, 19);
            this.lbl_effect_value.TabIndex = 7;
            this.lbl_effect_value.Text = "10";
            // 
            // lbl_effect
            // 
            this.lbl_effect.AutoSize = true;
            this.lbl_effect.BackColor = System.Drawing.Color.Transparent;
            this.lbl_effect.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_effect.Location = new System.Drawing.Point(121, 274);
            this.lbl_effect.Name = "lbl_effect";
            this.lbl_effect.Size = new System.Drawing.Size(39, 16);
            this.lbl_effect.TabIndex = 6;
            this.lbl_effect.Text = "音效";
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Transparent;
            this.btn_quit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_quit.BackgroundImage")));
            this.btn_quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quit.FlatAppearance.BorderSize = 0;
            this.btn_quit.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_quit.Location = new System.Drawing.Point(353, 563);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(135, 40);
            this.btn_quit.TabIndex = 5;
            this.btn_quit.Text = "退出游戏";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_back_to_title
            // 
            this.btn_back_to_title.BackColor = System.Drawing.Color.Transparent;
            this.btn_back_to_title.BackgroundImage = global::鸡了个鸡.Properties.Resources.btn_bg;
            this.btn_back_to_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back_to_title.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back_to_title.FlatAppearance.BorderSize = 0;
            this.btn_back_to_title.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_back_to_title.Location = new System.Drawing.Point(84, 563);
            this.btn_back_to_title.Name = "btn_back_to_title";
            this.btn_back_to_title.Size = new System.Drawing.Size(135, 40);
            this.btn_back_to_title.TabIndex = 4;
            this.btn_back_to_title.Text = "返回标题页";
            this.btn_back_to_title.UseVisualStyleBackColor = true;
            this.btn_back_to_title.Click += new System.EventHandler(this.btn_back_to_title_Click);
            // 
            // lbl_volume_value
            // 
            this.lbl_volume_value.AutoSize = true;
            this.lbl_volume_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume_value.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_volume_value.Location = new System.Drawing.Point(421, 193);
            this.lbl_volume_value.Name = "lbl_volume_value";
            this.lbl_volume_value.Size = new System.Drawing.Size(29, 19);
            this.lbl_volume_value.TabIndex = 3;
            this.lbl_volume_value.Text = "10";
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.BackColor = System.Drawing.Color.Transparent;
            this.lbl_volume.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_volume.Location = new System.Drawing.Point(121, 193);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(39, 16);
            this.lbl_volume.TabIndex = 2;
            this.lbl_volume.Text = "音量";
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.Color.Transparent;
            this.btn_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_continue.BackgroundImage")));
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_continue.FlatAppearance.BorderSize = 0;
            this.btn_continue.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_continue.Location = new System.Drawing.Point(443, 0);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(120, 40);
            this.btn_continue.TabIndex = 1;
            this.btn_continue.Text = "继续游戏";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.BackColor = System.Drawing.Color.YellowGreen;
            this.trackBar_volume.Location = new System.Drawing.Point(166, 193);
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(244, 45);
            this.trackBar_volume.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_settings.Location = new System.Drawing.Point(12, 7);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(120, 30);
            this.btn_settings.TabIndex = 4;
            this.btn_settings.Text = "暂停";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click_1);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_score.Location = new System.Drawing.Point(490, 13);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(72, 19);
            this.lbl_score.TabIndex = 5;
            this.lbl_score.Text = "分数：";
            // 
            // lbl_score_value
            // 
            this.lbl_score_value.AutoSize = true;
            this.lbl_score_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score_value.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_score_value.Location = new System.Drawing.Point(568, 13);
            this.lbl_score_value.Name = "lbl_score_value";
            this.lbl_score_value.Size = new System.Drawing.Size(20, 19);
            this.lbl_score_value.TabIndex = 6;
            this.lbl_score_value.Text = "0";
            // 
            // wmp_bgm
            // 
            this.wmp_bgm.Enabled = true;
            this.wmp_bgm.Location = new System.Drawing.Point(330, -1);
            this.wmp_bgm.Name = "wmp_bgm";
            this.wmp_bgm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_bgm.OcxState")));
            this.wmp_bgm.Size = new System.Drawing.Size(140, 33);
            this.wmp_bgm.TabIndex = 0;
            this.wmp_bgm.Visible = false;
            // 
            // wmp_effect
            // 
            this.wmp_effect.Enabled = true;
            this.wmp_effect.Location = new System.Drawing.Point(175, -2);
            this.wmp_effect.Name = "wmp_effect";
            this.wmp_effect.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp_effect.OcxState")));
            this.wmp_effect.Size = new System.Drawing.Size(137, 34);
            this.wmp_effect.TabIndex = 7;
            this.wmp_effect.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::鸡了个鸡.Properties.Resources.bottom;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(29, 584);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 233);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Game_play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::鸡了个鸡.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.panel_result);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.wmp_effect);
            this.Controls.Add(this.lbl_score_value);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.wmp_bgm);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Game_play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "阳了个阳";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Game_play_FormClosing);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_effect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_bgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp_effect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel_result;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer wmp_bgm;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_score_value;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Label lbl_volume_value;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Button btn_back_to_title;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lbl_effect_value;
        private System.Windows.Forms.Label lbl_effect;
        private System.Windows.Forms.TrackBar trackBar_effect;
        private AxWMPLib.AxWindowsMediaPlayer wmp_effect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}