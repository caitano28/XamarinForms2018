using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProgressBarPage : ContentPage
	{
		public ProgressBarPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Bar1.Progress *= 2;
            Bar2.Progress *= 2;
            Bar3.Progress *= 2;
            Bar4.ProgressTo(1, 5000, Easing.Linear);
        }
    }
}