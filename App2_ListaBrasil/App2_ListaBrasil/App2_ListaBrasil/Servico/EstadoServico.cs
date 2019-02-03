using App2_ListaBrasil.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App2_ListaBrasil.Servico
{
    public class EstadoServico
    {
        public static string URL = "https://servicodados.ibge.gov.br/api/v1/localidades/";
        private static string URLMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";
        public HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(20000) };

        public async Task<List<T>> Get<T>()
        {

            try
            {
                WebClient wc = new WebClient();

                Uri uri = new Uri(string.Format("{0}/estados", URL));
                var result = await wc.DownloadStringTaskAsync(uri);
                if (result == null)
                {
                    return null;
                }
                ////var uri = new Uri(String.Format("{0}/api" + controller, ServidorApi));
                //var uri = new Uri(URL);
                //var response = await client.GetAsync(uri);

                //if (!response.IsSuccessStatusCode)
                //{
                //    return null;

                //}
                //var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);

                return list;
            }
            catch
            {

                return null;
            }
        }
        public async Task<List<T>> GetID<T>(int id) where T : class 
        {

            try
            {
                WebClient wc = new WebClient();

                Uri uri = new Uri(string.Format(URLMunicipio, id));
                var result = await wc.DownloadStringTaskAsync(uri);
                if (result == null)
                {
                    return null;
                }
                
                var list = JsonConvert.DeserializeObject<List<T>>(result);

                return list;
            }
            catch ( Exception e)
            {

                return null;
            }
        }

        public List<Estado> GetEstado()
        {
            return null;
        }
    }
}
