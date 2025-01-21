using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Answer 
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public override string ToString()
        {
            return $"[{AnswerId}] {AnswerText}";
        }
    }
}
