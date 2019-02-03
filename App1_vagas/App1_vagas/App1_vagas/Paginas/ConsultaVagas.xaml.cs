using App1_vagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_vagas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaVagas : ContentPage
	{
		public ConsultaVagas ()
		{
			InitializeComponent ();
		}
        private void GoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVagas());
        }

        private void GoVagas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        private void MaisDetalhesAction(object sender, EventArgs e)
        {
            Vaga vaga = (Vaga)sender;
            Navigation.PushAsync(new DetalheVaga(vaga));
        }
    }
}