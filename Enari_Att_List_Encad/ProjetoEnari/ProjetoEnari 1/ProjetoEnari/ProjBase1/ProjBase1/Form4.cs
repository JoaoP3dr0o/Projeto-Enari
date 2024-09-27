using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjBase1
{
    public partial class Form4 : Form
    {
        private OpenFileDialog ofd1;

        public Form4()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form4_Load);
            ofd1 = new OpenFileDialog();
        }

        public class Usuario
        {
            public string Nome { get; set; }
            public Image FotoPerfil { get; set; }
            public List<string> Posts { get; set; } = new List<string>();
            public List<Image> Imagens { get; set; } = new List<Image>();

        }

        public static class DadosGlobal
        {
            public static List<(string Post, Image Imagem)> FeedGeral { get; set; } = new List<(string, Image)>();
        }

        public static class DadosUsuario
        {
            public static Dictionary<string, Usuario> Usuarios = new Dictionary<string, Usuario>();
            public static Usuario UsuarioLogado { get; set; }
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            if (DadosUsuario.UsuarioLogado != null)
            {
                nomeUsuario.Text = DadosUsuario.UsuarioLogado.Nome;

                if (DadosUsuario.UsuarioLogado.FotoPerfil != null)
                {
                    pictureBox1.Image = DadosUsuario.UsuarioLogado.FotoPerfil;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                AtualizarPosts(); 
            }
            else
            {
                nomeUsuario.Text = "Nenhum usuário logado";
            }
        }



        private void LimparDadosUsuario()
        {
            DadosUsuario.UsuarioLogado.Posts.Clear();
            DadosUsuario.UsuarioLogado.Imagens.Clear();
        }

        private void AtualizarPosts()
        {
            PostText.Controls.Clear();
            int yPosition = 10;
            int postPanelHeight = 120;

            for (int i = 0; i < DadosUsuario.UsuarioLogado.Posts.Count; i++)
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


        private void new_post_Click(object sender, EventArgs e)
        {
            using (Form5 form = new Form5())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    AtualizarPosts(); 
                }
            }
        }

        private void nomeUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ofd1.Multiselect = false;
            ofd1.Title = "Selecionar Imagem";
            ofd1.Filter = "Imagens (*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
                          "Todos os arquivos (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 1;

            try
            {
                if (ofd1.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1 != null && DadosUsuario.UsuarioLogado != null)
                    {
                        Image imagemSelecionada = Image.FromFile(ofd1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Image = imagemSelecionada;

                        DadosUsuario.UsuarioLogado.FotoPerfil = imagemSelecionada;


                        MessageBox.Show("Foto de perfil atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Controle PictureBox ou usuário logado não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form3 form3 = Application.OpenForms.OfType<Form3>().FirstOrDefault();
            if (form3 != null)
            {
                form3.Show(); 
                this.Hide();  
            }
            else
            {
                MessageBox.Show("Erro: O feed não foi encontrado.");
            }
        }



    }
}
