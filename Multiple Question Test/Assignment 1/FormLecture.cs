using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ConnectToSQL;

namespace Assignment_1
{
    public partial class FormLecture : Form
    {
        Test test = new Test();
        
        SqlManager sql = new SqlManager();


        Result result = new Result();
        DataTable UserTable;
        DataTable TestDatabase;
        DataTable QuestionDataBase;
        DataTable UserInfo;
        int pageIndex = 0; // used to get the question from The test
        Boolean editExistingQuestion = false;

       //Constructor
        public FormLecture(int userID)
        {

            InitializeComponent();
            MainMenuForm();

            getLectureName(userID);

        }

        //Adds a new student to the database
        private void AddStudentForm()
        {
            Lecturetab.SelectedTab = tabPage2;
            btnDelete.Text = "Delete";
            buttenPressedTwice = false;
            populateUserList();
            radiobtnStudent.Checked = true;
            txtboxID.ForeColor = Color.Gray;
            txtboxID.Text = "User ID No.";
            txtboxName.ForeColor = Color.Gray;
            txtboxName.Text = "Name";
            txtboxPassword.ForeColor = Color.Gray;
            txtboxPassword.Text = "Password";
            txtboxSurname.ForeColor = Color.Gray;
            txtboxSurname.Text = "Surname";
            groupBoxDelete.Visible = true;
            
        }

        //Loads back the main menu
        private void MainMenuForm()
        {
            Lecturetab.SelectedTab = tabPage1;
            
        }

        //uses multithread to get lecture Name
        private void getLectureName(int userID)
        {
            string name = "";
            lblLecture.Text = "Lecture: . . . .";
            //gets the Lecture name from the database with a new thread
            Thread thread1 = new Thread(() => { name = sql.LectureName(userID);
            Action action = () => lblLecture.Text = "Lecture: " + name; 
             this.BeginInvoke(action); //tells the main thread to exicute this comand
            });
            thread1.Start();
           
        }
        
        //gets all the users in the database
        private void populateUserList()
        {
            //clears everything in the list box
            listUser.Items.Clear();
            UserTable = sql.fillUserDatabase(); //passes the data table with all the users stored (Does not store names or passwords)
            for (int i = 0; i < UserTable.Rows.Count; i++)
            {
                
                listUser.Items.Add(UserTable.Rows[i]["studentNumber"].ToString() +" is Lecture: "+ UserTable.Rows[i]["islecture"].ToString());
            }
          
        }
        //checks each individual txtbox to make sure the data is corrent
        private void checkUserData(string user_ID, string name, string surname, string password)
        {
            Boolean correctUser_ID = false;
            Boolean correctName = false;
            Boolean correctSurname = false;
            Boolean correctPassword = false;
            Boolean isLecture = false;
            try
            {
                Convert.ToInt16(user_ID);
                correctUser_ID = true;
            }
            catch (Exception)
            {
                txtboxID.ForeColor = Color.Red;
                txtboxID.Text = "Only Numerals";    
            }
            if (txtboxName.Text == "" || txtboxName.Text == "Name" || txtboxName.Text == "Enter Name" || txtboxName.Text == "Added" || txtboxName.Text == "Removed")
            {
                txtboxName.ForeColor = Color.Red;
                txtboxName.Text = "Enter Name";
            }
            else
            {
                correctName = true;
            }
            if (txtboxSurname.Text == "" || txtboxSurname.Text == "Surname" || txtboxSurname.Text == "Enter Surname" || txtboxSurname.Text == "To The" || txtboxSurname.Text == "From The")
            {
                txtboxSurname.ForeColor = Color.Red;
                txtboxSurname.Text = "Enter Surname";
            }
            else
            {
                correctSurname = true;
            }
            if (txtboxPassword.Text == "" || txtboxPassword.Text == "Password" || txtboxPassword.Text == "Enter Password" || txtboxPassword.Text == "Database")
            {
                txtboxPassword.ForeColor = Color.Red;
                txtboxPassword.Text = "Enter Password";
            }
            else
            {
                correctPassword = true;
            }
            if (radiobtnStudent.Checked == true)
            {
                isLecture = false;
            }
            else
            {
                isLecture = true;
            }
            if (correctUser_ID == true && correctName == true && correctSurname == true && correctPassword == true)
            {
                //thread takes care to add User to the database
                Thread thread1 = new Thread(() => {
                    sql.addUser(Convert.ToInt32(txtboxID.Text), txtboxName.Text, txtboxSurname.Text, txtboxPassword.Text, isLecture);
                    Action action = () => txtboxID.Text = "Successfully";
                    
                    //tells the main thread to exicute this comand
                    action += () => txtboxID.ForeColor = Color.Green;

                    action += () => txtboxName.Text = "Added";

                    action += () => txtboxName.ForeColor = Color.Green;

                    action += () => txtboxSurname.Text = "To The";

                    action += () => txtboxSurname.ForeColor = Color.Green;

                    action += () => txtboxPassword.Text = "Database";

                    action += () => txtboxPassword.ForeColor = Color.Green;

                    action += () => populateUserList();

                    this.BeginInvoke(action); //tells the main thread to exicute this comand
                });
                thread1.Start();
                
            }
        }

