using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_oop
{
    internal class Answer_Model
    {

       
            public int AnswerId { get; set; }
            public string AnswerText { get; set; }

            public Answer_Model(int answerId, string answerText)
            {
                AnswerId = answerId;
                AnswerText = answerText;
            }
        }
    }

