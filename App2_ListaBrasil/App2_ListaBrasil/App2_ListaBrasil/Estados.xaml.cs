using App2_ListaBrasil.Modelo;
using App2_ListaBrasil.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_ListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estados : ContentPage
	{
        public EstadoServico Servico { get; set; }
        public Estados ()
		{
			InitializeComponent ();
            Servico = new EstadoServico();
            GetEstados();


        }
        private async void GetEstados()
        {
            var retorno = await Servico.Get<Estado>();
            if (!(retorno == null))
            {
                ListaEstados.ItemsSource = retorno.OrderBy(x=> x.nome);
            }
           
        }

        private void ListaEstados_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Estado estado = (Estado)e.SelectedItem;
              
            Navigation.PushAsync(new Municipio(estado));
            
        }
    }
}