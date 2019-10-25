using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Tarefas")]
    public class Tarefa
    {
        [Key()]
        public int Id { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("Date_Begin")]
        [Column("Date_Begin", TypeName = "DateTime")]
        public DateTime Date_Begin { get; set; }

        [DisplayName("Date_End")]
        public DateTime Date_End { get; set; }

        [DisplayName("Duration")]
        public TimeSpan Duration { get; set; }

        [DisplayName("Description")]
        public string Desc { get; set; }

        public Tarefa(string nome, DateTime date_begin, DateTime date_end, TimeSpan duration, string desc)
        {
            Nome = nome;
            Date_Begin = date_begin;
            Date_End = date_end;
            Duration = duration;
            Desc = desc;
        }

        public Tarefa (string nome, DateTime date_begin)
        {
            Nome = nome;
            Date_Begin = date_begin;
        }
    }
}
