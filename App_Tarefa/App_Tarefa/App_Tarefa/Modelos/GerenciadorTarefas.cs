using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Tarefa.Modelos
{
    public class GerenciadorTarefas
    {
        private List<Tarefa> Lista { get; set; }

        public GerenciadorTarefas()
        {
           
        }
        
        public void Finalizar(int Index, Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(Index);

            tarefa.DataFinalizacao = DateTime.Now;
            Lista.Add(tarefa);
            SalvarNoPropert(Lista);
        }
        public void Deletar(int Index)
        {
            Lista = Listagem();
            Lista.RemoveAt(Index);
            SalvarNoPropert(Lista);

        }
        public void Salvar(Tarefa tarefa)
        {
            Lista =  Listagem();
            Lista.Add(tarefa);
            SalvarNoPropert(Lista);
        }

        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        public void SalvarNoPropert(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }
            String JsonVal  = JsonConvert.SerializeObject(Lista);
            App.Current.Properties.Add("Tarefas", JsonVal);
        }

        public List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                String JsonVal = (String)App.Current.Properties["Tarefas"];

                List<Tarefa> Lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);
                return Lista;
                //return (List<Tarefa>)App.Current.Properties["Tarefas"];
            }
            return new List<Tarefa>();
        }
    }


}

