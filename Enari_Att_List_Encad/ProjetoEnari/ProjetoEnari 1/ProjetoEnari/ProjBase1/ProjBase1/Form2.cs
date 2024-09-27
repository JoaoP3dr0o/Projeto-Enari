using System;
using System.Threading;
using System.Windows.Forms;

namespace ProjBase1
{
    public partial class Form2 : Form
    {
        
        public class Perfil 
        {
            public string[] Dados;
            public Perfil Proximo;

            public Perfil(string[] dados)
            {
                Dados = dados;
                Proximo = null;
            }
        }

        public static Perfil cabeca;

        Thread t1;
        Thread t2;

        public Form2()
        {
            InitializeComponent();
            this.Text = "Orkit";
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nome = textEmail.Text;
            string senha = textPassword.Text;

            if (IsUserRegistered(nome))
            {
                MessageBox.Show("Usuário já cadastrado! Tente outro email.");
                return;
            }

            AddUser(nome, senha);
            MessageBox.Show("Usuário cadastrado com sucesso!");

            this.Close();
            t2 = new Thread(OpenW);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void btAccess_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(OpenW);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void OpenW()
        {
            Application.Run(new Form1());
        }

        private void AddUser(string nome, string senha)
        {
            Perfil novoPerfil = new Perfil(new string[] { nome, senha });
            if (cabeca == null)
            {
                cabeca = novoPerfil;
            }
            else
            {
                Perfil atual = cabeca;
                while (atual.Proximo != null)
                {
                    atual = atual.Proximo;
                }
                atual.Proximo = novoPerfil;
            }
        }

        private bool IsUserRegistered(string nome)
        {
            Perfil atual = cabeca;
            while (atual != null)
            {
                if (atual.Dados[0] == nome)
                {
                    return true;
                }
                atual = atual.Proximo;
            }
            return false;
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
