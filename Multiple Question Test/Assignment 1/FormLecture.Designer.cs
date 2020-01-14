namespace Assignment_1
{
    partial class FormLecture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnResults = new System.Windows.Forms.Button();
            this.lblLecture = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.radiobtnStudent = new System.Windows.Forms.RadioButton();
            this.radioBtnLecture = new System.Windows.Forms.RadioButton();
            this.listUser = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.Lecturetab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.lblSelectTest = new System.Windows.Forms.Label();
            this.listBoxTest = new System.Windows.Forms.ListBox();
            this.btnCreateTest = new System.Windows.Forms.Button();
            this.btnEditTest = new System.Windows.Forms.Button();
            this.btnDeleteTest = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblMaxQuestion = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.txtboxD = new System.Windows.Forms.TextBox();
            this.txtboxC = new System.Windows.Forms.TextBox();
            this.txtboxB = new System.Windows.Forms.TextBox();
            this.txtboxA = new System.Windows.Forms.TextBox();
            this.txtboxTestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblLowest = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblHighest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listBoxShowResult = new System.Windows.Forms.ListBox();
            this.listBoxResultTest = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxDelete.SuspendLayout();
            this.Lecturetab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Green;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(21, 35);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(324, 59);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit Users";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseEnter += new System.EventHandler(this.btnEdit_MouseEnter);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Green;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(21, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(324, 59);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Change Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseEnter += new System.EventHandler(this.btnTest_MouseEnter);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Green;
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.White;
            this.btnResults.Location = new System.Drawing.Point(21, 186);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(324, 59);
            this.btnResults.TabIndex = 2;
            this.btnResults.Text = "Results";
            this.btnResults.UseVisualStyleBackColor = false;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            this.btnResults.MouseEnter += new System.EventHandler(this.btnResults_MouseEnter);
            this.btnResults.MouseLeave += new System.EventHandler(this.btnResults_MouseLeave);
            // 
            // lblLecture
            // 
            this.lblLecture.AutoSize = true;
            this.lblLecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.lblLecture.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLecture.Location = new System.Drawing.Point(1, -7);
            this.lblLecture.Name = "lblLecture";
            this.lblLecture.Size = new System.Drawing.Size(135, 35);
            this.lblLecture.TabIndex = 3;
            this.lblLecture.Text = "Lecture: ";
            // 
            // txtboxID
            // 
            this.txtboxID.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtboxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxID.Location = new System.Drawing.Point(16, 38);
            this.txtboxID.Multiline = true;
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(138, 30);
            this.txtboxID.TabIndex = 4;
            this.txtboxID.Click += new System.EventHandler(this.txtboxID_Click);
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxName.Location = new System.Drawing.Point(16, 79);
            this.txtboxName.Multiline = true;
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(138, 30);
            this.txtboxName.TabIndex = 5;
            this.txtboxName.Click += new System.EventHandler(this.txtboxName_Click);
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSurname.Location = new System.Drawing.Point(16, 120);
            this.txtboxSurname.Multiline = true;
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(138, 30);
            this.txtboxSurname.TabIndex = 6;
            this.txtboxSurname.Click += new System.EventHandler(this.txtboxSurname_Click);
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPassword.Location = new System.Drawing.Point(16, 161);
            this.txtboxPassword.Multiline = true;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(138, 30);
            this.txtboxPassword.TabIndex = 7;
            this.txtboxPassword.Click += new System.EventHandler(this.txtboxPassword_Click);
            // 
            // radiobtnStudent
            // 
            this.radiobtnStudent.AutoSize = true;
            this.radiobtnStudent.Location = new System.Drawing.Point(18, 212);
            this.radiobtnStudent.Name = "radiobtnStudent";
            this.radiobtnStudent.Size = new System.Drawing.Size(62, 17);
            this.radiobtnStudent.TabIndex = 8;
            this.radiobtnStudent.TabStop = true;
            this.radiobtnStudent.Text = "Student";
            this.radiobtnStudent.UseVisualStyleBackColor = true;
            // 
            // radioBtnLecture
            // 
            this.radioBtnLecture.AutoSize = true;
            this.radioBtnLecture.Location = new System.Drawing.Point(106, 212);
            this.radioBtnLecture.Name = "radioBtnLecture";
            this.radioBtnLecture.Size = new System.Drawing.Size(61, 17);
            this.radioBtnLecture.TabIndex = 9;
            this.radioBtnLecture.TabStop = true;
            this.radioBtnLecture.Text = "Lecture";
            this.radioBtnLecture.UseVisualStyleBackColor = true;
            // 
            // listUser
            // 
            this.listUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUser.FormattingEnabled = true;
            this.listUser.ItemHeight = 18;
            this.listUser.Location = new System.Drawing.Point(181, 38);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(163, 148);
            this.listUser.TabIndex = 10;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Green;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(6, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(5, 21);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(164, 217);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Create Student";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(5, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 35);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Green;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.Location = new System.Drawing.Point(91, 244);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 35);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseEnter += new System.EventHandler(this.btnCreate_MouseEnter);
            this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.btnDelete);
            this.groupBoxDelete.Location = new System.Drawing.Point(175, 21);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(175, 217);
            this.groupBoxDelete.TabIndex = 15;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete Student";
            // 
            // Lecturetab
            // 
            this.Lecturetab.Controls.Add(this.tabPage2);
            this.Lecturetab.Controls.Add(this.tabPage3);
            this.Lecturetab.Controls.Add(this.tabPage4);
            this.Lecturetab.Controls.Add(this.tabPage5);
            this.Lecturetab.Controls.Add(this.tabPage1);
            this.Lecturetab.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lecturetab.ItemSize = new System.Drawing.Size(0, 1);
            this.Lecturetab.Location = new System.Drawing.Point(0, 1);
            this.Lecturetab.Name = "Lecturetab";
            this.Lecturetab.SelectedIndex = 0;
            this.Lecturetab.Size = new System.Drawing.Size(378, 293);
            this.Lecturetab.TabIndex = 16;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.btnClose);
            this.tabPage2.Controls.Add(this.txtboxID);
            this.tabPage2.Controls.Add(this.listUser);
            this.tabPage2.Controls.Add(this.txtboxName);
            this.tabPage2.Controls.Add(this.radioBtnLecture);
            this.tabPage2.Controls.Add(this.txtboxSurname);
            this.tabPage2.Controls.Add(this.radiobtnStudent);
            this.tabPage2.Controls.Add(this.txtboxPassword);
            this.tabPage2.Controls.Add(this.groupBox);
            this.tabPage2.Controls.Add(this.groupBoxDelete);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(370, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EditUserForm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBack2);
            this.tabPage3.Controls.Add(this.lblQuestions);
            this.tabPage3.Controls.Add(this.listBoxQuestion);
            this.tabPage3.Controls.Add(this.lblSelectTest);
            this.tabPage3.Controls.Add(this.listBoxTest);
            this.tabPage3.Controls.Add(this.btnCreateTest);
            this.tabPage3.Controls.Add(this.btnEditTest);
            this.tabPage3.Controls.Add(this.btnDeleteTest);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(370, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ViewTestForm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBack2
            // 
            this.btnBack2.BackColor = System.Drawing.Color.Green;
            this.btnBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack2.Location = new System.Drawing.Point(10, 216);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(160, 59);
            this.btnBack2.TabIndex = 14;
            this.btnBack2.Text = "Cancel";
            this.btnBack2.UseVisualStyleBackColor = false;
            this.btnBack2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(184, 16);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(110, 26);
            this.lblQuestions.TabIndex = 6;
            this.lblQuestions.Text = "Questions";
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.ItemHeight = 16;
            this.listBoxQuestion.Location = new System.Drawing.Point(189, 44);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.Size = new System.Drawing.Size(160, 148);
            this.listBoxQuestion.TabIndex = 5;
            // 
            // lblSelectTest
            // 
            this.lblSelectTest.AutoSize = true;
            this.lblSelectTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTest.Location = new System.Drawing.Point(5, 16);
            this.lblSelectTest.Name = "lblSelectTest";
            this.lblSelectTest.Size = new System.Drawing.Size(120, 26);
            this.lblSelectTest.TabIndex = 4;
            this.lblSelectTest.Text = "Select Test";
            // 
            // listBoxTest
            // 
            this.listBoxTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTest.FormattingEnabled = true;
            this.listBoxTest.ItemHeight = 24;
            this.listBoxTest.Location = new System.Drawing.Point(9, 44);
            this.listBoxTest.Name = "listBoxTest";
            this.listBoxTest.Size = new System.Drawing.Size(160, 76);
            this.listBoxTest.TabIndex = 3;
            this.listBoxTest.SelectedIndexChanged += new System.EventHandler(this.listBoxTest_SelectedIndexChanged);
            // 
            // btnCreateTest
            // 
            this.btnCreateTest.BackColor = System.Drawing.Color.Green;
            this.btnCreateTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTest.ForeColor = System.Drawing.Color.White;
            this.btnCreateTest.Location = new System.Drawing.Point(189, 216);
            this.btnCreateTest.Name = "btnCreateTest";
            this.btnCreateTest.Size = new System.Drawing.Size(160, 59);
            this.btnCreateTest.TabIndex = 2;
            this.btnCreateTest.Text = "Create New";
            this.btnCreateTest.UseVisualStyleBackColor = false;
            this.btnCreateTest.Click += new System.EventHandler(this.btnCreateTest_Click);
            this.btnCreateTest.MouseEnter += new System.EventHandler(this.btnCreateTest_MouseEnter);
            this.btnCreateTest.MouseLeave += new System.EventHandler(this.btnCreateTest_MouseLeave);
            // 
            // btnEditTest
            // 
            this.btnEditTest.BackColor = System.Drawing.Color.Green;
            this.btnEditTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTest.ForeColor = System.Drawing.Color.White;
            this.btnEditTest.Location = new System.Drawing.Point(9, 135);
            this.btnEditTest.Name = "btnEditTest";
            this.btnEditTest.Size = new System.Drawing.Size(160, 33);
            this.btnEditTest.TabIndex = 1;
            this.btnEditTest.Text = "Change";
            this.btnEditTest.UseVisualStyleBackColor = false;
            this.btnEditTest.Click += new System.EventHandler(this.btnEditTest_Click);
            this.btnEditTest.MouseEnter += new System.EventHandler(this.btnEditTest_MouseEnter);
            this.btnEditTest.MouseLeave += new System.EventHandler(this.btnEditTest_MouseLeave);
            // 
            // btnDeleteTest
            // 
            this.btnDeleteTest.BackColor = System.Drawing.Color.Green;
            this.btnDeleteTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTest.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTest.Location = new System.Drawing.Point(9, 174);
            this.btnDeleteTest.Name = "btnDeleteTest";
            this.btnDeleteTest.Size = new System.Drawing.Size(160, 33);
            this.btnDeleteTest.TabIndex = 0;
            this.btnDeleteTest.Text = "Delete";
            this.btnDeleteTest.UseVisualStyleBackColor = false;
            this.btnDeleteTest.Click += new System.EventHandler(this.btnDeleteTest_Click);
            this.btnDeleteTest.MouseEnter += new System.EventHandler(this.btnDeleteTest_MouseEnter);
            this.btnDeleteTest.MouseLeave += new System.EventHandler(this.btnDeleteTest_MouseLeave);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblMaxQuestion);
            this.tabPage4.Controls.Add(this.lblQuestion);
            this.tabPage4.Controls.Add(this.lblTestCount);
            this.tabPage4.Controls.Add(this.lblQuestionNumber);
            this.tabPage4.Controls.Add(this.lblPrevious);
            this.tabPage4.Controls.Add(this.lblNext);
            this.tabPage4.Controls.Add(this.btnSaveTest);
            this.tabPage4.Controls.Add(this.btnCancel);
            this.tabPage4.Controls.Add(this.btnPrevious);
            this.tabPage4.Controls.Add(this.btnNext);
            this.tabPage4.Controls.Add(this.radioButtonD);
            this.tabPage4.Controls.Add(this.radioButtonC);
            this.tabPage4.Controls.Add(this.radioButtonB);
            this.tabPage4.Controls.Add(this.radioButtonA);
            this.tabPage4.Controls.Add(this.txtboxD);
            this.tabPage4.Controls.Add(this.txtboxC);
            this.tabPage4.Controls.Add(this.txtboxB);
            this.tabPage4.Controls.Add(this.txtboxA);
            this.tabPage4.Controls.Add(this.txtboxTestName);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.txtboxQuestion);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(370, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CreateTestForm";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblMaxQuestion
            // 
            this.lblMaxQuestion.AutoSize = true;
            this.lblMaxQuestion.BackColor = System.Drawing.Color.Green;
            this.lblMaxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaxQuestion.Location = new System.Drawing.Point(301, 130);
            this.lblMaxQuestion.Name = "lblMaxQuestion";
            this.lblMaxQuestion.Size = new System.Drawing.Size(54, 13);
            this.lblMaxQuestion.TabIndex = 22;
            this.lblMaxQuestion.Text = "Questions";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Green;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestion.Location = new System.Drawing.Point(4, 130);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 21;
            this.lblQuestion.Text = "Question:";
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.BackColor = System.Drawing.Color.Green;
            this.lblTestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTestCount.Location = new System.Drawing.Point(272, 125);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(19, 20);
            this.lblTestCount.TabIndex = 20;
            this.lblTestCount.Text = "6";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Green;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestionNumber.Location = new System.Drawing.Point(56, 125);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(19, 20);
            this.lblQuestionNumber.TabIndex = 19;
            this.lblQuestionNumber.Text = "1";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BackColor = System.Drawing.Color.Green;
            this.lblPrevious.ForeColor = System.Drawing.Color.White;
            this.lblPrevious.Location = new System.Drawing.Point(22, 224);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(48, 13);
            this.lblPrevious.TabIndex = 18;
            this.lblPrevious.Text = "Previous";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Green;
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(289, 224);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(29, 13);
            this.lblNext.TabIndex = 17;
            this.lblNext.Text = "Next";
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.BackColor = System.Drawing.Color.Green;
            this.btnSaveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTest.ForeColor = System.Drawing.Color.White;
            this.btnSaveTest.Location = new System.Drawing.Point(268, 247);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(88, 30);
            this.btnSaveTest.TabIndex = 16;
            this.btnSaveTest.Text = "Create";
            this.btnSaveTest.UseVisualStyleBackColor = false;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            this.btnSaveTest.MouseEnter += new System.EventHandler(this.btnSaveTest_MouseEnter);
            this.btnSaveTest.MouseLeave += new System.EventHandler(this.btnSaveTest_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(0, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Green;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(0, 121);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 123);
            this.btnPrevious.TabIndex = 14;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(268, 121);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 123);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(100, 213);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(33, 17);
            this.radioButtonD.TabIndex = 11;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(100, 187);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 10;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(100, 163);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 9;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(100, 138);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 8;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // txtboxD
            // 
            this.txtboxD.Location = new System.Drawing.Point(135, 213);
            this.txtboxD.Multiline = true;
            this.txtboxD.Name = "txtboxD";
            this.txtboxD.Size = new System.Drawing.Size(120, 20);
            this.txtboxD.TabIndex = 7;
            this.txtboxD.Click += new System.EventHandler(this.txtboxD_Click);
            // 
            // txtboxC
            // 
            this.txtboxC.Location = new System.Drawing.Point(135, 187);
            this.txtboxC.Multiline = true;
            this.txtboxC.Name = "txtboxC";
            this.txtboxC.Size = new System.Drawing.Size(120, 20);
            this.txtboxC.TabIndex = 6;
            this.txtboxC.Click += new System.EventHandler(this.txtboxC_Click);
            // 
            // txtboxB
            // 
            this.txtboxB.Location = new System.Drawing.Point(135, 163);
            this.txtboxB.Multiline = true;
            this.txtboxB.Name = "txtboxB";
            this.txtboxB.Size = new System.Drawing.Size(120, 20);
            this.txtboxB.TabIndex = 5;
            this.txtboxB.Click += new System.EventHandler(this.txtboxB_Click);
            // 
            // txtboxA
            // 
            this.txtboxA.Location = new System.Drawing.Point(135, 138);
            this.txtboxA.Multiline = true;
            this.txtboxA.Name = "txtboxA";
            this.txtboxA.Size = new System.Drawing.Size(120, 20);
            this.txtboxA.TabIndex = 4;
            this.txtboxA.Click += new System.EventHandler(this.txtboxA_Click);
            // 
            // txtboxTestName
            // 
            this.txtboxTestName.Location = new System.Drawing.Point(103, 37);
            this.txtboxTestName.Name = "txtboxTestName";
            this.txtboxTestName.Size = new System.Drawing.Size(141, 20);
            this.txtboxTestName.TabIndex = 2;
            this.txtboxTestName.Click += new System.EventHandler(this.txtboxTestName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test Name";
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.Location = new System.Drawing.Point(103, 89);
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(141, 20);
            this.txtboxQuestion.TabIndex = 0;
            this.txtboxQuestion.Click += new System.EventHandler(this.txtboxQuestion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Question";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(97, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 128);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Correct Answer";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lblLowest);
            this.tabPage5.Controls.Add(this.lblAverage);
            this.tabPage5.Controls.Add(this.lblHighest);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.btnSaveToFile);
            this.tabPage5.Controls.Add(this.btnBack);
            this.tabPage5.Controls.Add(this.listBoxShowResult);
            this.tabPage5.Controls.Add(this.listBoxResultTest);
            this.tabPage5.Location = new System.Drawing.Point(4, 5);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(370, 284);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ViewReport";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Location = new System.Drawing.Point(263, 87);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(41, 13);
            this.lblLowest.TabIndex = 8;
            this.lblLowest.Text = "Lowest";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(133, 87);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 7;
            this.lblAverage.Text = "Average:";
            // 
            // lblHighest
            // 
            this.lblHighest.AutoSize = true;
            this.lblHighest.Location = new System.Drawing.Point(19, 87);
            this.lblHighest.Name = "lblHighest";
            this.lblHighest.Size = new System.Drawing.Size(46, 13);
            this.lblHighest.TabIndex = 6;
            this.lblHighest.Text = "Highest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "SELECT A TEST";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.BackColor = System.Drawing.Color.Green;
            this.btnSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.btnSaveToFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveToFile.Location = new System.Drawing.Point(181, 218);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(160, 59);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save To File";
            this.btnSaveToFile.UseVisualStyleBackColor = false;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(19, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 59);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxShowResult
            // 
            this.listBoxShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxShowResult.FormattingEnabled = true;
            this.listBoxShowResult.ItemHeight = 16;
            this.listBoxShowResult.Location = new System.Drawing.Point(19, 103);
            this.listBoxShowResult.Name = "listBoxShowResult";
            this.listBoxShowResult.Size = new System.Drawing.Size(322, 100);
            this.listBoxShowResult.TabIndex = 1;
            // 
            // listBoxResultTest
            // 
            this.listBoxResultTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxResultTest.FormattingEnabled = true;
            this.listBoxResultTest.ItemHeight = 24;
            this.listBoxResultTest.Location = new System.Drawing.Point(19, 28);
            this.listBoxResultTest.Name = "listBoxResultTest";
            this.listBoxResultTest.Size = new System.Drawing.Size(322, 52);
            this.listBoxResultTest.TabIndex = 0;
            this.listBoxResultTest.SelectedIndexChanged += new System.EventHandler(this.listBoxResultTest_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.btnResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(370, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "mainMenuForm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormLecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(369, 316);
            this.Controls.Add(this.lblLecture);
            this.Controls.Add(this.Lecturetab);
            this.Name = "FormLecture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecture";
            this.groupBoxDelete.ResumeLayout(false);
            this.Lecturetab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label lblLecture;
        private System.Windows.Forms.TextBox txtboxID;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.RadioButton radiobtnStudent;
        private System.Windows.Forms.RadioButton radioBtnLecture;
        private System.Windows.Forms.ListBox listUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.TabControl Lecturetab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnDeleteTest;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Label lblSelectTest;
        private System.Windows.Forms.ListBox listBoxTest;
        private System.Windows.Forms.Button btnCreateTest;
        private System.Windows.Forms.Button btnEditTest;
        protected System.Windows.Forms.ListBox listBoxQuestion;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxTestName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxQuestion;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.TextBox txtboxD;
        private System.Windows.Forms.TextBox txtboxC;
        private System.Windows.Forms.TextBox txtboxB;
        private System.Windows.Forms.TextBox txtboxA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblTestCount;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblMaxQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblLowest;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblHighest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox listBoxShowResult;
        private System.Windows.Forms.ListBox listBoxResultTest;
    }
}