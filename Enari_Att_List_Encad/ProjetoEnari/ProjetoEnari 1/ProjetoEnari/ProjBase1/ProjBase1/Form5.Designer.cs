namespace ProjBase1
{
    partial class Form5
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
            this.Postar = new System.Windows.Forms.Button();
            this.PostText = new System.Windows.Forms.RichTextBox();
            this.foto = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Postar
            // 
            this.Postar.Location = new System.Drawing.Point(241, 282);
            this.Postar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Postar.Name = "Postar";
            this.Postar.Size = new System.Drawing.Size(90, 57);
            this.Postar.TabIndex = 0;
            this.Postar.Text = "Postar";
            this.Postar.UseVisualStyleBackColor = true;
            this.Postar.Click += new System.EventHandler(this.button1_Click);
            // 
            // PostText
            // 
            this.PostText.Location = new System.Drawing.Point(141, 164);
            this.PostText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(422, 80);
            this.PostText.TabIndex = 2;
            this.PostText.Text = "";
            this.PostText.TextChanged += new System.EventHandler(this.PostText_TextChanged);
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(362, 282);
            this.foto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(90, 57);
            this.foto.TabIndex = 3;
            this.foto.Text = "Adicionar imagem";
            this.foto.UseVisualStyleBackColor = true;
            this.foto.Click += new System.EventHandler(this.foto_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(140, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(140, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 111);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjBase1.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(-5, -48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(748, 477);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.PostText);
            this.Controls.Add(this.Postar);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Postar;
        private System.Windows.Forms.RichTextBox PostText;
        private System.Windows.Forms.Button foto;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}