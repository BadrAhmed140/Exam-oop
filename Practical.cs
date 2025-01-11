using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    class Practical : Exam
    {

        public Practical(int time, int numberOfQuestions, Question[] questions)
        : base(time, numberOfQuestions, questions) { }

        public override int ConductExam()
        {
            int total = 0;
            foreach (var question in Questions)
            {
                question.Display();
                Console.WriteLine("Enter your answer:");
                int userAnswer = int.Parse(Console.ReadLine());

                if (question.Answers[userAnswer - 1] == question.CorrectAnswer)
                {
                    total += question.Mark;
                }
                Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}\n");
            }
            Console.WriteLine($"Your grade is: {total}");
            return total;
        }
        

        public override void ShowExam()
        {
            Console.WriteLine("--- Practical Exam ---");
            foreach (var question in Questions)
            {
                question.Display();
                Console.WriteLine($"Correct Answer: {question.CorrectAnswer.AnswerText}\n");
            }
        }
    }
}
