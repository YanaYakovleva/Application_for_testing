using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class InputAndOutput
    {
        static public void ShowQuestion(QuestionPlusAnswers k)
        {
            Console.WriteLine(k.Question.TextOfQuestion);
            foreach (var answer in k.ListOfAnswers)
            {
                Console.WriteLine(answer.TextOfAnswer);
            }

        }

        static public void AddQuestionFromFile(List<QuestionPlusAnswers> listOfQuestion)
        {
            FileStream file = new FileStream("C: \\Users\\Mega\\Documents\\Диплом УЦИТ\\Questions.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            while (!reader.EndOfStream)
                { 
                    listOfQuestion.Add(new QuestionPlusAnswers(reader.ReadLine(),reader.ReadLine(),reader.ReadLine(),reader.ReadLine(),reader.ReadLine()));
                }                
        }
        static public void ShowTest(Test test)
        {
            foreach (var k in test.ListOfQuestions)
            {
                InputAndOutput.ShowQuestion(k);

                Console.WriteLine("___________________________");

                test.Logic(k);
                
                Console.WriteLine();
            }
        }

    }
}
