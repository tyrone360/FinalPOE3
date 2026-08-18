using System.Collections.Generic;

namespace demo
{//start of namespace
    public class Question_in_quiz
    {//satrt of classs
        // The text of the quiz question
        public string Text { get; set; }

        // The correct answer to the question
        public string correctAnswer { get; set; }

        // A list of wrong answer options for the question
        public List<string> wrongAnswer { get; set; }
    }//end of class
}//start of namespace
