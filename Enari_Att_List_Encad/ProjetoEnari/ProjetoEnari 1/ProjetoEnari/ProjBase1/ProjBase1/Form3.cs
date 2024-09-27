using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static ProjBase1.Form4;

namespace ProjBase1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Orkit";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.UsuarioLogado; 
            AtualizarFeedGeral(); 

            if (DadosUsuario.UsuarioLogado.FotoPerfil != null)
            {
                pictureBox1.Image = DadosUsuario.UsuarioLogado.FotoPerfil;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btProfile_Click(object sender, EventArgs e)
        {
            this.Hide(); 

            using (Form4 form = new Form4())
            {
                form.ShowDialog(); 
            }

            this.Show();

            AtualizarPosts();
            AtualizarFeedGeral(); 
            if (DadosUsuario.UsuarioLogado.FotoPerfil != null)
            {
                pictureBox1.Image = DadosUsuario.UsuarioLogado.FotoPerfil;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LimparDadosUsuario()
        {
            DadosUsuario.UsuarioLogado.Posts.Clear();
            DadosUsuario.UsuarioLogado.Imagens.Clear();

        }

        private void Logoff_Click(object sender, EventArgs e)
        {
            DadosUsuario.UsuarioLogado = null;

            this.Hide();

            Form1 form = new Form1();
            form.ShowDialog(); 
            
            this.Close();
        }

        private void AtualizarFeedGeral()
        {
            PostText.Controls.Clear();
            int yPosition = 10;
            int postPanelHeight = 120;

            for (int i = DadosGlobal.FeedGeral.Count - 1; i >= 0; i--)
            {
                var post = DadosGlobal.FeedGeral[i].Post;
                var img = DadosGlobal.FeedGeral[i].Imagem;

                Panel postPanel = new Panel
                {
                    Size = new Size(PostText.Width - 20, postPanelHeight),
                    Location = new Point(10, yPosition),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox postImage = new PictureBox
                {
                    Image = img,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100),
                    Location = new Point(10, 10)
                };

                Label postLabel = new Label
                {
                    Text = post,
                    AutoSize = true,
                    Location = new Point(120, 10),
                    MaximumSize = new Size(postPanel.Width - 130, 0)
                };

                postPanel.Controls.Add(postImage);
                postPanel.Controls.Add(postLabel);
                PostText.Controls.Add(postPanel);
                yPosition += postPanelHeight + 10;
            }
        }


        private void AtualizarPosts()
        {
            PostText.Controls.Clear();
            int yPosition = 10;
            int postPanelHeight = 120;

            if (DadosUsuario.UsuarioLogado.Posts.Count != DadosUsuario.UsuarioLogado.Imagens.Count)
            {
                MessageBox.Show("Erro: O número de posts e imagens não coincide.");
                return;
            }

            for (int i = DadosUsuario.UsuarioLogado.Posts.Count - 1; i >= 0; i--)
            {
                var post = DadosUsuario.UsuarioLogado.Posts[i];
                var img = DadosUsuario.UsuarioLogado.Imagens[i];

                Panel postPanel = new Panel
                {
                    Size = new Size(PostText.Width - 20, postPanelHeight),
                    Location = new Point(10, yPosition),
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox postImage = new PictureBox
                {
                    Image = img,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Size = new Size(100, 100),
                    Location = new Point(10, 10)
                };

                Label postLabel = new Label
                {
                    Text = post,
                    AutoSize = true,
                    Location = new Point(120, 10),
                    MaximumSize = new Size(postPanel.Width - 130, 0)
                };

                postPanel.Controls.Add(postImage);
                postPanel.Controls.Add(postLabel);
                PostText.Controls.Add(postPanel);
                yPosition += postPanelHeight + 10;
            }
        }
    }
}