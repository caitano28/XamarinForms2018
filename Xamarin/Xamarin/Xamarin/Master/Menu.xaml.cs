using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Perfil1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Sobre());
        }
    }
}