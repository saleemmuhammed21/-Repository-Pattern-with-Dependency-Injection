using Project_1279790.Factories;
using Project_1279790.Models;
using Project_1279790.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279790.Controllers
{
    public class TestController
    {
        IObjectFactory factory;
        public TestController(IObjectFactory factory) { this.factory = factory; }
        public void Run()
        {
            IRepository<Student> repoS = factory.CreateRepository<Student>();
            repoS.AddRange(new Student[] {
                new Student{ Id=1, Name="Saleem",Semester="winter"},
                new Student{ Id=2, Name="Toha",Semester="spring"},
                new Student{ Id=3, Name="Muhammed",Semester="summer"},
                new Student{ Id=4, Name="Fahad", Semester = "winter"},
                new Student{ Id=5, Name="Shila", Semester = "fall"}
            });
            //GetAll
            Console.WriteLine("FindAll");
            repoS.FindAll().ToList()
                .ForEach(S => Console.WriteLine($"Id: {S.Id}, Name: {S.Name},Semester:{S.Semester}"));
            //Get by id
            Console.WriteLine("Get");
            var Stu = repoS.Find(3);
            Console.WriteLine($"Id: {Stu.Id}, Name: {Stu.Name},Semester:{Stu.Semester}");
            //Update
            Console.WriteLine("Update");
            Stu.Name = "Saleem";
            repoS.Update(Stu);
            repoS.FindAll().ToList()
               .ForEach(c => Console.WriteLine($"Id: {Stu.Id}, Name: {Stu.Name},Semester:{Stu.Semester}"));
            //Delete
            Console.WriteLine("Delete");
            repoS.Delete(3);
            repoS.FindAll().ToList()
              .ForEach(c => Console.WriteLine($"Id: {Stu.Id}, Name: {Stu.Name},Semester:{Stu.Semester}"));
            Console.WriteLine("******************");
            IRepository<Teacher> repoT = factory.CreateRepository<Teacher>();
            repoT.AddRange(new Teacher[]
            {
                  new Teacher( 101, "Zahid", "CSE", "p@gg.com"),
                  new Teacher( 101, "Mizan", "CSE", "p@gg.com"),
                  new Teacher( 101, "Zewel", "CSE", "p@gg.com"),
                  new Teacher( 101, "Akhil", "CSE", "p@gg.com"),
            });
            //GetAll
            Console.WriteLine("GetAll");
            repoT.FindAll().ToList()
                .ForEach(T => Console.WriteLine($"Id:{T.Id}, Name: {T.Name},Department:{T.Department},Email:{T.Email}"));
            //Delete
            Console.WriteLine("Delete");
            repoT.Delete(2);
            repoT.FindAll().ToList()
               .ForEach(T => Console.WriteLine($"Id:{T.Id}, Name: {T.Name},Department:{T.Department},Email:{T.Email}"));

        }
    }
}
