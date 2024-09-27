namespace ProjBase1
{
    partial class Form4
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
            this.nomeUsuario = new System.Windows.Forms.TextBox();
            this.new_post = new System.Windows.Forms.Button();
            this.PostText = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Enabled = false;
            this.nomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUsuario.Location = new System.Drawing.Point(318, 58);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(351, 32);
            this.nomeUsuario.TabIndex = 3;
            this.nomeUsuario.TextChanged += new System.EventHandler(this.nomeUsuario_TextChanged);
            // 
            // new_post
            // 
            this.new_post.Location = new System.Drawing.Point(90, 230);
            this.new_post.Name = "new_post";
            this.new_post.Size = new System.Drawing.Size(94, 51);
            this.new_post.TabIndex = 4;
            this.new_post.Text = "Postar";
            this.new_post.UseVisualStyleBackColor = true;
            this.new_post.Click += new System.EventHandler(this.new_post_Click);
            // 
            // PostText
            // 
            this.PostText.AutoScroll = true;
            this.PostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostText.Location = new System.Drawing.Point(301, 150);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(431, 287);
            this.PostText.TabIndex = 5;
            this.PostText.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(90, 312);
            this.home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(56, 19);
            this.home.TabIndex = 6;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(78, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 137);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjBase1.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(-191, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(534, 500);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home);
            this.Controls.Add(this.PostText);
            this.Controls.Add(this.new_post);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomeUsuario;
        private System.Windows.Forms.Button new_post;
        private System.Windows.Forms.Panel PostText;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}