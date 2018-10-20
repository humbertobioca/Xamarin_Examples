using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExemploBD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Aluno novoAluno = new Aluno
            {
                Nome = txtNome.Text,
                Cidade = txtCidade.Text,
                Classe = txtClasse.Text
            };
            App.BD.Insert(novoAluno);
        }
        void CarregarLista(){
            var dadosTabela = App.BD.Table<Aluno>();
            List<Aluno> lista = (from aluno in dadosTabela
                                 select aluno).ToList();
        }
    }
}