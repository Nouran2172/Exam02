using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class FinalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:");
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQuestion();
            }

        }
    }
}
