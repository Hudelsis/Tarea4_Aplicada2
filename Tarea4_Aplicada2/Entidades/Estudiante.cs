using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tarea4_Aplicada2.Entidades
{
    public class Estudiante
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }

        public Estudiante()
        {
            StudentId = 0;
            Name = string.Empty;
        }

        public Estudiante(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }
    }
}
