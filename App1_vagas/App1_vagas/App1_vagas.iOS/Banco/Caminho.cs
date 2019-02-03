using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using App1_vagas.Banco;
using Foundation;
using UIKit;
using Xamarin.Forms;
[assembly:Dependency(typeof(App1_vagas.iOS.Banco.Caminho))]

namespace App1_vagas.iOS.Banco
{
    public class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeDoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string caminhoDaBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");
            string caminhoBanco = Path.Combine(caminhoDaBiblioteca, NomeDoBanco);
            return caminhoBanco;
        }
    }
}