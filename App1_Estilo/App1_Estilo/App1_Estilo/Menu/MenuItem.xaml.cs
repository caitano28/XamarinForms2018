using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Estilo.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuItem : ContentPage
	{
		public MenuItem ()
		{
			InitializeComponent ();
		}

        private void GoPagina1(object sender, EventArgs e)
        {       
            Navigation.PushAsync(new Pagina.ImplicitStylePage());
        }
        private void GoPagina2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina.ExplicitStylePage());
        }
        private void GoPagina3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina.GlobalStylePage());
          
        }
        private void GoPagina4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina.InheritStylePage());
        }
        private void GoPagina5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina.DynamicStylePage());
        }
    }
}