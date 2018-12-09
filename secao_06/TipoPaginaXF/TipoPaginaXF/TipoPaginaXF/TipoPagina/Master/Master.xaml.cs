using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipoPaginaXF.TipoPagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new Navigation.Pagina1();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new Navigation.Pagina2();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new Conteudo();        }
    }
}