using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConnectToSQL;

namespace Assignment_1
{
    class Test
    {
        SqlManager sql = new SqlManager();
        DataTable QuestionDataBase;
        String[,] QuestionInTest = new String[0, 0];
        char[] UserAnswer;
        
        //Adds a question to the Question array
        public void setQuestion(String question, String answerA, String answerB, String answerC, String answerD, char actualAnswer, int index)
        {
            if (QuestionInTest.GetLength(0) <= index)
            {
                QuestionInTest = resizeQuestionArray(QuestionInTest);
            }
            
            
            QuestionInTest[index, 0] = question;
            QuestionInTest[index, 1] = answerA;
            QuestionInTest[index, 2] = answerB;
            QuestionInTest[index, 3] = answerC;
            QuestionInTest[index, 4] = answerD;
            QuestionInTest[index, 5] = Convert.ToString(actualAnswer);
        }
        //clears the question array
        public void ClearTest()
        {
            QuestionInTest = new String[0, 0];
        }
        //makes the question array larger
        private String[,] resizeQuestionArray(String[,] QuestionInTest)
        {
            String[,] Question = new String[(QuestionInTest.GetLength(0))+1,6];

            for (int i = 0; i < QuestionInTest.GetLength(0); i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Question[i, j] = QuestionInTest[i, j];
                }
            }
            
            return Question;
        }

        //Returns a Question from using an index
        public String[] loadQuestionByIndex(int index)
        {
            String[] Question = new String [6];

            for (int i = 0; i < Question.GetLength(0); i++)
            {
                Question[i] = QuestionInTest[index, i];
            }

            return Question;
        }

        public int getSizeOfTest()
        {
            return QuestionInTest.GetLength(0);
            
        }

        public void loadQuestionFromDatabase(int testID)
        {
            QuestionDataBase = sql.GetAllQuestionsFromTest(testID);
            QuestionInTest = new string[QuestionDataBase.Rows.Count, 8]; //Includes the QuestionID
            for (int i = 0; i < QuestionDataBase.Rows.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    QuestionInTest[i, j] = QuestionDataBase.Rows[i][j].ToString();
                }
            }
          
        }

        public void SaveTestToDatabase(Boolean IsEdditted, String TestName)
        {
            if (IsEdditted == true)
            {
                for (int i = 0; i < QuestionInTest.GetLength(0); i++)
                {
                    sql.SaveQuestiontoTest(Convert.ToInt16(QuestionInTest[i, 7]), QuestionInTest[i, 0], QuestionInTest[i, 1], QuestionInTest[i, 2], QuestionInTest[i, 3], QuestionInTest[i, 4], Convert.ToChar(QuestionInTest[i, 5]));
                }
            }
            else
            {
             sql.SaveQuestiontoNewTest(TestName, QuestionInTest);   
            }
            
        }

        public void setSizeOfUserAnswer()
        {
            UserAnswer = new char[QuestionInTest.GetLength(0)];
        }

        public void SetUserAnswer(char answer, int questionID)
        {
            UserAnswer[questionID] = answer;
        }

        public char getUserAnswer(int index)
        {
            return UserAnswer[index];
        }

        public void saveUserAnswerWithTest(int userID, int TestID)
        {
            for (int i = 0; i < UserAnswer.GetLength(0); i++)
            {
                sql.addUserAnswer(userID, TestID, Convert.ToInt16(QuestionInTest[i, 7]), UserAnswer[i]);
            }

            
        }
            
        public char getUserAnswer(int userID, int testID, int QuestionNumber)
        {
           return sql.getUserAnswer(userID, testID, Convert.ToInt16(QuestionInTest[QuestionNumber, 7]));
        }
    }
}
