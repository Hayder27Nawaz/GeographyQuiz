namespace geography_coursework
{
    partial class frmQuizPage
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
            btnOptionA = new System.Windows.Forms.Button();
            btnOptionB = new System.Windows.Forms.Button();
            btnOptionC = new System.Windows.Forms.Button();
            btnOptionD = new System.Windows.Forms.Button();
            btnNextQuestion = new System.Windows.Forms.Button();
            lblQuizQuestions = new System.Windows.Forms.Label();
            btnPreviousQuestion = new System.Windows.Forms.Button();
            btnReturnToHomePage = new System.Windows.Forms.Button();
            lblScreen = new System.Windows.Forms.Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnOptionA
            // 
            btnOptionA.Location = new System.Drawing.Point(12, 175);
            btnOptionA.Name = "btnOptionA";
            btnOptionA.Size = new System.Drawing.Size(256, 117);
            btnOptionA.TabIndex = 0;
            btnOptionA.Text = "OptionA";
            btnOptionA.UseVisualStyleBackColor = true;
            // 
            // btnOptionB
            // 
            btnOptionB.Location = new System.Drawing.Point(532, 175);
            btnOptionB.Name = "btnOptionB";
            btnOptionB.Size = new System.Drawing.Size(256, 117);
            btnOptionB.TabIndex = 1;
            btnOptionB.Text = "OptionB";
            btnOptionB.UseVisualStyleBackColor = true;
            // 
            // btnOptionC
            // 
            btnOptionC.Location = new System.Drawing.Point(12, 321);
            btnOptionC.Name = "btnOptionC";
            btnOptionC.Size = new System.Drawing.Size(256, 117);
            btnOptionC.TabIndex = 2;
            btnOptionC.Text = "OptionC";
            btnOptionC.UseVisualStyleBackColor = true;
            // 
            // btnOptionD
            // 
            btnOptionD.Location = new System.Drawing.Point(532, 321);
            btnOptionD.Name = "btnOptionD";
            btnOptionD.Size = new System.Drawing.Size(256, 117);
            btnOptionD.TabIndex = 3;
            btnOptionD.Text = "OptionD";
            btnOptionD.UseVisualStyleBackColor = true;
            // 
            // btnNextQuestion
            // 
            btnNextQuestion.Location = new System.Drawing.Point(272, 312);
            btnNextQuestion.Name = "btnNextQuestion";
            btnNextQuestion.Size = new System.Drawing.Size(254, 77);
            btnNextQuestion.TabIndex = 4;
            btnNextQuestion.Text = "Next Question";
            btnNextQuestion.UseVisualStyleBackColor = true;
            // 
            // lblQuizQuestions
            // 
            lblQuizQuestions.AutoSize = true;
            lblQuizQuestions.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblQuizQuestions.Location = new System.Drawing.Point(333, 93);
            lblQuizQuestions.Name = "lblQuizQuestions";
            lblQuizQuestions.Size = new System.Drawing.Size(139, 41);
            lblQuizQuestions.TabIndex = 5;
            lblQuizQuestions.Text = "Question";
            // 
            // btnPreviousQuestion
            // 
            btnPreviousQuestion.Location = new System.Drawing.Point(272, 229);
            btnPreviousQuestion.Name = "btnPreviousQuestion";
            btnPreviousQuestion.Size = new System.Drawing.Size(254, 77);
            btnPreviousQuestion.TabIndex = 6;
            btnPreviousQuestion.Text = "Previous Question";
            btnPreviousQuestion.UseVisualStyleBackColor = true;
            // 
            // btnReturnToHomePage
            // 
            btnReturnToHomePage.Location = new System.Drawing.Point(14, 12);
            btnReturnToHomePage.Name = "btnReturnToHomePage";
            btnReturnToHomePage.Size = new System.Drawing.Size(254, 45);
            btnReturnToHomePage.TabIndex = 7;
            btnReturnToHomePage.Text = "back to student home page";
            btnReturnToHomePage.UseVisualStyleBackColor = true;
            btnReturnToHomePage.Click += btnReturnToHomePage_Click;
            // 
            // lblScreen
            // 
            lblScreen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblScreen.Location = new System.Drawing.Point(628, 25);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new System.Drawing.Size(100, 43);
            lblScreen.TabIndex = 8;
            lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownTimer
            // 
            // 
            // frmQuizPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblScreen);
            Controls.Add(btnReturnToHomePage);
            Controls.Add(btnPreviousQuestion);
            Controls.Add(lblQuizQuestions);
            Controls.Add(btnNextQuestion);
            Controls.Add(btnOptionD);
            Controls.Add(btnOptionC);
            Controls.Add(btnOptionB);
            Controls.Add(btnOptionA);
            Name = "frmQuizPage";
            Text = "Quiz Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.Button btnOptionD;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Label lblQuizQuestions;
        private System.Windows.Forms.Button btnPreviousQuestion;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.Label lblScreen;
        private System.Windows.Forms.Timer countdownTimer;
    }
}