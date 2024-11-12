using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Task
{
    internal class ScoreProcessor
    {
        public List<Student> FilterStudents(List<Student> students, ScoreCriteria criteria) =>
       students.Where(criteria.Invoke).ToList();

        
        public double CalculateAverage(List<Student> students) => students.Average(s => s.Score);
    }
}
