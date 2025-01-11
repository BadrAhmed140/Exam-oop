using Exam_oop;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Subject ID:");
        int subjectId = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Subject Name:");
        string subjectName = Console.ReadLine();

        Subject subject = new Subject(subjectId, subjectName);

        Console.WriteLine("Enter Exam Time (in minutes):");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Number of Questions:");
        int numberOfQuestions = int.Parse(Console.ReadLine());

        Question[] questions = new Question[numberOfQuestions];

        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine($"Enter Question {i + 1} Header:");
            string header = Console.ReadLine();

            Console.WriteLine("Enter Question Body:");
            string body = Console.ReadLine();

            Console.WriteLine("Enter Question Mark:");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Question Type (1 for True/False, 2 for MCQ):");
            int questionType = int.Parse(Console.ReadLine());

            Answer_Model[] answers;

            if (questionType == 1)
            {
                answers = new Answer_Model[]
                {
                    new Answer_Model(1, "True"),
                    new Answer_Model(2, "False")
                };

                Console.WriteLine("Enter Correct Answer (1 for True, 2 for False):");
                int correctAnswerId = int.Parse(Console.ReadLine());

                questions[i] = new True_False(header, body, mark, answers, answers[correctAnswerId - 1]);
            }
            else if (questionType == 2)
            {
                Console.WriteLine("Enter Number of Options:");
                int numOptions = int.Parse(Console.ReadLine());

                answers = new Answer_Model[numOptions];
                for (int j = 0; j < numOptions; j++)
                {
                    Console.WriteLine($"Enter Option {j + 1}:");
                    string optionText = Console.ReadLine();
                    answers[j] = new Answer_Model(j + 1, optionText);
                }

                Console.WriteLine("Enter Correct Answer Option Number:");
                int correctAnswerId = int.Parse(Console.ReadLine());

                questions[i] = new Mcq(header, body, mark, answers, answers[correctAnswerId - 1]);
            }
        }

        Console.WriteLine("Enter Exam Type (1 for Final Exam, 2 for Practical Exam):");
        int examType = int.Parse(Console.ReadLine());


        Exam exam;

        if (examType == 1)
        {
            exam = new Final(time, numberOfQuestions, questions);
        }
        else
        {
            exam = new Practical(time, numberOfQuestions, questions);
        }

        subject.CreateExam(exam);

        Console.WriteLine(subject);
        subject.Exam.ConductExam();

    }
}