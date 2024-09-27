using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static ProjBase1.Form4;

namespace ProjBase1
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;

        public static string UsuarioLogado { get; set; }


        public Form1()
        {
            InitializeComponent();
            this.Text = "Orkit";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario = textEmail.Text; 

            Login(nomeUsuario);
            this.Hide(); 
            Form3 form3 = new Form3();
            form3.Show(); 
        }

        private void Login(string nomeUsuario)
        {
            if (DadosUsuario.Usuarios.ContainsKey(nomeUsuario))
            {
                DadosUsuario.UsuarioLogado = DadosUsuario.Usuarios[nomeUsuario];
            }
            else
            {
                DadosUsuario.UsuarioLogado = new Usuario { Nome = nomeUsuario };
                DadosUsuario.Usuarios[nomeUsuario] = DadosUsuario.UsuarioLogado;
            }
        }

        private string[] FindUser(string nome, string senha)
        {
            var atual = Form2.cabeca; 

            while (atual != null)
            {
                if (atual.Dados[0] == nome && atual.Dados[1] == senha)
                {
                    return atual.Dados;
                }
                atual = atual.Proximo;
            }
            return null; 
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {

            this.Close();
            t1 = new Thread(OpenW);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();


        }

        private void OpenW(object obj)
        {

            Application.Run(new Form2());

        }
        private void OpenW2(object obj)
        {

            Application.Run(new Form3());

        }

    }
}
