using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectToSQL;

namespace Assignment_1
{
    public partial class FormStudent : Form
    {
        Test test = new Test();
        SqlManager sql = new SqlManager();
        Result result = new Result();
        DataTable TestDatabase;
        DataTable QuestionTable;
        int userID;
        int pageIndex = 0;

     
        public FormStudent(int userID)
        {
            this.userID = userID;
            InitializeComponent();
            populateTestForResultForm();

        }


        //Display the avalible tests thats in the database
        private void populateTestForResultForm()
        {
            string test;
            listBoxStudentTest.Items.Clear();
            TestDatabase = sql.fillTestTable();

            for (int i = 0; i < TestDatabase.Rows.Count; i++)
            {
                if (result.checkIfTestHasBeenTake(userID, Convert.ToInt16(TestDatabase.Rows[i]["testID"].ToString())) == true)
                {
                    test = string.Format("{0,-20}{1:0.00}%", TestDatabase.Rows[i]["testName"].ToString(), result.getStudentPoints(userID, Convert.ToInt16(TestDatabase.Rows[i]["testID"].ToString())));
                }
                else
                {
                    test = string.Format("{0,-20} Did not Attempt", TestDatabase.Rows[i]["testName"].ToString());
                }


                listBoxStudentTest.Items.Add(test);
            }
        }
        //change button colour
        private void btntakeTest_MouseEnter(object sender, EventArgs e)
        {
            btntakeTest.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btntakeTest_MouseLeave(object sender, EventArgs e)
        {
            btntakeTest.BackColor = Color.Green;
        }
        //checks if the student needs to take the test or load result form
        private void btntakeTest_Click(object sender, EventArgs e)
        {
            if (listBoxStudentTest.SelectedIndex != -1)
            {
                btnNext.Enabled = true;

                
                    if (result.checkIfTestHasBeenTake(userID, Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString())) == true)
                    {
                        LoadReview();
                    }
                    else
                    {
                        LoadTest();

                    }
                
            }
        }
        //loads the test form
        private void LoadTest()
        {
            QuestionTable = sql.fillQuestionTable(Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString()));
            labelTestName.Text = TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testName"].ToString();
            tabControlStudent.SelectedTab = tabPage2;
            test.loadQuestionFromDatabase(Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString()));
            lblTestCount.Text = Convert.ToString(test.getSizeOfTest());
            test.setSizeOfUserAnswer();
            pageIndex = 0;
            btnFinish.Enabled = false;
            if (pageIndex == Convert.ToInt16(lblTestCount.Text)-1)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
            btnPrevious.Enabled = false;
            loadQuestionByIndex(pageIndex);
            
        }
        //loads the review form
        private void LoadReview()
        {
            QuestionTable = sql.fillQuestionTable(Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString()));
            labelTestNameReview.Text = TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testName"].ToString();
            
            tabControlStudent.SelectedTab = tabPage3;
            test.loadQuestionFromDatabase(Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString()));
            lblTestCountReview.Text = Convert.ToString(test.getSizeOfTest());
            btnbackReview.Enabled = false;
            lblQuestionNumberReview.Text = Convert.ToString(pageIndex + 1);
            fillReviewTable();
        }
        //loads the question by questionID
        private void loadQuestionByIndex(int index)
        {
            lblQuestionNumber.Text = Convert.ToString(pageIndex+1);
            String[] QuestionInTest = test.loadQuestionByIndex(index);

            txtboxQuestion.Text = QuestionInTest[0];
            txtboxA.Text = QuestionInTest[1];
            txtboxB.Text = QuestionInTest[2];
            txtboxC.Text = QuestionInTest[3];
            txtboxD.Text = QuestionInTest[4];
            
        }
        //loads the users answer
        private void loadUserAnswerByIndex(int index)
        {
            char answer = test.getUserAnswer(index);
            if (answer == 'A')
            {
                radioButtonA.Checked = true;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;
            }
            else if (answer == 'B')
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = true;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;
            }
            else if (answer == 'C')
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                radioButtonC.Checked = true;
                radioButtonD.Checked = false;
            }
            else if(answer == 'D')
            {
                radioButtonA.Checked = false;
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = true;
            }
            else
            {
                radioButtonA.Checked = true;              
                radioButtonB.Checked = false;
                radioButtonC.Checked = false;
                radioButtonD.Checked = false;
            }
            

        }
        
        private void listBoxStudentTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStudentTest.SelectedIndex != -1)
            {


                if (result.checkIfTestHasBeenTake(userID, Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString())) == true)
                {
                    btntakeTest.Text = "Review";
                }
                else
                {
                    btntakeTest.Text = "Test";
                }
            }
        }
        //loads next question
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageIndex == Convert.ToInt16(lblTestCount.Text)-2)
            {
                btnNext.Enabled = false;
                btnFinish.Enabled = true;
            }
            btnPrevious.Enabled = true;
            test.SetUserAnswer(getUserAnswer(), pageIndex);
            pageIndex = pageIndex + 1;
            loadQuestionByIndex(pageIndex);
            loadUserAnswerByIndex(pageIndex);
            
        }
        //loads previous question
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            test.SetUserAnswer(getUserAnswer(), pageIndex);
            pageIndex = pageIndex - 1;
            loadQuestionByIndex(pageIndex);
            loadUserAnswerByIndex(pageIndex);
            if (pageIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
        }
        //fill in the users answer
        private Char getUserAnswer()
        {
            if (radioButtonA.Checked == true)
            {
                return 'A';
            }
            else if (radioButtonB.Checked == true)
            {
                return 'B';
            }
            else if (radioButtonC.Checked == true)
            {
                return 'C';
            }
            else
            {
                return 'D';
            }
        }
        //save the users answers to the database
        private void btnFinish_Click(object sender, EventArgs e)
        {
            test.SetUserAnswer(getUserAnswer(), pageIndex);
            test.saveUserAnswerWithTest(userID, Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString()));
            String mark = string.Format("SCORE: {0:0.00}%", result.getStudentPoints(userID, Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString())));
            MessageBox.Show(mark);
            pageIndex = 0;
            tabControlStudent.SelectedTab = tabPage1;
            populateTestForResultForm();
            
        }
        //fills the question and user answer as welll as the actual answer
        private void fillReviewTable()
        {
            lblQuestionNumberReview.Text = Convert.ToString(pageIndex + 1);
            //Fills in the User Answer
            char userAnswer = test.getUserAnswer(userID, Convert.ToInt16(TestDatabase.Rows[listBoxStudentTest.SelectedIndex]["testID"].ToString()), pageIndex);
            if (userAnswer == 'A')
            {
                checkBoxA.Checked = true;
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;
            }
            else if (userAnswer == 'B')
            {
                checkBoxA.Checked = false;
                checkBoxB.Checked = true;
                checkBoxC.Checked = false;
                checkBoxD.Checked = false;

            }
            else if (userAnswer == 'C')
            {
                checkBoxA.Checked = false;
                checkBoxB.Checked = false;
                checkBoxC.Checked = true;
                checkBoxD.Checked = false;

            }
            else
            {
                checkBoxA.Checked = false;
                checkBoxB.Checked = false;
                checkBoxC.Checked = false;
                checkBoxD.Checked = true;
            }
            //Fills in the Actual answer
            String[] ActualAnswer = test.loadQuestionByIndex(pageIndex);
            textBoxQuestionReview.Text = ActualAnswer[0];
            textBoxAReview.Text = ActualAnswer[1];
            textBoxBReview.Text = ActualAnswer[2];
            textBoxCReview.Text = ActualAnswer[3];
            textBoxDReview.Text = ActualAnswer[4];
            
                if (ActualAnswer[5] == "A")
                {
                    radioButtonAReview.Checked = true;
                    radioButtonBReview.Checked = false;
                    radioButtonCReview.Checked = false;
                    radioButtonDReview.Checked = false;
                }
                else if (ActualAnswer[5] == "B")
                {
                radioButtonAReview.Checked = false;
                radioButtonBReview.Checked = true;
                radioButtonCReview.Checked = false;
                radioButtonDReview.Checked = false;
                }
                else if (ActualAnswer[5] == "C")
                {
                radioButtonAReview.Checked = false;
                radioButtonBReview.Checked = false;
                radioButtonCReview.Checked = true;
                radioButtonDReview.Checked = false;
                }
                else if (ActualAnswer[5] == "D")
                {
                radioButtonAReview.Checked = false;
                radioButtonBReview.Checked = false;
                radioButtonCReview.Checked = false;
                radioButtonDReview.Checked = true;
                }
            }

        private void btnNextReview_Click(object sender, EventArgs e)
        {
            if (pageIndex == Convert.ToInt16(lblTestCountReview.Text) - 2)
            {
                btnNextReview.Enabled = false;
            }
                pageIndex = pageIndex + 1;
            btnbackReview.Enabled = true;
            fillReviewTable();
        }

        private void btnbackReview_Click(object sender, EventArgs e)
        {
            btnNextReview.Enabled = true;
            pageIndex = pageIndex - 1;
            fillReviewTable();
            
            if (pageIndex == 0)
            {
                btnbackReview.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControlStudent.SelectedTab = tabPage1;
        }
        //change button colour
        private void btnbackReview_MouseEnter(object sender, EventArgs e)
        {
            btnbackReview.BackColor = Color.DarkGreen;
            label4.BackColor = Color.DarkGreen;
            lblQuestionNumberReview.BackColor = Color.DarkGreen;
            label7.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btnbackReview_MouseLeave(object sender, EventArgs e)
        {
            btnbackReview.BackColor = Color.Green;
            label4.BackColor = Color.Green;
            lblQuestionNumberReview.BackColor = Color.Green;
            label7.BackColor = Color.Green;
        }
        //change button colour
        private void btnNextReview_MouseEnter(object sender, EventArgs e)
        {
            btnNextReview.BackColor = Color.DarkGreen;
            lblTestCountReview.BackColor = Color.DarkGreen;
            label3.BackColor = Color.DarkGreen;
            label8.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btnNextReview_MouseLeave(object sender, EventArgs e)
        {
            btnNextReview.BackColor = Color.Green;
            lblTestCountReview.BackColor = Color.Green;
            label3.BackColor = Color.Green;
            label8.BackColor = Color.Green;
        }
        //change button colour
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackColor = Color.Green;
        }
        //change button colour
        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.DarkGreen;
            lblTestCount.BackColor = Color.DarkGreen;
            lblMaxQuestion.BackColor = Color.DarkGreen;
            lblNext.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackColor = Color.Green;
            lblTestCount.BackColor = Color.Green;
            lblMaxQuestion.BackColor = Color.Green;
            lblNext.BackColor = Color.Green;
        }
        //change button colour
        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            btnPrevious.BackColor = Color.DarkGreen;
            lblQuestion.BackColor = Color.DarkGreen;
            lblQuestionNumber.BackColor = Color.DarkGreen;
            lblPrevious.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            btnPrevious.BackColor = Color.Green;
            lblQuestion.BackColor = Color.Green;
            lblQuestionNumber.BackColor = Color.Green;
            lblPrevious.BackColor = Color.Green;
        }
        //change button colour
        private void btnFinish_MouseEnter(object sender, EventArgs e)
        {
            btnFinish.BackColor = Color.DarkGreen;
        }
        //change button colour
        private void btnFinish_MouseLeave(object sender, EventArgs e)
        {
            btnFinish.BackColor = Color.Green;
        }
    }
}
