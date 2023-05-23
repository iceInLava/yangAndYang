namespace 鸡了个鸡
{
    partial class Form1
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_level1 = new System.Windows.Forms.Button();
            this.btn_level2 = new System.Windows.Forms.Button();
            this.btn_level3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_welcome.Font = new System.Drawing.Font("幼圆", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_welcome.Location = new System.Drawing.Point(77, 201);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(480, 56);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "欢迎体验鸡了个鸡";
            // 
            // btn_level1
            // 
            this.btn_level1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_level1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_level1.Location = new System.Drawing.Point(208, 394);
            this.btn_level1.Name = "btn_level1";
            this.btn_level1.Size = new System.Drawing.Size(200, 50);
            this.btn_level1.TabIndex = 1;
            this.btn_level1.Text = "第一关";
            this.btn_level1.UseVisualStyleBackColor = false;
            this.btn_level1.Click += new System.EventHandler(this.btn_level1_Click);
            // 
            // btn_level2
            // 
            this.btn_level2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_level2.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_level2.Location = new System.Drawing.Point(208, 481);
            this.btn_level2.Name = "btn_level2";
            this.btn_level2.Size = new System.Drawing.Size(200, 50);
            this.btn_level2.TabIndex = 2;
            this.btn_level2.Text = "第二关";
            this.btn_level2.UseVisualStyleBackColor = false;
            this.btn_level2.Click += new System.EventHandler(this.btn_level2_Click);
            // 
            // btn_level3
            // 
            this.btn_level3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_level3.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_level3.Location = new System.Drawing.Point(208, 567);
            this.btn_level3.Name = "btn_level3";
            this.btn_level3.Size = new System.Drawing.Size(200, 50);
            this.btn_level3.TabIndex = 3;
            this.btn_level3.Text = "第三关";
            this.btn_level3.UseVisualStyleBackColor = false;
            this.btn_level3.Click += new System.EventHandler(this.btn_level3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::鸡了个鸡.Properties.Resources.R_C;
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 189);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::鸡了个鸡.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_level3);
            this.Controls.Add(this.btn_level2);
            this.Controls.Add(this.btn_level1);
            this.Controls.Add(this.lbl_welcome);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "只因了个只因";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_level1;
        private System.Windows.Forms.Button btn_level2;
        private System.Windows.Forms.Button btn_level3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}