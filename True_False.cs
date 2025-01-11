using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
     class True_False:Question
    {



        public True_False(string header, string body, int mark, Answer_Model[] answers, Answer_Model correctAnswer)
    : base(header, body, mark, answers, correctAnswer) { }
        public override void Display()
        {
            Console.WriteLine($"[MCQ] {Header}\n{Body}");
            for (int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine($"{i + 1} -{Answers[i].AnswerText}");
            }
        }
    }
}
