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
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoPagina1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.TextCellPage());
            IsPresented = false;
        }
        private void GoPagina2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ImageCellPage());
            IsPresented = false;
        }
        private void GoPagina3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.EntryCellPage());
            IsPresented = false;
        }
        private void GoPagina4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.SwitchCellPage());
            IsPresented = false;
        }
        private void GoPagina5(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ViewCellPage());
            IsPresented = false;
        }
        private void GoPagina6(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ListViewPage());
            IsPresented = false;
        }
        private void GoPagina7(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ListViewButtonPage());
            IsPresented = false;
        }
    }
}