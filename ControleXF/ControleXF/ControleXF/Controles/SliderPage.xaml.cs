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
	public partial class SliderPage : ContentPage
	{
		public SliderPage ()
		{
			InitializeComponent ();
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LblResult.Text = e.NewValue.ToString();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LblResult2.Text = e.NewValue.ToString();
        }
    }
}