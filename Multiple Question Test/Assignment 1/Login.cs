using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ConnectToSQL;

namespace Assignment_1
{
    class Login
    {
        string userID;
        Boolean islectureword;
        Boolean userExist;
        SqlManager sql = new SqlManager();
        
        //attempts to see if the user exists and loads them in before the user clicks log in, makes the program feel more responsive
        public void attemptLogin(string ID_Number, string password)
        {
         String[] user = sql.attemptLogin(ID_Number, password);

            this.userID = user[0];
            this.islectureword = Convert.ToBoolean(user[1]);
            this.userExist = Convert.ToBoolean(user[2]);
        }

        public int getUser_ID()
        {
            return Convert.ToInt32(userID);
        }
        

        public String getLogIn()
        {
            if (this.userExist == true)
            {
                if (this.islectureword == true)
                {
                    return "true";
                }
                else //if (this.islectureword == false)
                {
                    return "false";
                }
            } else {
                return "null";
            }
        

        }

    }
}
