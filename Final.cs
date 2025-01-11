using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    class Final : Exam
    {
        public Final(int time, int numberOfQuestions, Question[] questions) :base(time,numberOfQuestions,questions ) { }



        public override int ConductExam()
        {
            int total = 0;
            foreach (Question i in Questions) {
                i.Display();
                Console.WriteLine("Enter your answer:");
                int userAnswer = int.Parse(Console.ReadLine());
                if (i.Answers[userAnswer - 1] == i.CorrectAnswer)
            {
                    total += i.Mark;
                }
                
            }
            Console.WriteLine($"Your grade is: {total}");
            return total;
        }

        public override void ShowExam()
        {
            Console.WriteLine("--- Final Exam ---");
            foreach (var i in Questions)
            {
                i.Display();
                Console.WriteLine($"Correct Answer: {i.CorrectAnswer.AnswerText}\n");
            }
            Console.WriteLine("End of Exam.");
        }
    }
}
