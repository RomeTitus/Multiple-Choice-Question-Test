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

namespace Assignment_1
{
    public partial class FormLogin : Form
    {
        //Login log = new Login();//creates an object from that class
        Login log = new Login();
        
        string isLecture;
        Thread thread1;

      

        public FormLogin()
        {
            InitializeComponent();
            txtboxUsername.ForeColor = Color.Gray;
            txtboxpassword.ForeColor = Color.Gray;
            txtboxUsername.Text = "Enter ID";
            txtboxpassword.Text = "*********";

          

        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            thread1.Join();
            if (checkUserInputFormat(txtboxUsername.Text, txtboxpassword.Text) == true)
            {
                isLecture = log.getLogIn();
                if (isLecture == "true")
                {
                    FormLecture formLecture = new FormLecture(log.getUser_ID());
                    formLecture.Show();


                }
                else if(isLecture == "false")
                {
                    FormStudent formStudent = new FormStudent(log.getUser_ID());
                    formStudent.Show();
                }
                else
                {
                    txtboxUsername.ForeColor = Color.Red;
                    txtboxUsername.Text = "User/password: Wrong";
                }
            }
            else
            {
                txtboxUsername.ForeColor = Color.Red;
                txtboxUsername.Text = "Only numerals are allowed";
            }
                    

            
        }
      
        //clears text in the text box
        private void txtboxpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtboxpassword.Text == "*********")
            {
                txtboxpassword.Text = "";
                txtboxpassword.ForeColor = Color.Black;
            }
            
        }

        private void txtboxUsername_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtboxUsername.Text == "Enter ID" || txtboxUsername.Text == "User/password: Wrong" || txtboxUsername.Text == "Only numerals are allowed")
            {
                txtboxUsername.Text = "";
                txtboxUsername.ForeColor = Color.Black;
            }
            
        }

        //runs a thread that has paramiters in it, to make the program feel more responsive
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.DarkGreen;
            thread1 = new Thread(() => {
                log.attemptLogin(txtboxUsername.Text, txtboxpassword.Text);
            });
            thread1.Start();
            
        }

        private void btnLogin_MouseLeave_1(object sender, EventArgs e)
        {
            this.btnLogin.BackColor = Color.Green;
        }


        //Checks if the user has inputed the right value types
        private Boolean checkUserInputFormat(string ID_Number, string password)
        {
            try
            {
                Convert.ToInt32(ID_Number);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
