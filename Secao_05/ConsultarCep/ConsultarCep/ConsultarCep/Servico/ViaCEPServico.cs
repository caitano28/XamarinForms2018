using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ConsultarCep.Servico.Modelo;
using Newtonsoft.Json;

namespace ConsultarCep.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP (string cep)
        {
            string NovoEnderecoURL = String.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo) ;

            if (end.cep == null) return null;

            return end;
        }
    }
}
