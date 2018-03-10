using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    internal class InputAndOutput
    {
        public static string PathToFile = "C:\\Users\\Mega\\Documents\\Диплом УЦИТ\\Diplom\\Application_for_testing.git\\Diplom\\Questions.txt";
        public static void ShowQuestion(QuestionPlusAnswers k)
        {
            Console.WriteLine(k.Question.TextOfQuestion);
            foreach (var answer in k.ListOfAnswers)
            {
                Console.WriteLine(answer.TextOfAnswer);
            }

        }

        public static void AddQuestionFromFile(List<QuestionPlusAnswers> listOfQuestion)
        {
            using (var file = new FileStream(PathToFile, FileMode.Open))
            {
               var reader = new StreamReader(file);
               while (!reader.EndOfStream)
               {
                   var question = new Question(reader.ReadLine());
                   var correctAnswer = new CorrectAnswer(reader.ReadLine());
                   var falseAnswerOne = new FalseAnswer(reader.ReadLine());
                   var falseAnswerSecond = new FalseAnswer(reader.ReadLine());
                   var falseAnswerThird = new FalseAnswer(reader.ReadLine());
                    var questionPlusAnswers = new QuestionPlusAnswers(question, correctAnswer, falseAnswerOne, falseAnswerSecond, falseAnswerThird);
                   listOfQuestion.Add(questionPlusAnswers);
               } 
            }
        }

        public static void ShowTest(Test test)
        {
            foreach (var k in test.ListOfQuestions)
            {
                ShowQuestion(k);

                Console.WriteLine("___________________________");

                test.Logic(k);
                
                Console.WriteLine();
            }
        }

    }
}