        //opens the testTab
        private void ChangeToTestForm()
        {
            btnDeleteTest.Enabled = false;
            btnEditTest.Enabled = false;

            txtboxTestName.Text = "Enter Test Name";
            txtboxTestName.ForeColor = Color.Gray;

            txtboxQuestion.Text = "Enter Question";
            txtboxQuestion.ForeColor = Color.Gray;

            Lecturetab.SelectedTab = tabPage3;
            populateTestForChangeTestForm();
            
        }
        //Loads the Question Form
        private void ChangeQuestionForm()
        {
            Lecturetab.SelectedTab = tabPage4;
            txtboxQuestion.Text = "Enter Question";
            txtboxQuestion.ForeColor = Color.Gray;

            txtboxA.Text = "Enter Possible Answer";
                txtboxA.ForeColor = Color.Gray;
            
                txtboxB.Text = "Enter Possible Answer";
                txtboxB.ForeColor = Color.Gray;
            
                txtboxC.Text = "Enter Possible Answer";
                txtboxC.ForeColor = Color.Gray;
            
            
                txtboxD.Text = "Enter Possible Answer";
                txtboxD.ForeColor = Color.Gray;

            radioButtonA.Checked = true;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
        }

        //gets all the tests in the database
        private void populateTestForChangeTestForm()
        {
            listBoxTest.Items.Clear();
            TestDatabase = sql.fillTestTable();

            for (int i = 0; i < TestDatabase.Rows.Count; i++)
            {
                listBoxTest.Items.Add(TestDatabase.Rows[i]["testName"].ToString());
            }
        }
        //gets the qestions thats in the test that is selected
        private void populateQuestion(int TestID)
        {
            listBoxQuestion.Items.Clear();
            QuestionDataBase = sql.fillQuestionTable(TestID);

            for (int i = 0; i < QuestionDataBase.Rows.Count; i++)
            {
                listBoxQuestion.Items.Add( (i+1) +": "+ QuestionDataBase.Rows[i]["question"].ToString());
            }
        }
        
