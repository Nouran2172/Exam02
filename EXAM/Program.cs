namespace EXAM
{
    class Program
    {
        static void Main(string[] args)
        {


            Subject subject = new Subject
            {
                SubjectId = 1,
                SubjectName = "Programming"
            };

            Console.Write("Enter type of exam (1 for Practical / 2 for Final): ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter time of the exam (30 to 180 min): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter number of questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Exam exam;
            if (examType == 1)
            {
                exam = new PracticalExam 
                {
                  Time = time,
                  NumberOfQuestions = numberOfQuestions,
                  Questions = new Question[numberOfQuestions] 
                };
            }
            else
            {
                exam = new FinalExam 
                { 
                    Time = time,
                    NumberOfQuestions = numberOfQuestions,
                    Questions = new Question[numberOfQuestions]
                };
            }

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.Write($"Enter type of question {i + 1} (1 for MCQ{(examType == 2 ? " / 2 for True/False" : "")}): ");
                int questionType = int.Parse(Console.ReadLine());

                if (examType == 1 && questionType != 1)
                {
                    Console.WriteLine("Invalid question type for Practical Exam. Only MCQ is allowed.");
                    i--;
                    continue;
                }

                Console.Write("Enter question body: ");
                string body = Console.ReadLine();

                Console.Write("Enter question mark: ");
                int mark = int.Parse(Console.ReadLine());

                if (questionType == 1)
                {
                    Console.Write("Enter number of choices: ");
                    int choiceCount = int.Parse(Console.ReadLine());
                    var choices = new Answer[choiceCount];

                    for (int j = 0; j < choiceCount; j++)
                    {
                        Console.Write($"Enter choice {j + 1}: ");
                        choices[j] = new Answer { AnswerId = j + 1, AnswerText = Console.ReadLine() };
                    }

                    Console.Write("Enter right answer id: ");
                    int rightAnswerId = int.Parse(Console.ReadLine());

                    Answer rightAnswer = null;
                    for (int j = 0; j < choices.Length; j++)
                    {
                        if (choices[j].AnswerId == rightAnswerId)
                        {
                            rightAnswer = choices[j];
                            break;
                        }
                    }

                    exam.Questions[i] = new MCQQuestion
                    {
                        Header = $"Question {i + 1}",
                        Body = body,
                        Mark = mark,
                        AnswerList = choices,
                        RightAnswer = rightAnswer
                    };

                }
                else
                {
                    Console.Write("Enter right answer (1 for True / 2 for False): ");
                    int rightAnswerId = int.Parse(Console.ReadLine());

                    exam.Questions[i] = new TrueFalseQuestion
                    {
                        Header = $"Question {i + 1}",
                        Body = body,
                        Mark = mark,
                        RightAnswer = new Answer { AnswerId = rightAnswerId, AnswerText = rightAnswerId == 1 ? "True" : "False" }
                    };
                }
            }

            subject.CreateExam(exam);

            Console.Write("Do you want to start the exam? (y/n): ");
            if (Console.ReadLine().ToLower() == "y")
            {
                subject.SubjectExam.ConductExam();
            }
            else
            {
                Console.WriteLine("Exam creation finished.");
            }
        }
    }

}


