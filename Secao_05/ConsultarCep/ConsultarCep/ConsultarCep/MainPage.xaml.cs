using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ConsultarCep.Servico;
using ConsultarCep.Servico.Modelo;


namespace ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs e)
        {
            if (CEP == null)
            {
                DisplayAlert("ERRO!", "Cep não pode ficar vazio!", "OK");
            }
            //TODO - Validaçoes
            string cep = CEP.Text.Trim();
            if (cep.Length <=0)
            {
                DisplayAlert("ERRO!", "Cep não pode ficar vazio!", "OK");
            }
            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = String.Format("Endereço: {2} de {3} {0}, {1} ", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else {
                        DisplayAlert("ERRO!", "Cep não encontrado !", "OK");
                    }
                }

                   
                catch (Exception Erro)
                {
                    DisplayAlert("ERRO CRITICO!", Erro.Message, "OK");
                }
                
            }
            else
            {

            }
             
        }

        private bool isValidCEP (string cep)
        {
            bool valido = true;
            if (cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP deve conter 8 caracteres.", "OK");
                valido = false;
            }
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP Inválido! São aceito apenas números.", "OK");
                valido = false;
            }
            return valido;
        }
    }
}
