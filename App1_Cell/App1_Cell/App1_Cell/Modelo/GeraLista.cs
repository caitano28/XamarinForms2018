using System;
using System.Collections.Generic;
using System.Text;

namespace App1_Cell.Modelo
{
    public class GeraLista
    {
        public List<Funcionario> Lista { get; set; }
        public GeraLista()
        {
            Lista =  new List<Funcionario>();
            InicializaLista();
        }
        public void InicializaLista()
        {
            
            Lista.Add(new Funcionario { Nome = "José", Cargo = "Presidente", Foto = "https://ct.yimg.com/cy/4536/37423391143_9bd89c_128sq.jpg" });
            Lista.Add(new Funcionario { Nome = "Maria", Cargo = "Gerente de Vendas" , Foto = "https://ct.yimg.com/cy/4536/37423391143_9bd89c_128sq.jpg" });
            Lista.Add(new Funcionario { Nome = "Elaine", Cargo = "Gerente de Marketing", Foto = "https://ct.yimg.com/cy/4536/37423391143_9bd89c_128sq.jpg" });
            Lista.Add(new Funcionario { Nome = "Felipe", Cargo = "Entregador" , Foto = "https://blog.fotolia.com/br/files/2015/09/Screenshot1.png" });
            Lista.Add(new Funcionario { Nome = "João", Cargo = "vendedor", Foto = "https://blog.fotolia.com/br/files/2015/09/Screenshot1.png" });
         
        }
    }
}
