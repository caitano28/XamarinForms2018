using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using App1_vagas.Banco;
using System.IO;
[assembly:Dependency(typeof(App1_vagas.Droid.Banco.Caminho))]
namespace App1_vagas.Droid.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeDoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string camingoBanco = Path.Combine(caminhoDaPasta, NomeDoBanco);
            return camingoBanco;
        }
    }
}