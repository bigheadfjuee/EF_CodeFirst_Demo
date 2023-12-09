using ConsoleEF_CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEF_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            using (var db = new EFModel())
            {
                Console.WriteLine("EFModel");
                db.MyEntities.Add(new MyEntity { Name = "Test2" });

                db.Users.Add(new UserModel { Name = "User1", Email = "aa@bb.com" });

                db.SaveChanges();

                foreach (var entity in db.MyEntities)
                {
                    Console.WriteLine(entity.Name);
                }

                foreach (var user in db.Users)
                {
                    Console.WriteLine(user.Name);
                    Console.WriteLine(user.Email);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
