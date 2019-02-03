using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
		{
			InitializeComponent ();
            ListaFuncionario.ItemsSource = new GeraLista().Lista;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button Botao = (Button)sender;
            Funcionario func = (Funcionario)Botao.CommandParameter;
            DisplayAlert("Miséra", "Olha quem esta de férias " + func.Nome, "OK");
        }
    }
}