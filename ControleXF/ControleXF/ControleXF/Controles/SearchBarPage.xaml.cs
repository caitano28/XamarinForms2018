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
    public partial class SearchBarPage : ContentPage
    {
        private List<String> empresasTI;
        public SearchBarPage()
        {
            InitializeComponent();
            empresasTI = new List<string>();
            empresasTI.Add("Micosoft");
            empresasTI.Add("Apple");
            empresasTI.Add("IBM");
            empresasTI.Add("SAP");
            empresasTI.Add("Uber");
            empresasTI.Add("99Taxi");

            Preencher(empresasTI);
        }

        private void Preencher (List<String>empresasTI)
        {
            ListResult.Children.Clear();
            foreach (var item in empresasTI)
            {
                ListResult.Children.Add(new Label { Text = item});
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var resultado = empresasTI.Where(a => a.ToLower().Contains(e.NewTextValue.ToLower())).ToList<String>();
            Preencher(resultado);
        }
    }
}