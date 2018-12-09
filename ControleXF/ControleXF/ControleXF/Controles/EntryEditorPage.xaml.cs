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
	public partial class EntryEditorPage : ContentPage
	{
		public EntryEditorPage ()
		{
			InitializeComponent ();

            TxtIdade.TextChanged += delegate(Object sender, TextChangedEventArgs e)
            {
                Lbl_Duplicado.Text = e.NewTextValue;
            };

            TxtComentario.Completed += delegate (Object sender, EventArgs e)
            {
               LblQuantidadeCaracteres.Text = TxtComentario.Text.Length.ToString();
            };
		}
	}
}