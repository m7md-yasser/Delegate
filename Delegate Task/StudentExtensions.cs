using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task
{
    public static class StudentExtensions
    {
        public static void PrintStudents(this List<Student> students) =>
               students.ForEach(s => Console.WriteLine($" {s.Name}, Score: {s.Score}"));

        public static Student TopScorer(this List<Student> students) =>
            students.OrderByDescending(s => s.Score).FirstOrDefault();
    }

}
