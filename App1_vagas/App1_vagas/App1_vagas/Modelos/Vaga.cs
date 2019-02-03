using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace App1_vagas.Modelos
{
    [Table("Vaga")]
    public class Vaga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeVaga { get; set; }
        public short Quantidade { get; set; }
        public string Empresa { get; set; }
        public string Cidade { get; set; }
        public double Salariio { get; set; }
        public string Descricao { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Emailc { get; set; }
    }

}
