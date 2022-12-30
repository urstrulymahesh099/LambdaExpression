using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> details = new List<Student>() {
            new Student{ rollNo = 1, name = "Mahesh" },
                new Student{ rollNo = 2, name = "Niranja" },
                new Student{ rollNo = 3, name = "Marthi" },
                new Student{ rollNo = 4, name = "Afrin" },
                new Student { rollNo = 5, name = "Naaz" }
        };
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }
        }
    }
}