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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_level1 = new System.Windows.Forms.Button();
            this.btn_level2 = new System.Windows.Forms.Button();
            this.btn_level3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_level1
            // 
            this.btn_level1.BackColor = System.Drawing.Color.Transparent;
            this.btn_level1.BackgroundImage = global::鸡了个鸡.Properties.Resources.btn_bg;
            this.btn_level1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_level1.FlatAppearance.BorderSize = 0;
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
            this.btn_level2.BackColor = System.Drawing.Color.Transparent;
            this.btn_level2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_level2.BackgroundImage")));
            this.btn_level2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_level2.FlatAppearance.BorderSize = 0;
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
            this.btn_level3.BackColor = System.Drawing.Color.Transparent;
            this.btn_level3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_level3.BackgroundImage")));
            this.btn_level3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_level3.FlatAppearance.BorderSize = 0;
            this.btn_level3.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_level3.Location = new System.Drawing.Point(208, 567);
            this.btn_level3.Name = "btn_level3";
            this.btn_level3.Size = new System.Drawing.Size(200, 50);
            this.btn_level3.TabIndex = 3;
            this.btn_level3.Text = "第三关";
            this.btn_level3.UseVisualStyleBackColor = false;
            this.btn_level3.Click += new System.EventHandler(this.btn_level3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::鸡了个鸡.Properties.Resources.mainFormBG;
            this.ClientSize = new System.Drawing.Size(634, 861);
            this.Controls.Add(this.btn_level3);
            this.Controls.Add(this.btn_level2);
            this.Controls.Add(this.btn_level1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "只因了个只因";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_level1;
        private System.Windows.Forms.Button btn_level2;
        private System.Windows.Forms.Button btn_level3;
    }
}