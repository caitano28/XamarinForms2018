using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
		}

        private void GoActivity (object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.ActivityPage());
        }
        private void GoProgress(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.ProgressBarPage());
        }
        private void GoBoxView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.BoxViewPage());
        }
        private void GoLabel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.LabelPage());
        }
        private void EntryEditor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.EntryEditorPage());
        }
        private void DatePicker(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.DatePickerPage());
        }
        private void TimePicker(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.TimePicker());
        }
        private void Picker(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.PickerPage());
        }
        private void SearchBar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.SearchBarPage());
        }
        private void Slider(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.SliderPage());
        }
        private void Switch(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.SwitchPage());
        }
        private void Image (object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.ImagePage());
        }
        private void Listview(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.ListViewPage());
        }
        private void TableView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.TableViewPage());
        }
        private void WebView(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Controles.WebViewPage());
        }
    }
}