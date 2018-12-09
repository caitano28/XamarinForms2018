using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}
