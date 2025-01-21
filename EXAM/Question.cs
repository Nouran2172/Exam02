using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal abstract class Question
    {

            public string Header { get; set; }
            public string Body { get; set; }
            public int Mark { get; set; }
            public Answer[] AnswerList { get; set; }
            public Answer RightAnswer { get; set; }

            public abstract void ShowQuestion();
            public abstract bool ValidateAnswer(string userAnswer);
        
    }
}
