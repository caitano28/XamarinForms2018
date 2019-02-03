using System;
using System.Collections.Generic;
using System.Text;
using App1_vagas.Modelos;
using SQLite;
using Xamarin.Forms;

namespace App1_vagas.Banco
{
    public class DataBase
    {
        private SQLiteConnection _conexao;

        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");
            _conexao = new SQLiteConnection(caminho);
        }
        public void Cadastro (Vaga vaga)
        {
            _conexao.Insert(vaga);
        }
        public List<Vaga> Consultar()
        {
            return _conexao.Table<Vaga>().ToList();
        }
        public Vaga ObterVagaPorId(int id)
        {
           return _conexao.Table<Vaga>().Where(a => a.Id == id).FirstOrDefault();
        }
        public List<Vaga> Pesquisar(string palavra)
        {
            return _conexao.Table<Vaga>().Where(a => a.NomeVaga.ToLower().Contains(palavra.ToLower())).ToList();
        }
        public void Atualizacao(Vaga vaga)
        {
            _conexao.Update(vaga);
        }
        public void Exclusao(Vaga vaga)
        {
            _conexao.Delete(vaga);
        }
    }
}
