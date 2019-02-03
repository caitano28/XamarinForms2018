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
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();
            ListaFuncionario.ItemsSource = new GeraLista().Lista;
		}

        private void ListaFuncionario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Funcionario func = (Funcionario) e.SelectedItem;
            Navigation.PushAsync(new Detalhe.DetailPage(func));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            MenuItem Botao = (MenuItem)sender;
            Funcionario fun = (Funcionario)Botao.CommandParameter;
            DisplayAlert("Aleta férias", fun.Nome + " - " + fun.Cargo + "  está de férias", "OK");
        }

        private void MenuItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}