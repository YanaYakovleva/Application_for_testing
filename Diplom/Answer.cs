using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    class Answer
    {
        public string TextOfAnswer { get; set; }
        public Answer(string text)
        {
            this.TextOfAnswer = text;
        }
        bool isTrue;

    }
}
