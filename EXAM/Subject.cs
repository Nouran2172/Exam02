using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Subject
    {

            public int SubjectId { get; set; }
            public string SubjectName { get; set; }
            public Exam SubjectExam { get; set; }

            public void CreateExam(Exam exam)
            {
                SubjectExam = exam;
            }
        
    }
}
