﻿using App_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            CultureInfo culture = new CultureInfo("pt-BR");

            string Data = DateTime.Now.ToString("dddd, dd {0} MMMM {0} yyyy", culture);
            
            DataHoje.Text = string.Format(Data, "de");
            // DataHoje.Text = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToString("dd/MM");
            CarregarTarefas();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private void CarregarTarefas()
        {
            Tarefas.Children.Clear();

            List<Tarefa> Lista = new GerenciadorTarefas().Listagem();
            int i = 0;
            foreach (var tarefa in Lista)
            {
                LinhaStack(tarefa, i);
                i++;
            }
        }

        public void LinhaStack (Tarefa tarefa, int Index)
        {
            Image Delete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Delete.png") };

            if (Device.RuntimePlatform == Device.UWP)
            {
                Delete.Source = ImageSource.FromFile("Resources/Delete.png");
            }

            TapGestureRecognizer DeleteTap = new TapGestureRecognizer();
            DeleteTap.Tapped += delegate 
            {
                new GerenciadorTarefas().Deletar(Index);
                CarregarTarefas();

            };

            Delete.GestureRecognizers.Add(DeleteTap);

            Image Prioridade = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Prioridade"+tarefa.Prioridade + ".png") };

            if (Device.RuntimePlatform == Device.UWP)
            {
                Prioridade.Source = ImageSource.FromFile("Resources/Prioridade"+tarefa.Prioridade+".png");
            }

            object StackCentral = null;
            if (tarefa.DataFinalizacao == null)
            {
                StackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefa.Nome };
            }
            else {
                StackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand };
                ((StackLayout)StackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray});
                ((StackLayout)StackCentral).Children.Add(new Label() { Text ="Finalizado em " + tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm") + "h", TextColor = Color.Gray, FontSize = 10 });
            }
            

            Image Check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.png") };

            if (Device.RuntimePlatform == Device.UWP)
            {
                Check.Source = ImageSource.FromFile("Resources/CheckOff.png");
            }
            if (tarefa.DataFinalizacao != null )
            {
                Check.Source = ImageSource.FromFile("CheckOn.png");
                if (Device.RuntimePlatform == Device.UWP)
                {
                    Check.Source = ImageSource.FromFile("Resources/CheckOn.png");
                }
            }


            TapGestureRecognizer CheckTap = new TapGestureRecognizer();
            CheckTap.Tapped += delegate
            {
                new GerenciadorTarefas().Finalizar(Index, tarefa);
                CarregarTarefas();

            };

            Check.GestureRecognizers.Add(CheckTap);
            StackLayout Linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };

            Linha.Children.Add(Check);
            Linha.Children.Add((View)StackCentral);
            Linha.Children.Add(Prioridade);
            Linha.Children.Add(Delete);

            Tarefas.Children.Add(Linha);
        }
    }
}