using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var workers = new List<Person> {
                new Employee1(),
                new Employee2(),
                new Employee3()
            };
            var query = (from t in workers
                        where t.exWorks == workers.Max(x => x.exWorks)
                        select new { t.FirstName, t.LastName }).Single();
            Console.WriteLine($"Средняя з/п:{workers.Average(x => x.salary)}");
            Console.WriteLine($"Кол-во работяг:{workers.Count}");
            
            Console.WriteLine($"{query.FirstName+" "+query.LastName} продал больше всех, ему полагается премия!!!");
        }
    }
}
