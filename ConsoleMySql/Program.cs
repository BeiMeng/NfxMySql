using ConsoleMySql.Data;
using ConsoleMySql.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMySql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BloggingContext db = new BloggingContext())
            {
                for (int i = 0; i < 3; i++)
                {
                    db.Blogs.Add(new Blog { Name = "小明10" + i });
                }
                db.SaveChanges();
                foreach (var item in db.Blogs)
                {
                    Console.WriteLine(item.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
