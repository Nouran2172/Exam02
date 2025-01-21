using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class PracticalExam : Exam
    {
        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:");
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQuestion();
                Console.WriteLine($"Right Answer: {Questions[i].RightAnswer}");
            }

        }
    }
}
