using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entities;

namespace Database
{
    public class Context : DbContext
    {
        public Context() : base("Task_Gestor") { }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
