using App_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte Prioridade2 { get; set; }
		public Cadastro ()
		{
			InitializeComponent ();
            
		}

        private void PrioridadeSelectAction(object sender, EventArgs e)
        {
            var Stacks = SLPrioridades.Children;

            foreach (var Linha in Stacks)
            {
                Label LblPrioridade = ((StackLayout)Linha).Children[1] as Label;
                LblPrioridade.TextColor = Color.Gray;
                ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;

                FileImageSource Source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

                String Prioridade = Source.ToString().Replace("Resources/","").Replace(".png","").Replace("File: ","").Replace("Prioridade","");
                Prioridade2 = byte.Parse(Prioridade);

               
            }
        }

        private void SalvarAction(object sender, EventArgs e)
        {
            bool ErroExiste = false;
            if (!(TxtNome.Text.Trim().Length>0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Nome da Tarefa não Informado!","OK");
            }
            if (!(Prioridade2>0))
            {
                ErroExiste = true;
                DisplayAlert("Erro", "Prioridade não informada!", "OK");
            }
            if (ErroExiste == false)
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = TxtNome.Text.Trim();
                tarefa.Prioridade = Prioridade2;

                new GerenciadorTarefas().Salvar(tarefa);
                //TxtNome.Text = new GerenciadorTarefas().Listagem().Count.ToString();
                App.Current.MainPage = new NavigationPage(new Inicio()) { BarBackgroundColor = Color.Blue };
            }
        }
    }
}