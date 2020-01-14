using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using ConnectToSQL;
using System.Threading;

namespace Assignment_1
{
    class Result
    {
        SqlManager sql = new SqlManager();
        Test test = new Test();
        
       
        DataTable UserAnswer;
        int highestScore = 0;
        int AverageScore = 0;
        int lowestScore = int.MaxValue;
        int length = 0;

        public Boolean checkIfTestHasBeenTake(int userID, int testID) //Checks if the student has attempted the test
        {
            UserAnswer = sql.getUserMark(userID, testID);
            if (UserAnswer.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
        //Calculate student score
        public double getStudentPoints(int userID, int testID)
        {
            length++;
            int mark = 0;
            UserAnswer = sql.getUserMark(userID, testID);
            
            for (int i = 0; i < UserAnswer.Rows.Count; i++)
            {
                if (UserAnswer.Rows[i][2].ToString() == UserAnswer.Rows[i][3].ToString()) //checking if the user answer matches the correct answer
                {
                    mark++;
                }
            }
            setHighestScore(mark);
            setAverageScore(mark);
            setLowestScore(mark);
            if (mark == 0)
            {
                return 0; // Return 0 if student has not taken test before
            }
            return (double)mark / UserAnswer.Rows.Count * 100;
        }
        public void resetScore()
        {
            highestScore = 0;
            AverageScore = 0;
            lowestScore = int.MaxValue;
        }

        private void setHighestScore(int score)
        {
            if (score > highestScore)
            {
                highestScore = score;
            }
        }
        private void setAverageScore(int score)
        {
            AverageScore = AverageScore + score;
        }
        private void setLowestScore(int score)
        {
            if (score < lowestScore)
            {
                lowestScore = score;
            }
        }
        //gets highest score
        public double getHighestScore(int testID)
        {
            double percent = 0;
            
            test.loadQuestionFromDatabase(testID); //loads the questions to find the percent in a test
            
            percent = (double)highestScore / test.getSizeOfTest()*100;
            
            return percent;
        }
        //gets average score
        public double getAverageScore(int testID, int numberOfStudents)
        {
            double percent = 0;
            percent = ((double)AverageScore / length) / test.getSizeOfTest() * 100;
            length = 0;
            return percent;
        }
        //gets the lowest score
        public double getLowestScore(int testID)
        {
            double percent = 0;
            test.loadQuestionFromDatabase(testID); //loads the questions to find they percent in a test
            percent = (double)lowestScore / test.getSizeOfTest() *100;
            return percent;
        }
        //saves the result to the file
        public void saveMarkToFile()
        {
            Thread thread1 = new Thread(() => {
                
                
            
            Result result = new Result();
            DataTable TestDataTable = new DataTable();

            TestDataTable = sql.fillTestTable();

            DataTable UserTable = new DataTable();
            UserTable = sql.getAllStudent();

            using (StreamWriter outFile = new StreamWriter("Report.txt", false)) //Rewrites everythig in the file
            {
                for (int i = 0; i < TestDataTable.Rows.Count; i++)
                {
                    int TestID = Convert.ToInt16(TestDataTable.Rows[i]["testID"].ToString()); // Gets the primary Key of the Test



                    outFile.WriteLine(TestDataTable.Rows[i]["testName"].ToString());
                    outFile.WriteLine(String.Format("{0} {1} {2} {3} {4}", "NAME".PadRight(30), "|", "SURNAME".PadRight(30), "|", "PERCENT".PadRight(30)));
                    outFile.WriteLine("---------------------------------------------------------------------------------------------------");

                    for (int J = 0; J < UserTable.Rows.Count; J++)
                    {
                        if (result.checkIfTestHasBeenTake(Convert.ToInt16(UserTable.Rows[J]["userID"].ToString()), TestID) == true)
                        {
                            outFile.WriteLine(String.Format("{0} | {1} | {2:0.00}%", (UserTable.Rows[J]["name"].ToString()).PadRight(30), (UserTable.Rows[J]["surname"].ToString()).PadRight(30),  result.getStudentPoints(Convert.ToInt16(UserTable.Rows[J]["userID"].ToString()), TestID)));
                        }
                        else
                        {
                            outFile.WriteLine(String.Format("{0} {1} {2} {3} {4}", (UserTable.Rows[J]["name"].ToString()).PadRight(30), "|", (UserTable.Rows[J]["surname"].ToString()).PadRight(30), "|", "Did not Attempt"));
                        }


                    }
                    outFile.WriteLine("Lowest: " + "{0:0.00}%".PadRight(26) + "| Average: {1:0.00}%".PadRight(36) + "| Highest: {2:0.00}%".PadRight(30), (result.getLowestScore(TestID)), result.getAverageScore(TestID, Convert.ToInt32(UserTable.Rows.Count.ToString())), result.getHighestScore(TestID));


                    outFile.WriteLine("---------------------------------------------------------------------------------------------------");
                    outFile.WriteLine();
                    result.resetScore();
                }

            }
            });
            thread1.Start();
        }


    }
}
