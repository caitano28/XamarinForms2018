using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleXF.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPage : ContentPage
	{
        private List<Pessoa> Pessoas;
		public ListViewPage ()
		{
            Pessoas = new List<Pessoa>();
			InitializeComponent ();
            CriaLista();


        }
        private void CriaLista()
        {
            Pessoas.Add(new Pessoa { Nome = "Pedro", idade = "24" });
            Pessoas.Add(new Pessoa { Nome = "Carla", idade = "12" });
            Pessoas.Add(new Pessoa { Nome = "Joana", idade = "10" });
            ListaPessoas.ItemsSource = Pessoas;
        }
	}
}