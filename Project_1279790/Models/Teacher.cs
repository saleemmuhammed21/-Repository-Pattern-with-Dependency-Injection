using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790.Models
{
    public class Teacher:BaseEntity
    {
        public Teacher() { }
        public Teacher(int id, string name, string department, string email)
        {
            Id = id;
            Name = name;
            Department = department;
            Email = email;
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
    }
}
