using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Entities;

namespace Business
{
    public class CreateTask
    {
        public void CriaTask(string nome, DateTime time)
        {
            using (var context = new Context())
            {
                //Task task = new Task(nome, time);
                context.Tarefas.Add(new Tarefa(nome, time));
                context.SaveChanges();
            }
        }
    }
}
