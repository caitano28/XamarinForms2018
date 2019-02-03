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
	public partial class Municipio : ContentPage
	{
        public EstadoServico Servico { get; set; }
        public Municipio ( Estado estado)
		{
			InitializeComponent ();
            Servico = new EstadoServico();
            GetMunicipio(estado.id);
        }

        private async void GetMunicipio( int id)
        {
            var retorno = await Servico.GetID<Modelo.Municipio>(id);
            if (!(retorno == null))
            {
                ListaMunicipio.ItemsSource = retorno;
            }

        }
    }
}