namespace Assignment_1
{
    partial class FormStudent
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
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btntakeTest = new System.Windows.Forms.Button();
            this.listBoxStudentTest = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFinish = new System.Windows.Forms.Button();
            this.labelTestName = new System.Windows.Forms.Label();
            this.lblMaxQuestion = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTestCount = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
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
            this.txtboxQuestion = new System.Windows.Forms.TextBox();
            this.lblQuestionTest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelTestNameReview = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTestCountReview = new System.Windows.Forms.Label();
            this.lblQuestionNumberReview = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnbackReview = new System.Windows.Forms.Button();
            this.btnNextReview = new System.Windows.Forms.Button();
            this.radioButtonDReview = new System.Windows.Forms.RadioButton();
            this.radioButtonCReview = new System.Windows.Forms.RadioButton();
            this.radioButtonBReview = new System.Windows.Forms.RadioButton();
            this.radioButtonAReview = new System.Windows.Forms.RadioButton();
            this.textBoxCReview = new System.Windows.Forms.TextBox();
            this.textBoxBReview = new System.Windows.Forms.TextBox();
            this.textBoxAReview = new System.Windows.Forms.TextBox();
            this.textBoxQuestionReview = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.textBoxDReview = new System.Windows.Forms.TextBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.tabControlStudent.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabPage1);
            this.tabControlStudent.Controls.Add(this.tabPage2);
            this.tabControlStudent.Controls.Add(this.tabPage3);
            this.tabControlStudent.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlStudent.Location = new System.Drawing.Point(-2, 1);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(373, 319);
            this.tabControlStudent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlStudent.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btntakeTest);
            this.tabPage1.Controls.Add(this.listBoxStudentTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select A Test to Take";
            // 
            // btntakeTest
            // 
            this.btntakeTest.BackColor = System.Drawing.Color.Green;
            this.btntakeTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntakeTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btntakeTest.Location = new System.Drawing.Point(21, 222);
            this.btntakeTest.Name = "btntakeTest";
            this.btntakeTest.Size = new System.Drawing.Size(324, 59);
            this.btntakeTest.TabIndex = 2;
            this.btntakeTest.Text = "Test";
            this.btntakeTest.UseVisualStyleBackColor = false;
            this.btntakeTest.Click += new System.EventHandler(this.btntakeTest_Click);
            this.btntakeTest.MouseEnter += new System.EventHandler(this.btntakeTest_MouseEnter);
            this.btntakeTest.MouseLeave += new System.EventHandler(this.btntakeTest_MouseLeave);
            // 
            // listBoxStudentTest
            // 
            this.listBoxStudentTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStudentTest.FormattingEnabled = true;
            this.listBoxStudentTest.ItemHeight = 20;
            this.listBoxStudentTest.Location = new System.Drawing.Point(6, 39);
            this.listBoxStudentTest.Name = "listBoxStudentTest";
            this.listBoxStudentTest.Size = new System.Drawing.Size(349, 164);
            this.listBoxStudentTest.TabIndex = 0;
            this.listBoxStudentTest.SelectedIndexChanged += new System.EventHandler(this.listBoxStudentTest_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFinish);
            this.tabPage2.Controls.Add(this.labelTestName);
            this.tabPage2.Controls.Add(this.lblMaxQuestion);
            this.tabPage2.Controls.Add(this.lblQuestion);
            this.tabPage2.Controls.Add(this.lblTestCount);
            this.tabPage2.Controls.Add(this.lblQuestionNumber);
            this.tabPage2.Controls.Add(this.lblPrevious);
            this.tabPage2.Controls.Add(this.lblNext);
            this.tabPage2.Controls.Add(this.btnPrevious);
            this.tabPage2.Controls.Add(this.btnNext);
            this.tabPage2.Controls.Add(this.radioButtonD);
            this.tabPage2.Controls.Add(this.radioButtonC);
            this.tabPage2.Controls.Add(this.radioButtonB);
            this.tabPage2.Controls.Add(this.radioButtonA);
            this.tabPage2.Controls.Add(this.txtboxD);
            this.tabPage2.Controls.Add(this.txtboxC);
            this.tabPage2.Controls.Add(this.txtboxB);
            this.tabPage2.Controls.Add(this.txtboxA);
            this.tabPage2.Controls.Add(this.txtboxQuestion);
            this.tabPage2.Controls.Add(this.lblQuestionTest);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Green;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(3, 251);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(359, 39);
            this.btnFinish.TabIndex = 43;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            this.btnFinish.MouseEnter += new System.EventHandler(this.btnFinish_MouseEnter);
            this.btnFinish.MouseLeave += new System.EventHandler(this.btnFinish_MouseLeave);
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestName.Location = new System.Drawing.Point(100, 9);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(147, 31);
            this.labelTestName.TabIndex = 42;
            this.labelTestName.Text = "Test Name";
            // 
            // lblMaxQuestion
            // 
            this.lblMaxQuestion.AutoSize = true;
            this.lblMaxQuestion.BackColor = System.Drawing.Color.Green;
            this.lblMaxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMaxQuestion.Location = new System.Drawing.Point(304, 131);
            this.lblMaxQuestion.Name = "lblMaxQuestion";
            this.lblMaxQuestion.Size = new System.Drawing.Size(54, 13);
            this.lblMaxQuestion.TabIndex = 41;
            this.lblMaxQuestion.Text = "Questions";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.Green;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestion.Location = new System.Drawing.Point(7, 131);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 40;
            this.lblQuestion.Text = "Question:";
            // 
            // lblTestCount
            // 
            this.lblTestCount.AutoSize = true;
            this.lblTestCount.BackColor = System.Drawing.Color.Green;
            this.lblTestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTestCount.Location = new System.Drawing.Point(275, 126);
            this.lblTestCount.Name = "lblTestCount";
            this.lblTestCount.Size = new System.Drawing.Size(19, 20);
            this.lblTestCount.TabIndex = 39;
            this.lblTestCount.Text = "6";
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.BackColor = System.Drawing.Color.Green;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestionNumber.Location = new System.Drawing.Point(59, 126);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(19, 20);
            this.lblQuestionNumber.TabIndex = 38;
            this.lblQuestionNumber.Text = "1";
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BackColor = System.Drawing.Color.Green;
            this.lblPrevious.ForeColor = System.Drawing.Color.White;
            this.lblPrevious.Location = new System.Drawing.Point(25, 225);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(48, 13);
            this.lblPrevious.TabIndex = 37;
            this.lblPrevious.Text = "Previous";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Green;
            this.lblNext.ForeColor = System.Drawing.Color.White;
            this.lblNext.Location = new System.Drawing.Point(292, 225);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(29, 13);
            this.lblNext.TabIndex = 36;
            this.lblNext.Text = "Next";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Green;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(3, 122);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 123);
            this.btnPrevious.TabIndex = 35;
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
            this.btnNext.Location = new System.Drawing.Point(271, 122);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(91, 123);
            this.btnNext.TabIndex = 34;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(103, 214);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(33, 17);
            this.radioButtonD.TabIndex = 32;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(103, 188);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 31;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(103, 164);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 30;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(103, 139);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 29;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // txtboxD
            // 
            this.txtboxD.Enabled = false;
            this.txtboxD.Location = new System.Drawing.Point(138, 214);
            this.txtboxD.Multiline = true;
            this.txtboxD.Name = "txtboxD";
            this.txtboxD.Size = new System.Drawing.Size(120, 20);
            this.txtboxD.TabIndex = 28;
            // 
            // txtboxC
            // 
            this.txtboxC.Enabled = false;
            this.txtboxC.Location = new System.Drawing.Point(138, 188);
            this.txtboxC.Multiline = true;
            this.txtboxC.Name = "txtboxC";
            this.txtboxC.Size = new System.Drawing.Size(120, 20);
            this.txtboxC.TabIndex = 27;
            // 
            // txtboxB
            // 
            this.txtboxB.Enabled = false;
            this.txtboxB.Location = new System.Drawing.Point(138, 164);
            this.txtboxB.Multiline = true;
            this.txtboxB.Name = "txtboxB";
            this.txtboxB.Size = new System.Drawing.Size(120, 20);
            this.txtboxB.TabIndex = 26;
            // 
            // txtboxA
            // 
            this.txtboxA.Enabled = false;
            this.txtboxA.Location = new System.Drawing.Point(138, 139);
            this.txtboxA.Multiline = true;
            this.txtboxA.Name = "txtboxA";
            this.txtboxA.Size = new System.Drawing.Size(120, 20);
            this.txtboxA.TabIndex = 25;
            // 
            // txtboxQuestion
            // 
            this.txtboxQuestion.Enabled = false;
            this.txtboxQuestion.Location = new System.Drawing.Point(100, 74);
            this.txtboxQuestion.Multiline = true;
            this.txtboxQuestion.Name = "txtboxQuestion";
            this.txtboxQuestion.Size = new System.Drawing.Size(163, 36);
            this.txtboxQuestion.TabIndex = 23;
            // 
            // lblQuestionTest
            // 
            this.lblQuestionTest.AutoSize = true;
            this.lblQuestionTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionTest.Location = new System.Drawing.Point(100, 40);
            this.lblQuestionTest.Name = "lblQuestionTest";
            this.lblQuestionTest.Size = new System.Drawing.Size(123, 31);
            this.lblQuestionTest.TabIndex = 24;
            this.lblQuestionTest.Text = "Question";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(100, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 128);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Correct Answer";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBack);
            this.tabPage3.Controls.Add(this.labelTestNameReview);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.lblTestCountReview);
            this.tabPage3.Controls.Add(this.lblQuestionNumberReview);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnbackReview);
            this.tabPage3.Controls.Add(this.btnNextReview);
            this.tabPage3.Controls.Add(this.radioButtonDReview);
            this.tabPage3.Controls.Add(this.radioButtonCReview);
            this.tabPage3.Controls.Add(this.radioButtonBReview);
            this.tabPage3.Controls.Add(this.radioButtonAReview);
            this.tabPage3.Controls.Add(this.textBoxCReview);
            this.tabPage3.Controls.Add(this.textBoxBReview);
            this.tabPage3.Controls.Add(this.textBoxAReview);
            this.tabPage3.Controls.Add(this.textBoxQuestionReview);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(365, 310);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(3, 251);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(359, 39);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // labelTestNameReview
            // 
            this.labelTestNameReview.AutoSize = true;
            this.labelTestNameReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestNameReview.Location = new System.Drawing.Point(100, 9);
            this.labelTestNameReview.Name = "labelTestNameReview";
            this.labelTestNameReview.Size = new System.Drawing.Size(147, 31);
            this.labelTestNameReview.TabIndex = 61;
            this.labelTestNameReview.Text = "Test Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(304, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Questions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Question:";
            // 
            // lblTestCountReview
            // 
            this.lblTestCountReview.AutoSize = true;
            this.lblTestCountReview.BackColor = System.Drawing.Color.Green;
            this.lblTestCountReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestCountReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTestCountReview.Location = new System.Drawing.Point(275, 126);
            this.lblTestCountReview.Name = "lblTestCountReview";
            this.lblTestCountReview.Size = new System.Drawing.Size(19, 20);
            this.lblTestCountReview.TabIndex = 58;
            this.lblTestCountReview.Text = "6";
            // 
            // lblQuestionNumberReview
            // 
            this.lblQuestionNumberReview.AutoSize = true;
            this.lblQuestionNumberReview.BackColor = System.Drawing.Color.Green;
            this.lblQuestionNumberReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumberReview.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestionNumberReview.Location = new System.Drawing.Point(59, 126);
            this.lblQuestionNumberReview.Name = "lblQuestionNumberReview";
            this.lblQuestionNumberReview.Size = new System.Drawing.Size(19, 20);
            this.lblQuestionNumberReview.TabIndex = 57;
            this.lblQuestionNumberReview.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Previous";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Green;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(292, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Next";
            // 
            // btnbackReview
            // 
            this.btnbackReview.BackColor = System.Drawing.Color.Green;
            this.btnbackReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbackReview.ForeColor = System.Drawing.Color.White;
            this.btnbackReview.Location = new System.Drawing.Point(3, 122);
            this.btnbackReview.Name = "btnbackReview";
            this.btnbackReview.Size = new System.Drawing.Size(91, 123);
            this.btnbackReview.TabIndex = 54;
            this.btnbackReview.Text = "<";
            this.btnbackReview.UseVisualStyleBackColor = false;
            this.btnbackReview.Click += new System.EventHandler(this.btnbackReview_Click);
            this.btnbackReview.MouseEnter += new System.EventHandler(this.btnbackReview_MouseEnter);
            this.btnbackReview.MouseLeave += new System.EventHandler(this.btnbackReview_MouseLeave);
            // 
            // btnNextReview
            // 
            this.btnNextReview.BackColor = System.Drawing.Color.Green;
            this.btnNextReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextReview.ForeColor = System.Drawing.Color.White;
            this.btnNextReview.Location = new System.Drawing.Point(271, 122);
            this.btnNextReview.Name = "btnNextReview";
            this.btnNextReview.Size = new System.Drawing.Size(91, 123);
            this.btnNextReview.TabIndex = 53;
            this.btnNextReview.Text = ">";
            this.btnNextReview.UseVisualStyleBackColor = false;
            this.btnNextReview.Click += new System.EventHandler(this.btnNextReview_Click);
            this.btnNextReview.MouseEnter += new System.EventHandler(this.btnNextReview_MouseEnter);
            this.btnNextReview.MouseLeave += new System.EventHandler(this.btnNextReview_MouseLeave);
            // 
            // radioButtonDReview
            // 
            this.radioButtonDReview.AutoSize = true;
            this.radioButtonDReview.Enabled = false;
            this.radioButtonDReview.Location = new System.Drawing.Point(97, 214);
            this.radioButtonDReview.Name = "radioButtonDReview";
            this.radioButtonDReview.Size = new System.Drawing.Size(33, 17);
            this.radioButtonDReview.TabIndex = 51;
            this.radioButtonDReview.TabStop = true;
            this.radioButtonDReview.Text = "D";
            this.radioButtonDReview.UseVisualStyleBackColor = true;
            // 
            // radioButtonCReview
            // 
            this.radioButtonCReview.AutoSize = true;
            this.radioButtonCReview.Enabled = false;
            this.radioButtonCReview.Location = new System.Drawing.Point(97, 188);
            this.radioButtonCReview.Name = "radioButtonCReview";
            this.radioButtonCReview.Size = new System.Drawing.Size(32, 17);
            this.radioButtonCReview.TabIndex = 50;
            this.radioButtonCReview.TabStop = true;
            this.radioButtonCReview.Text = "C";
            this.radioButtonCReview.UseVisualStyleBackColor = true;
            // 
            // radioButtonBReview
            // 
            this.radioButtonBReview.AutoSize = true;
            this.radioButtonBReview.Enabled = false;
            this.radioButtonBReview.Location = new System.Drawing.Point(97, 164);
            this.radioButtonBReview.Name = "radioButtonBReview";
            this.radioButtonBReview.Size = new System.Drawing.Size(32, 17);
            this.radioButtonBReview.TabIndex = 49;
            this.radioButtonBReview.TabStop = true;
            this.radioButtonBReview.Text = "B";
            this.radioButtonBReview.UseVisualStyleBackColor = true;
            // 
            // radioButtonAReview
            // 
            this.radioButtonAReview.AutoSize = true;
            this.radioButtonAReview.Enabled = false;
            this.radioButtonAReview.Location = new System.Drawing.Point(97, 139);
            this.radioButtonAReview.Name = "radioButtonAReview";
            this.radioButtonAReview.Size = new System.Drawing.Size(32, 17);
            this.radioButtonAReview.TabIndex = 48;
            this.radioButtonAReview.TabStop = true;
            this.radioButtonAReview.Text = "A";
            this.radioButtonAReview.UseVisualStyleBackColor = true;
            // 
            // textBoxCReview
            // 
            this.textBoxCReview.Enabled = false;
            this.textBoxCReview.Location = new System.Drawing.Point(130, 188);
            this.textBoxCReview.Multiline = true;
            this.textBoxCReview.Name = "textBoxCReview";
            this.textBoxCReview.Size = new System.Drawing.Size(120, 20);
            this.textBoxCReview.TabIndex = 46;
            // 
            // textBoxBReview
            // 
            this.textBoxBReview.Enabled = false;
            this.textBoxBReview.Location = new System.Drawing.Point(130, 164);
            this.textBoxBReview.Multiline = true;
            this.textBoxBReview.Name = "textBoxBReview";
            this.textBoxBReview.Size = new System.Drawing.Size(120, 20);
            this.textBoxBReview.TabIndex = 45;
            // 
            // textBoxAReview
            // 
            this.textBoxAReview.Enabled = false;
            this.textBoxAReview.Location = new System.Drawing.Point(130, 139);
            this.textBoxAReview.Multiline = true;
            this.textBoxAReview.Name = "textBoxAReview";
            this.textBoxAReview.Size = new System.Drawing.Size(120, 20);
            this.textBoxAReview.TabIndex = 44;
            // 
            // textBoxQuestionReview
            // 
            this.textBoxQuestionReview.Enabled = false;
            this.textBoxQuestionReview.Location = new System.Drawing.Point(100, 74);
            this.textBoxQuestionReview.Multiline = true;
            this.textBoxQuestionReview.Name = "textBoxQuestionReview";
            this.textBoxQuestionReview.Size = new System.Drawing.Size(163, 36);
            this.textBoxQuestionReview.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(100, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 31);
            this.label9.TabIndex = 43;
            this.label9.Text = "Question";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxD);
            this.groupBox2.Controls.Add(this.textBoxDReview);
            this.groupBox2.Controls.Add(this.checkBoxC);
            this.groupBox2.Controls.Add(this.checkBoxA);
            this.groupBox2.Controls.Add(this.checkBoxB);
            this.groupBox2.Location = new System.Drawing.Point(95, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 128);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answer                           Attempt";
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Enabled = false;
            this.checkBoxD.Location = new System.Drawing.Point(158, 99);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(15, 14);
            this.checkBoxD.TabIndex = 65;
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // textBoxDReview
            // 
            this.textBoxDReview.Enabled = false;
            this.textBoxDReview.Location = new System.Drawing.Point(35, 96);
            this.textBoxDReview.Multiline = true;
            this.textBoxDReview.Name = "textBoxDReview";
            this.textBoxDReview.Size = new System.Drawing.Size(120, 20);
            this.textBoxDReview.TabIndex = 47;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Enabled = false;
            this.checkBoxC.Location = new System.Drawing.Point(158, 75);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(15, 14);
            this.checkBoxC.TabIndex = 64;
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Enabled = false;
            this.checkBoxA.Location = new System.Drawing.Point(158, 26);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxA.TabIndex = 48;
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Enabled = false;
            this.checkBoxB.Location = new System.Drawing.Point(158, 51);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxB.TabIndex = 63;
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(369, 316);
            this.Controls.Add(this.tabControlStudent);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormStudent";
            this.tabControlStudent.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntakeTest;
        private System.Windows.Forms.ListBox listBoxStudentTest;
        private System.Windows.Forms.Label lblMaxQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTestCount;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.TextBox txtboxD;
        private System.Windows.Forms.TextBox txtboxC;
        private System.Windows.Forms.TextBox txtboxB;
        private System.Windows.Forms.TextBox txtboxA;
        private System.Windows.Forms.TextBox txtboxQuestion;
        private System.Windows.Forms.Label lblQuestionTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTestCountReview;
        private System.Windows.Forms.Label lblQuestionNumberReview;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnbackReview;
        private System.Windows.Forms.Button btnNextReview;
        private System.Windows.Forms.RadioButton radioButtonDReview;
        private System.Windows.Forms.RadioButton radioButtonCReview;
        private System.Windows.Forms.RadioButton radioButtonBReview;
        private System.Windows.Forms.RadioButton radioButtonAReview;
        private System.Windows.Forms.TextBox textBoxCReview;
        private System.Windows.Forms.TextBox textBoxBReview;
        private System.Windows.Forms.TextBox textBoxAReview;
        private System.Windows.Forms.TextBox textBoxQuestionReview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.Label labelTestNameReview;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.TextBox textBoxDReview;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
    }
}