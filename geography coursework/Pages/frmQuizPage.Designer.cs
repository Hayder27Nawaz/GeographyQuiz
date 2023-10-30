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
            btnReturnToHomePage = new System.Windows.Forms.Button();
            lblTimer = new System.Windows.Forms.Label();
            countdownTimer = new System.Windows.Forms.Timer(components);
            lblQuestion = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
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
            btnOptionA.Click += btnOptionA_Click;
            // 
            // btnOptionB
            // 
            btnOptionB.Location = new System.Drawing.Point(532, 175);
            btnOptionB.Name = "btnOptionB";
            btnOptionB.Size = new System.Drawing.Size(256, 117);
            btnOptionB.TabIndex = 1;
            btnOptionB.Text = "OptionB";
            btnOptionB.UseVisualStyleBackColor = true;
            btnOptionB.Click += btnOptionB_Click;
            // 
            // btnOptionC
            // 
            btnOptionC.Location = new System.Drawing.Point(12, 321);
            btnOptionC.Name = "btnOptionC";
            btnOptionC.Size = new System.Drawing.Size(256, 117);
            btnOptionC.TabIndex = 2;
            btnOptionC.Text = "OptionC";
            btnOptionC.UseVisualStyleBackColor = true;
            btnOptionC.Click += btnOptionC_Click;
            // 
            // btnOptionD
            // 
            btnOptionD.Location = new System.Drawing.Point(532, 321);
            btnOptionD.Name = "btnOptionD";
            btnOptionD.Size = new System.Drawing.Size(256, 117);
            btnOptionD.TabIndex = 3;
            btnOptionD.Text = "OptionD";
            btnOptionD.UseVisualStyleBackColor = true;
            btnOptionD.Click += btnOptionD_Click;
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
            // lblTimer
            // 
            lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTimer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTimer.Location = new System.Drawing.Point(688, 12);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new System.Drawing.Size(100, 45);
            lblTimer.TabIndex = 8;
            lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblQuestion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblQuestion.Location = new System.Drawing.Point(353, 89);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(100, 45);
            lblQuestion.TabIndex = 9;
            lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new System.Drawing.Point(332, 281);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(137, 51);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmQuizPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(lblQuestion);
            Controls.Add(lblTimer);
            Controls.Add(btnReturnToHomePage);
            Controls.Add(btnOptionD);
            Controls.Add(btnOptionC);
            Controls.Add(btnOptionB);
            Controls.Add(btnOptionA);
            Name = "frmQuizPage";
            Text = "Quiz Page";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOptionA;
        private System.Windows.Forms.Button btnOptionB;
        private System.Windows.Forms.Button btnOptionC;
        private System.Windows.Forms.Button btnOptionD;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnPreviousQuestion;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnQuizQuestions;
    }
}