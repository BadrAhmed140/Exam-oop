using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark {  get; set; }
        public Answer_Model CorrectAnswer { get; set; }
        public Answer_Model[] Answers { get; set; }
        public Question(string header, string body,int mark, Answer_Model[] answers, Answer_Model CorrectAnswe)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            CorrectAnswer = CorrectAnswe;
        }
        public abstract void Display();
    }
}
