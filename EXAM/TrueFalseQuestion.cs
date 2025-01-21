using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class TrueFalseQuestion : Question
    {
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}: {Body} (True/False)");
        }

        public override bool ValidateAnswer(string userAnswer)
        {
            return RightAnswer.AnswerText.ToLower() == userAnswer.ToLower();
        }
    }
}
