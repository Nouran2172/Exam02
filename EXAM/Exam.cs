using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal abstract class Exam
    {

            public int Time { get; set; }
            public int NumberOfQuestions { get; set; }
            public Question[] Questions { get; set; } 

            public abstract void ShowExam();
            public void ConductExam()
            {
                int totalGrade = 0;
                var startTime = DateTime.Now;

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].ShowQuestion();
                Console.Write("Your Answer: ");
                string userAnswer = Console.ReadLine();

                if (Questions[i].ValidateAnswer(userAnswer))
                {
                    totalGrade += Questions[i].Mark;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Wrong! Right Answer: {Questions[i].RightAnswer}");
                }
            }


            var endTime = DateTime.Now;
                Console.WriteLine($"\nExam Finished! Time Taken: {(endTime - startTime).TotalMinutes} minutes");
                int totalMarks = 0;
                for (int i = 0; i < Questions.Length; i++)
                {
                    totalMarks += Questions[i].Mark;
                }
                Console.WriteLine($"Your Grade: {totalGrade}/{totalMarks}");


        }

    }
}
