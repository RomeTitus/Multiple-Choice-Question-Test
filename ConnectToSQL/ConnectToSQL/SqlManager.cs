using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConnectToSQL
{
    public class SqlManager
    {
        SqlConnection SqlConn = null;
        //connection string
        public void getConnection()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\James\OneDrive - Varsity College\17394632 Task 1 PROG\Assignment 1\Assignment 1\bin\Debug\database.mdf;Integrated Security=True";

            // Only create new connection object if it does not already exists
            if (SqlConn == null)
            {
                SqlConn = new SqlConnection(connectionString);

            }
        }
        //check if login exists
        public string[] attemptLogin(string ID_Number, string password)
        {
            string[] user = new string[3];
            if (ID_Number != "Enter ID" && password != "*********")
            {
                try
                {

                    getConnection();
                    String sqlString = "select userID, islecture from userInfo where(studentNumber ='" + ID_Number + "' AND password ='" + password + "')";
                    SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                    DataTable loginTable = new DataTable("User");


                    sqlDA.Fill(loginTable);
                    if (loginTable.Rows[0]["userID"].ToString() != "")
                    {
                        user[0] = loginTable.Rows[0]["userID"].ToString(); ;
                        user[1] = loginTable.Rows[0]["isLecture"].ToString();
                        user[2] = "true";

                    }
                }
                catch (Exception)
                {
                    user[0] = "";
                    user[1] = "false";
                    user[2] = "false";
                }
            }
            return user;
        }
        
        //gets the lecture name from the database
        public string LectureName(int User_ID)
        {
            try
            {
                getConnection();
                String sqlString = "select name from userInfo where(userID ='" + User_ID + "')";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable loginTable = new DataTable("User");
                sqlDA.Fill(loginTable);

                return loginTable.Rows[0]["name"].ToString();
            }
            catch (Exception)
            {
                return "unknown User";
            }
        }
        //get all the attempted answers that the user did
        public DataTable getUserMark(int userID, int testID)
        {

            try
            {
                getConnection();

                String sqlString = "select us.userID, qu.questionID ,userAnswer, actualAnswer "
                + "from Answer as an "
                + "inner join Questions as qu "
                + "on an.questionID = qu.questionID "
                + "full outer join userInfo as us "
                + "on us.userID = an.userID "
                + "where(an.userID = '" + userID + "' AND an.testID = '" + testID + "');";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable UserAnswer = new DataTable("UserAnswer");
                sqlDA.Fill(UserAnswer);

                return UserAnswer;
            }
            catch (Exception)
            {
                
                DataTable UserAnswer = new DataTable("UserAnswer"); //Returns an empty table if there is no tests
                return UserAnswer;
            }
        }
        //gets talll the students from the database
        public DataTable getAllStudent()
        {
            try
            {
                getConnection();
                String sqlString = "select userID, name, surname from userInfo where(isLecture ='false')";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable User = new DataTable("User");
                sqlDA.Fill(User);

                return User;
            }
            catch (Exception )
            {
                DataTable User = new DataTable("User"); //Returns an empty table if there is no tests
                return User;
            }
        }
        //adds a user to the database
        public void addUser(int User_ID, string name, string surname, string password, Boolean isLecture)
        {
            try

            {
                getConnection();
                // Use parameters in the SQL query string

                string sql = "insert into userInfo (studentNumber, name, surname, password, isLecture) " +

                              "values (@studentNumber, @name, @surname, @password, @isLecture)";

                // Create the Command object

                SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);
                SqlConn.Open();


                // Asign values to each parameter in the query string
                sqlCmd.Parameters.Add("@studentNumber", SqlDbType.Int, 30).Value = User_ID;
                sqlCmd.Parameters.Add("@name", SqlDbType.VarChar, 30).Value = name;
                sqlCmd.Parameters.Add("@surname", SqlDbType.VarChar, 30).Value = surname;
                sqlCmd.Parameters.Add("@password", SqlDbType.VarChar, 30).Value = password;
                sqlCmd.Parameters.Add("@isLecture", SqlDbType.VarChar, 20).Value = isLecture;// Connect to the DB
                // Execute the insert statement - it returns no result set and that is why ExecuteNonQuery is used
                sqlCmd.ExecuteNonQuery();
            }
            catch (System.Exception )
            {
                
            }
            finally
            {
                // Closes the database conection
                SqlConn.Close();
            }
        }

        public DataTable fillUserDatabase()
        {
            try
            {

                getConnection();
                String sqlString = "select userID, studentNumber, islecture from userInfo";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable userTable = new DataTable("UserTable");
                sqlDA.Fill(userTable);
                return userTable;
            }
            catch (Exception)
            {
                DataTable userTable = new DataTable("UserTable");
                return userTable; //will return an empty table when the program gets an errer such as having an empty table
            }
        }

        public void removeUser(int userID)
        {
            try
            {
                // Use parameters in the SQL query string
                string sql = "delete from userInfo " +
                             "where userID = @userID;";

                // Create the Command object
                SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);
                // Asign values to each parameter in the query string
                sqlCmd.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

                // Connect to the DB
                SqlConn.Open();
                // Execute the statement - it returns no result set and that is why ExecuteNonQuery is used

                sqlCmd.ExecuteNonQuery();
            }
            catch (System.Exception )
            {
                
            }
            finally
            {
                //close the DB connection 
                SqlConn.Close();
            }
        }

        public DataTable fillTestTable()
        {
            try
            {
                getConnection();

                String sqlString = "select * from Test";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable testTable = new DataTable("TestTable");
                sqlDA.Fill(testTable);

                return testTable;
            }
            catch (Exception)
            {
                DataTable testTable = new DataTable("TestTable"); //Returns an empty table if there is no tests
                return testTable;
            }
        }

        public DataTable fillQuestionTable(int TestID)
        {
            try
            {
                getConnection();
                String sqlString = "select questionID, question "
                                   + "from Questions "
                                   + "where (testID = " + TestID + ")";

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable QuestionTable = new DataTable("QuestionTable");
                sqlDA.Fill(QuestionTable);
                return QuestionTable;
            }
            catch (Exception)
            {
                DataTable QuestionTable = new DataTable("QuestionTable"); //Returns an empty table if there is no tests
                return QuestionTable;
            }
        }

        public DataTable fillUserAnswerTable(int userID, int testID)
        {
            DataTable myDataTable = new DataTable();
            try
            {
                getConnection();

                String sqlString = "select * from Answer Where userID='" + userID + "' and testID ='" + testID + "'";

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable UserAnswer = new DataTable("UserAnswer");
                sqlDA.Fill(UserAnswer);
                return UserAnswer;
            }
            catch (Exception)
            {
                DataTable QuestionTable = new DataTable("UserAnswer"); //Returns an empty table if there is no tests
                return QuestionTable;
            }
        }

        public DataTable GetAllQuestionsFromTest(int TestID)
        {
            try
            {


                getConnection();
                String sqlString = "select question, possibleAnswer1, possibleAnswer2, possibleAnswer3, possibleAnswer4, actualAnswer, testID, questionID "
                                   + "from Questions "
                                   + "where (testID = " + TestID + ")";

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable QuestionTable = new DataTable("QuestionTable");
                sqlDA.Fill(QuestionTable);
                return QuestionTable;
            }
            catch (Exception)
            {
                DataTable QuestionTable = new DataTable("QuestionTable"); //Returns an empty table if there is no tests
                return QuestionTable;
            }
        }

        public void DeleteTest(int TestID)
        {
            try
            {
                getConnection();
                //Removes the test From the database
                string sql = "delete from Answer " +
                            "Where testID = @testID;" +
                            "delete from Questions " +
                            "where testID = @testID;" +
                            "delete from Test " +
                            "Where testID = @testID";

                SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);
                sqlCmd.Parameters.Add("@testID", SqlDbType.Int).Value = TestID;
                SqlConn.Open();
                // Execute the statement - it returns no result set and that is why ExecuteNonQuery is used
                sqlCmd.ExecuteNonQuery();
                //close the DB connection 
                SqlConn.Close();
            }
            catch (Exception )
            {
              
            }
        }

        public void SaveQuestiontoTest(int QuestionID, String question, String answerA, String answerB, String answerC, String answerD, char actualAnswer)
        {
            try

            {
                getConnection();
                // Use parameters in the SQL query string
                string sql = "Update Questions "
                            + "SET question = @question, possibleAnswer1 = @possibleAnswer1, possibleAnswer2 = @possibleAnswer2, possibleAnswer3 = @possibleAnswer3, possibleAnswer4 = @possibleAnswer4, actualAnswer = @actualAnswer "
                            + "Where questionID = @questionID";


                SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);

                SqlConn.Open();

                // Create the Command object

                // Asign values to each parameter in the query string
                sqlCmd.Parameters.Add("@questionID", SqlDbType.Int, 30).Value = QuestionID;
                sqlCmd.Parameters.Add("@question", SqlDbType.VarChar, 30).Value = question;
                sqlCmd.Parameters.Add("@possibleAnswer1", SqlDbType.VarChar, 30).Value = answerA;
                sqlCmd.Parameters.Add("@possibleAnswer2", SqlDbType.VarChar, 30).Value = answerB;
                sqlCmd.Parameters.Add("@possibleAnswer3", SqlDbType.VarChar, 30).Value = answerC;
                sqlCmd.Parameters.Add("@possibleAnswer4", SqlDbType.VarChar, 30).Value = answerD;
                sqlCmd.Parameters.Add("@actualAnswer", SqlDbType.Char, 20).Value = actualAnswer;
                // Execute the insert statement - it returns no result set and that is why ExecuteNonQuery is used

                sqlCmd.ExecuteNonQuery();
            }
            catch (System.Exception )
            {
               
            }
            finally
            {
                // close the DB connection
                SqlConn.Close();
            }
        }

        public void SaveQuestiontoNewTest(String TestName, String[,] QuestionInArray)
        {

            String question;
            String answerA;
            String answerB;
            String answerC;
            String answerD;
            char actualAnswer;

            int testID = 0;
            try
            {
                getConnection();
                string sql = "insert into Test (TestName) " +
                              "values (@TestName)";
                SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);
                SqlConn.Open();
                sqlCmd.Parameters.Add("@TestName", SqlDbType.VarChar, 30).Value = TestName;
                sqlCmd.ExecuteNonQuery();
            }
            catch (System.Exception )
            {
               
            }
            finally
            {
                // close the DB connection
                SqlConn.Close();
            }


            try
            {
                String sqlString = "select testID from Test where(testName ='" + TestName + "')";
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);
                DataTable TestTable = new DataTable("Test");
                sqlDA.Fill(TestTable);
                testID = Convert.ToInt16(TestTable.Rows[0]["testID"].ToString());
            }
            catch (Exception )
            {

            }
            for (int i = 0; i < QuestionInArray.GetLength(0); i++)
            {
                try

                {

                    // Use parameters in the SQL query string


                    question = QuestionInArray[i, 0];
                    answerA = QuestionInArray[i, 1];
                    answerB = QuestionInArray[i, 2];
                    answerC = QuestionInArray[i, 3];
                    answerD = QuestionInArray[i, 4];
                    actualAnswer = Convert.ToChar(QuestionInArray[i, 5]);


                    string sql = "insert into Questions (TestID, question, possibleAnswer1, possibleAnswer2, possibleAnswer3, possibleAnswer4, actualAnswer) " +
                                  "values (@TestID, @question, @possibleAnswer1, @possibleAnswer2, @possibleAnswer3, @possibleAnswer4, @actualAnswer)";

                    SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);

                    SqlConn.Open();

                    // Create the Command object

                    // Asign values to each parameter in the query string
                    sqlCmd.Parameters.Add("@testID", SqlDbType.Int, 30).Value = testID;
                    sqlCmd.Parameters.Add("@question", SqlDbType.VarChar, 30).Value = question;
                    sqlCmd.Parameters.Add("@possibleAnswer1", SqlDbType.VarChar, 30).Value = answerA;
                    sqlCmd.Parameters.Add("@possibleAnswer2", SqlDbType.VarChar, 30).Value = answerB;
                    sqlCmd.Parameters.Add("@possibleAnswer3", SqlDbType.VarChar, 30).Value = answerC;
                    sqlCmd.Parameters.Add("@possibleAnswer4", SqlDbType.VarChar, 30).Value = answerD;
                    sqlCmd.Parameters.Add("@actualAnswer", SqlDbType.Char, 20).Value = actualAnswer;
                    // Execute the insert statement - it returns no result set and that is why ExecuteNonQuery is used

                    sqlCmd.ExecuteNonQuery();

                }
                catch (System.Exception )
                {
                    
                }
                finally
                {
                    // close the DB connection
                    SqlConn.Close();
                }
            }
        }

        public void addUserAnswer(int userID, int testID, int questionNumber, Char userAnswer)
        {
            try
            {
                string sql = "insert into Answer (userID, testID, questionID, userAnswer) " +

                              "values (@userID, @testID, @questionID, @userAnswer)";

                // Create the Command object

                SqlCommand sqlCmd = new SqlCommand(sql, SqlConn);
                SqlConn.Open();

                sqlCmd.Parameters.Add("@userID", SqlDbType.Int, 30).Value = userID;
                sqlCmd.Parameters.Add("@testID", SqlDbType.Int, 30).Value = testID;
                sqlCmd.Parameters.Add("@questionID", SqlDbType.Int, 30).Value = questionNumber;
                sqlCmd.Parameters.Add("@userAnswer", SqlDbType.Char).Value = userAnswer;

                // Execute the insert statement
                sqlCmd.ExecuteNonQuery();
            }
            catch (System.Exception )
            {
               
            }
            finally
            {
                // Closes the database conection
                SqlConn.Close();
            }
        }

        public char getUserAnswer(int userID, int testID, int questionNumber)
        {
            DataTable UserAnswer = new DataTable();
            try
            {
                getConnection();

                String sqlString = "select userAnswer from Answer Where userID='" + userID + "' and testID ='" + testID + "' and questionID='" + questionNumber + "'";

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlString, SqlConn);

                sqlDA.Fill(UserAnswer);

                return Convert.ToChar(UserAnswer.Rows[0]["userAnswer"].ToString());

            }
            catch (Exception )
            {
                return '0';

            }
        }

       
    }
}