        //Opens add student tab
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddStudentForm();
        }
        //opens the test form
        private void btnTest_Click(object sender, EventArgs e)
        {
            ChangeToTestForm();
        }
        //opens result form
        private void btnResults_Click(object sender, EventArgs e) //Loads the ResultsForm
        {
            populateTestForResultForm();
            
            Lecturetab.SelectedTab = tabPage5;
            
        }
        //changes butten colour
        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btnEdit.BackColor = Color.DarkGreen;
        }
        //changes butten colour
        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btnEdit.BackColor = Color.Green;
        }
        //changes butten colour
        private void btnTest_MouseEnter(object sender, EventArgs e)
        {
            this.btnTest.BackColor = Color.DarkGreen;
        }
        //changes butten colour
        private void btnTest_MouseLeave(object sender, EventArgs e)
        {
            this.btnTest.BackColor = Color.Green;
        }
        //changes butten colour
        private void btnResults_MouseEnter(object sender, EventArgs e)
        {
            this.btnResults.BackColor = Color.DarkGreen;
        }
        //changes butten colour
        private void btnResults_MouseLeave(object sender, EventArgs e)
        {
            this.btnResults.BackColor = Color.Green;
        }
        //loads main menu
        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenuForm();
        }

        //clears the TextBox when clicked
        private void txtboxID_Click(object sender, EventArgs e)
        {
            if (txtboxID.Text == "User ID No." || txtboxID.Text == "Only Numerals" || txtboxID.Text == "Successfully")
            {
                txtboxID.Text = "";
            }
            
            txtboxID.ForeColor = Color.Black;
        }

        private void txtboxName_Click(object sender, EventArgs e)
        {
            if (txtboxName.Text == "Name" || txtboxName.Text == "Enter Name" || txtboxName.Text == "Added" || txtboxName.Text == "Removed")
            {
                txtboxName.Text = "";
            }
            
            txtboxName.ForeColor = Color.Black;
        }

        private void txtboxSurname_Click(object sender, EventArgs e)
        {
            if (txtboxSurname.Text == "Surname" || txtboxSurname.Text == "Enter Surname" || txtboxSurname.Text == "To The" || txtboxSurname.Text == "From The")
            {
                txtboxSurname.Text = "";
            }
            
            txtboxSurname.ForeColor = Color.Black;
        }

        private void txtboxPassword_Click(object sender, EventArgs e)
        {
            if (txtboxPassword.Text == "Password" || txtboxPassword.Text == "Enter Password" || txtboxPassword.Text == "Database")
            {
                txtboxPassword.Text = "";
            }
            
            txtboxPassword.ForeColor = Color.Black;
        }

        //Creates the Users that get added in the Database
        private void btnCreate_Click(object sender, EventArgs e)
        {
            checkUserData(txtboxID.Text, txtboxName.Text, txtboxSurname.Text, txtboxPassword.Text);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.DarkGreen;
        }

        private void btnCreate_MouseLeave(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.Green;
        }

        private void btnCreate_MouseEnter(object sender, EventArgs e)
        {
            btnCreate.BackColor = Color.DarkGreen;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Green;
        }

        //User has to press the delete butten twice to make sure there is no accidental deletions
        Boolean buttenPressedTwice = false;
        //Delete student from the database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(listUser.SelectedIndex != -1)
            {
                if (buttenPressedTwice == true)
                {

                    sql.removeUser(Convert.ToInt16(UserTable.Rows[listUser.SelectedIndex][0].ToString()));

                    populateUserList();


                    txtboxID.Text = "Successfully";
                    
                    txtboxID.ForeColor = Color.Red;

                    txtboxName.Text = "Removed";

                    txtboxName.ForeColor = Color.Red;

                    txtboxSurname.Text = "From The";

                    txtboxSurname.ForeColor = Color.Red;

                    txtboxPassword.Text = "Database";

                    txtboxPassword.ForeColor = Color.Red;

                    buttenPressedTwice = false;
                    btnDelete.Text = "Delete";

                    Thread ReloadAddStudentForm = new Thread(() => {
                        Thread.Sleep(1500); //Allows the user to read the prompt before it goes away
                        Action action = () => AddStudentForm();
                        this.BeginInvoke(action); //tells the main thread to exicute this comand
                    });
                    ReloadAddStudentForm.Start();


                }
                else if (buttenPressedTwice == false)
                {
                    buttenPressedTwice = true;
                    btnDelete.Text = "Confirm to Delete";
                }
                
            }
            
            //Delete selected user
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.DarkGreen;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Green;
        }

        private void listUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttenPressedTwice = false;
            btnDelete.Text = "Delete";
        }

        private void btnCreateTest_MouseEnter(object sender, EventArgs e)
        {
            btnCreateTest.BackColor = Color.DarkGreen;
        }

        private void btnCreateTest_MouseLeave(object sender, EventArgs e)
        {
            btnCreateTest.BackColor = Color.Green;
        }

        private void btnEditTest_MouseEnter(object sender, EventArgs e)
        {
            btnEditTest.BackColor = Color.DarkGreen;
        }

        private void btnEditTest_MouseLeave(object sender, EventArgs e)
        {
            btnEditTest.BackColor = Color.Green;
        }

        private void btnDeleteTest_MouseEnter(object sender, EventArgs e)
        {
            btnDeleteTest.BackColor = Color.DarkGreen;
        }

        private void btnDeleteTest_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteTest.BackColor = Color.Green;
        }

        private void listBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTest.SelectedIndex != -1)
            {
                btnDeleteTest.Enabled = true;
                btnEditTest.Enabled = true;
                populateQuestion(Convert.ToInt16(TestDatabase.Rows[listBoxTest.SelectedIndex]["testID"].ToString())); //gives the TestID to the method
            }
            
        }

        

        private void btnDeleteTest_Click(object sender, EventArgs e)
        {
            
            if (listBoxTest.SelectedIndex != -1)
            {
                sql.DeleteTest(Convert.ToInt16(TestDatabase.Rows[listBoxTest.SelectedIndex]["testID"].ToString()));
                listBoxQuestion.Items.Clear();
                populateTestForChangeTestForm();
                
                    btnEditTest.Enabled = false;
                    btnDeleteTest.Enabled = false;
                
                
            }
        }
        //From the Test Form, goes back to the Main Menu Form
        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuForm();
        }

        //From the Create Test Form, goes back to the Main Menu Form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            test.ClearTest();
            ChangeToTestForm();
            btnNext.Enabled = true;
        }

        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.BackColor = Color.DarkGreen;
            lblPrevious.BackColor = Color.DarkGreen;
            lblQuestionNumber.BackColor = Color.DarkGreen;
            lblQuestion.BackColor = Color.DarkGreen;
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            btnPrevious.BackColor = Color.Green;
            lblPrevious.BackColor = Color.Green;
            lblQuestionNumber.BackColor = Color.Green;
            lblQuestion.BackColor = Color.Green;
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.DarkGreen;
            lblNext.BackColor = Color.DarkGreen;
            lblTestCount.BackColor = Color.DarkGreen;
            lblMaxQuestion.BackColor = Color.DarkGreen;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Green;
            lblNext.BackColor = Color.Green;
            lblTestCount.BackColor = Color.Green;
            lblMaxQuestion.BackColor = Color.Green;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.DarkGreen;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Green;
        }

        private void btnSaveTest_MouseEnter(object sender, EventArgs e)
        {
            btnSaveTest.BackColor = Color.DarkGreen;
        }

        private void btnSaveTest_MouseLeave(object sender, EventArgs e)
        {
            btnSaveTest.BackColor = Color.Green;
        }

        //Checks if the questions are all valid then loads the to the Test Array in the CreateTest Class
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (checkQuestionCorrectFormat() == true)
            {
                
                try //If the question Exist then Display the QUestion else create new question
                {
                    LoadQuestionFromIndex();
                }
                catch
                {
                    ChangeQuestionForm();
                }
            }
            
        }

        
        private char getCorrectAnswer()
        {
            if (radioButtonA.Checked == true)
            {
                return 'A';
            } else if (radioButtonB.Checked == true)
            {
                return 'B';
            } else if (radioButtonC.Checked == true)
            {
                return 'C';
            }
            else
            {
                return 'D';
            }
        }

        private void btnCreateTest_Click(object sender, EventArgs e) //Loads form to make a test
        {
            editExistingQuestion = false;
            btnSaveTest.Text = "Create";
            btnPrevious.Enabled = false;
            lblTestCount.Text = (test.getSizeOfTest()).ToString();
            pageIndex = 0;
            ChangeQuestionForm();
        }

        private void txtboxTestName_Click(object sender, EventArgs e)
        {
            if (txtboxTestName.Text == "Enter Test Name")
            {
                txtboxTestName.Text = "";
                txtboxTestName.ForeColor = Color.Black;
            }
        }

        private void txtboxQuestion_Click(object sender, EventArgs e)
        {
            if (txtboxQuestion.Text == "Enter Question")
            {
                txtboxQuestion.Text = "";
                txtboxQuestion.ForeColor = Color.Black;
            }
        }

        private void txtboxA_Click(object sender, EventArgs e)
        {
            if (txtboxA.Text == "Enter Possible Answer")
            {
                txtboxA.Text = "";
                txtboxA.ForeColor = Color.Black;
            }
        }

        private void txtboxB_Click(object sender, EventArgs e)
        {
            if(txtboxB.Text == "Enter Possible Answer")
            {
                txtboxB.Text = "";
                txtboxB.ForeColor = Color.Black;
            }
        }

        private void txtboxC_Click(object sender, EventArgs e)
        {
            if(txtboxC.Text == "Enter Possible Answer")
            {
                txtboxC.Text = "";
                txtboxC.ForeColor = Color.Black;
            }
        }

        private void txtboxD_Click(object sender, EventArgs e)
        {
            if(txtboxD.Text == "Enter Possible Answer")
            {
                txtboxD.Text = "";
                txtboxD.ForeColor = Color.Black;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pageIndex = pageIndex - 1; //gets the previous question
            btnNext.Enabled = true;
            lblQuestionNumber.Text = (1 + pageIndex).ToString();
            LoadQuestionFromIndex();
        }

        private void LoadQuestionFromIndex()
        {
            txtboxQuestion.ForeColor = Color.Black;
            txtboxA.ForeColor = Color.Black;
            txtboxB.ForeColor = Color.Black;
            txtboxC.ForeColor = Color.Black;
            txtboxD.ForeColor = Color.Black;
            
            if (pageIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
            String[] Question = test.loadQuestionByIndex(pageIndex);
            txtboxQuestion.Text = Question[0];
            txtboxA.Text = Question[1];
            txtboxB.Text = Question[2];
            txtboxC.Text = Question[3];
            txtboxD.Text = Question[4];
            if (Question[5] == "A")
            {
                radioButtonA.Checked = true;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;
            }
            else if (Question[5] == "B")
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = true;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;
            }
            else if (Question[5] == "C")
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                radioButtonC.Checked = true;
                radioButtonD.Checked = false;
            }
            else
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = true;
            }
        }

        private void btnEditTest_Click(object sender, EventArgs e)
        {
            editExistingQuestion = true;
            test.loadQuestionFromDatabase(Convert.ToInt16(TestDatabase.Rows[listBoxTest.SelectedIndex]["testID"].ToString()));
            pageIndex = 0;
            lblQuestionNumber.Text = (1+pageIndex).ToString();
            lblTestCount.Text = (test.getSizeOfTest()).ToString();
            btnPrevious.Enabled = false;
            ChangeQuestionForm();
            btnSaveTest.Text = "Change";
            LoadQuestionFromIndex();
            if (editExistingQuestion == true && pageIndex + 1 == test.getSizeOfTest())
            {
                btnNext.Enabled = false;
            }
        }
        //Check if the Question is in the correct format
        private Boolean checkQuestionCorrectFormat()
        {
            Boolean Question = false;
            Boolean PossibleAnswerA = false;
            Boolean PossibleAnswerB = false;
            Boolean PossibleAnswerC = false;
            Boolean PossibleAnswerD = false;
            if (editExistingQuestion == true && pageIndex + 2 == test.getSizeOfTest())
            {
                btnNext.Enabled = false;
            }

            if (txtboxQuestion.Text != "" && txtboxQuestion.Text != "Enter Question")
            {
                Question = true;
            }
            else
            {
                txtboxQuestion.Text = "Enter Question";
                txtboxQuestion.ForeColor = Color.Red;
            }
            if (txtboxA.Text != "" && txtboxA.Text != "Enter Possible Answer")
            {
                PossibleAnswerA = true;
            }
            else
            {
                txtboxA.Text = "Enter Possible Answer";
                txtboxA.ForeColor = Color.Red;
            }
            if (txtboxB.Text != "" && txtboxB.Text != "Enter Possible Answer")
            {
                PossibleAnswerB = true;
            }
            else
            {
                txtboxB.Text = "Enter Possible Answer";
                txtboxB.ForeColor = Color.Red;
            }
            if (txtboxC.Text != "" && txtboxC.Text != "Enter Possible Answer")
            {
                PossibleAnswerC = true;
            }
            else
            {
                txtboxC.Text = "Enter Possible Answer";
                txtboxC.ForeColor = Color.Red;
            }
            if (txtboxD.Text != "" && txtboxD.Text != "Enter Possible Answer")
            {
                PossibleAnswerD = true;
            }
            else
            {
                txtboxD.Text = "Enter Possible Answer";
                txtboxD.ForeColor = Color.Red;
            }

            if (Question == true && PossibleAnswerA == true && PossibleAnswerB == true && PossibleAnswerC == true && PossibleAnswerD == true)
            {

                test.setQuestion(txtboxQuestion.Text, txtboxA.Text, txtboxB.Text, txtboxC.Text, txtboxD.Text, getCorrectAnswer(), pageIndex);

                pageIndex = pageIndex + 1; //sets the question index to the next Question
                lblTestCount.Text = (test.getSizeOfTest()).ToString();
                lblQuestionNumber.Text = (1 + pageIndex).ToString();
                if (pageIndex > 0)
                {
                    btnPrevious.Enabled = true;
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
        //Save the test to the database
        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            if (pageIndex <= (test.getSizeOfTest()-1) && editExistingQuestion == false)
            {
                test.SaveTestToDatabase(editExistingQuestion, txtboxTestName.Text);
                test.ClearTest();
                btnDeleteTest.Enabled = true;
                btnEditTest.Enabled = true;
                ChangeToTestForm();
                
                
            }
            else if(checkQuestionCorrectFormat() == true)
            {
                test.SaveTestToDatabase(editExistingQuestion, txtboxTestName.Text);
                test.ClearTest();
                btnDeleteTest.Enabled = true;
                btnEditTest.Enabled = true;
                if (listBoxTest.SelectedIndex != -1)
                {
                    btnDeleteTest.Enabled = true;
                    btnEditTest.Enabled = true;
                    populateQuestion(Convert.ToInt16(TestDatabase.Rows[listBoxTest.SelectedIndex]["testID"].ToString())); //gives the TestID to the method
                }
                ChangeToTestForm();
                btnNext.Enabled = true;
            }
            
        }

        private void populateTestForResultForm()
        {
            listBoxResultTest.Items.Clear();
            TestDatabase = sql.fillTestTable();

            for (int i = 0; i < TestDatabase.Rows.Count; i++)
            {
                listBoxResultTest.Items.Add(TestDatabase.Rows[i]["testName"].ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainMenuForm();
        }

        private void listBoxResultTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String Student;
            if (listBoxResultTest.SelectedIndex != -1)
            {
                result.resetScore();
                listBoxShowResult.Items.Clear();
                UserInfo = sql.getAllStudent();
                for (int i = 0; i < UserInfo.Rows.Count; i++)
                {
                    if (result.checkIfTestHasBeenTake(Convert.ToInt16(UserInfo.Rows[i][0].ToString()), Convert.ToInt16(TestDatabase.Rows[listBoxResultTest.SelectedIndex]["testID"].ToString())) == true)
                    {
                        Student = string.Format("{0,-15}{1,-15}{2:0.00}%", UserInfo.Rows[i][1].ToString(), UserInfo.Rows[i][2].ToString(), result.getStudentPoints(Convert.ToInt16(UserInfo.Rows[i][0].ToString()), Convert.ToInt16(TestDatabase.Rows[listBoxResultTest.SelectedIndex]["testID"].ToString())));
                    }
                    else
	                {
                        Student = string.Format("{0,-15}{1,-15} Did not Attempt", UserInfo.Rows[i][1].ToString(), UserInfo.Rows[i][2].ToString());
                    }


                    listBoxShowResult.Items.Add(Student);
                }
                lblHighest.Text =string.Format("Highest: " + "{0:0.00}" + "%", result.getHighestScore(Convert.ToInt16(TestDatabase.Rows[listBoxResultTest.SelectedIndex]["testID"])));
                lblLowest.Text =  string.Format("Lowest: " + "{0:0.00}" + "%", result.getLowestScore(Convert.ToInt16(TestDatabase.Rows[listBoxResultTest.SelectedIndex]["testID"])));
                lblAverage.Text = string.Format("Average: " + "{0:0.00}" + "%", result.getAverageScore(Convert.ToInt16(TestDatabase.Rows[listBoxResultTest.SelectedIndex]["testID"]), UserInfo.Rows.Count));
            }
            
        }
        //Saves all the student marks in a file
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            result.saveMarkToFile();
            MessageBox.Show("Report is Saved!!!");
            MainMenuForm();
            
        }

        
    }
}
