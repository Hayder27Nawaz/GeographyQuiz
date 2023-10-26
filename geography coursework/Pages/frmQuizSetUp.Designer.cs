namespace geography_coursework
{
    partial class frmQuizSetUp
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
            components = new System.ComponentModel.Container();
            lblTimePerQuestion = new System.Windows.Forms.Label();
            lblNumberOfQuestions = new System.Windows.Forms.Label();
            btn15questions = new System.Windows.Forms.Button();
            btn30questions = new System.Windows.Forms.Button();
            btn45questions = new System.Windows.Forms.Button();
            btnStartQuiz = new System.Windows.Forms.Button();
            countdownTimer = new System.Windows.Forms.Timer(components);
            lblScreen = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblTimePerQuestion
            // 
            lblTimePerQuestion.AutoSize = true;
            lblTimePerQuestion.Location = new System.Drawing.Point(35, 35);
            lblTimePerQuestion.Name = "lblTimePerQuestion";
            lblTimePerQuestion.Size = new System.Drawing.Size(363, 25);
            lblTimePerQuestion.TabIndex = 0;
            lblTimePerQuestion.Text = "Choose your time for total quiz (in seconds):";
            // 
            // lblNumberOfQuestions
            // 
            lblNumberOfQuestions.AutoSize = true;
            lblNumberOfQuestions.Location = new System.Drawing.Point(35, 197);
            lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            lblNumberOfQuestions.Size = new System.Drawing.Size(247, 25);
            lblNumberOfQuestions.TabIndex = 4;
            lblNumberOfQuestions.Text = "Choose number of questions:";
            // 
            // btn15questions
            // 
            btn15questions.Location = new System.Drawing.Point(21, 248);
            btn15questions.Name = "btn15questions";
            btn15questions.Size = new System.Drawing.Size(152, 103);
            btn15questions.TabIndex = 5;
            btn15questions.Text = "15 questions";
            btn15questions.UseVisualStyleBackColor = true;
            // 
            // btn30questions
            // 
            btn30questions.Location = new System.Drawing.Point(322, 248);
            btn30questions.Name = "btn30questions";
            btn30questions.Size = new System.Drawing.Size(152, 103);
            btn30questions.TabIndex = 6;
            btn30questions.Text = "30 questions";
            btn30questions.UseVisualStyleBackColor = true;
            // 
            // btn45questions
            // 
            btn45questions.Location = new System.Drawing.Point(636, 248);
            btn45questions.Name = "btn45questions";
            btn45questions.Size = new System.Drawing.Size(152, 103);
            btn45questions.TabIndex = 7;
            btn45questions.Text = "45 questions";
            btn45questions.UseVisualStyleBackColor = true;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new System.Drawing.Point(344, 404);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new System.Drawing.Size(112, 34);
            btnStartQuiz.TabIndex = 8;
            btnStartQuiz.Text = "Start Quiz";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += countdownTimer_Tick;
            // 
            // lblScreen
            // 
            lblScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblScreen.Location = new System.Drawing.Point(344, 108);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new System.Drawing.Size(112, 38);
            lblScreen.TabIndex = 9;
            lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuizSetUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblScreen);
            Controls.Add(btnStartQuiz);
            Controls.Add(btn45questions);
            Controls.Add(btn30questions);
            Controls.Add(btn15questions);
            Controls.Add(lblNumberOfQuestions);
            Controls.Add(lblTimePerQuestion);
            Name = "frmQuizSetUp";
            Text = "Quiz Set Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTimePerQuestion;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Button btn15questions;
        private System.Windows.Forms.Button btn30questions;
        private System.Windows.Forms.Button btn45questions;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblScreen;
    }
}