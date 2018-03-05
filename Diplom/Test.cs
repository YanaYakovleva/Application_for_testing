using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diplom
{
    class Test
    {
        string TestName { get; set; }
        public List<QuestionPlusAnswers> ListOfQuestions { get; set; }
        public Test(string testName)
        {
            this.TestName = testName;
            ListOfQuestions = new List<QuestionPlusAnswers>();
            InputAndOutput.AddQuestionFromFile(ListOfQuestions);
        }

        public void Logic(QuestionPlusAnswers qpa)
        {
            switch (Console.ReadLine())
            {
                case "1": if (qpa.ListOfAnswers[0].GetType().Name is "CorrectAnswer") Result.ResultOfTest++; break;
                case "2": if (qpa.ListOfAnswers[1].GetType().Name is "CorrectAnswer") Result.ResultOfTest++; break;
                case "3": if (qpa.ListOfAnswers[2].GetType().Name is "CorrectAnswer") Result.ResultOfTest++; break;
                case "4": if (qpa.ListOfAnswers[3].GetType().Name is "CorrectAnswer") Result.ResultOfTest++; break;
                default: break;
            }
        }

        
    }
}
