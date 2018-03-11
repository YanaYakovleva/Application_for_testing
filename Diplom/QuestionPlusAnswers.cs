using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    internal class QuestionPlusAnswers
    {
        public Question Question { get; }
        public List<Answer> ListOfAnswers { get; }

        public QuestionPlusAnswers(Question question, CorrectAnswer correctAnswer, params FalseAnswer[] falseAnswers)
        {
            Question = question;
            ListOfAnswers = new List<Answer>();
            ListOfAnswers.Add(correctAnswer);
            foreach (var answer in falseAnswers)
            {
                ListOfAnswers.Add(answer);
            }
            Stirrer.Stir(ListOfAnswers);
        }

    }
}
