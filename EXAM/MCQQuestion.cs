using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class MCQQuestion : Question
    {
        public override void ShowQuestion()
        {
            Console.WriteLine($"{Header}: {Body}");

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine(AnswerList[i]);
            }


        }

        public override bool ValidateAnswer(string userAnswer)
        {
            return RightAnswer.AnswerId.ToString() == userAnswer;
        }
    }
}
