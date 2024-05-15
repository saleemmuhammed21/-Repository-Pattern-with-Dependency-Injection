using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790.Models
{
    public class Student:BaseEntity
    {

        public Student() { }
        public Student(int id, string name, DateTime birthDate, string semester)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = birthDate;
            this.Semester = semester;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Semester { get; set; }
    }
}
