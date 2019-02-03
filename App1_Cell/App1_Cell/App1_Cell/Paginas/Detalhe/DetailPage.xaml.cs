using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas.Detalhe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailPage : ContentPage
	{
        public Funcionario Funcionario { get; set; }
		public DetailPage (Funcionario func )
		{
			InitializeComponent ();
            Funcionario = new Funcionario();
            Lblteste.Text = func.Nome;
		}
	}
}