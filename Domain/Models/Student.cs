using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTableAPI.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public int StudNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime BirthDate { get; set; }
        public string Schedule { get; set; }
        public int AverageScore { get; set; }
        public int PreviousAverageScore { get; set; }
        public bool IsBachelor { get; set; }
        public bool HasScholarship { get; set; }
    }
}
