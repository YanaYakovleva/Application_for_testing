using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class QuestionPlusAnswers
    {
        public Question Question { get; set; }
        public List<Answer> ListOfAnswers { get; set; } 
        public CorrectAnswer CorrectAnswer { get; set; }
        public FalseAnswer FalseAnswer1 { get; set; }
        public FalseAnswer FalseAnswer2 { get; set; }
        public FalseAnswer FalseAnswer3 { get; set; }
        

        public QuestionPlusAnswers(string q, string ca, string fa1, string fa2, string fa3)
        {
            this.Question = new Question(q);
            this.CorrectAnswer = new CorrectAnswer(ca);
            this.FalseAnswer1 = new FalseAnswer(fa1);
            this.FalseAnswer2 = new FalseAnswer(fa2);
            this.FalseAnswer3 = new FalseAnswer(fa3);
            ListOfAnswers = new List<Answer>();
            AddInList();
            Stirrer.Stir(ListOfAnswers);
        }

        public void AddInList()
        {
            ListOfAnswers.Add(CorrectAnswer);
            ListOfAnswers.Add(FalseAnswer1);
            ListOfAnswers.Add(FalseAnswer2);
            ListOfAnswers.Add(FalseAnswer3);
        }


    }
}
