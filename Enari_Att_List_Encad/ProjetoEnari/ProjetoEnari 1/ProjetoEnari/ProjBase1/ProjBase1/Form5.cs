using System;
using System.Drawing;
using System.Windows.Forms;
using static ProjBase1.Form4;

namespace ProjBase1
{
    public partial class Form5 : Form
    {
        private OpenFileDialog ofd1;
        private Image selectedImage;

        public Form5()
        {
            InitializeComponent();
            ofd1 = new OpenFileDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string postText = PostText.Text;

            if (!string.IsNullOrEmpty(postText) || selectedImage != null)
            {
                DadosUsuario.UsuarioLogado.Posts.Add(postText);
                DadosUsuario.UsuarioLogado.Imagens.Add(selectedImage);

                DadosGlobal.FeedGeral.Add((postText, selectedImage));

                MessageBox.Show("Postado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, adicione um texto ou uma imagem ao post.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void foto_Click(object sender, EventArgs e)
        {
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    selectedImage = Image.FromFile(ofd1.FileName);
                    pictureBox1.Image = selectedImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void PostText_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
