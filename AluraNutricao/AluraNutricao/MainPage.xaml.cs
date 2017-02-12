using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AluraNutricao
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void AtualizaContador(Object sender,EventArgs e)
        {
            double caloria = stpCaloria.Value;
            lblCaloria.Text = caloria.ToString();
        }

        public void SalvaRefeicao(Object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double valor = stpCaloria.Value;
            string msg = $"A refeição {descricao} de {valor} calorias.";
            DisplayAlert("Salvar Refeição",msg,"OK");
        }
    }
}
