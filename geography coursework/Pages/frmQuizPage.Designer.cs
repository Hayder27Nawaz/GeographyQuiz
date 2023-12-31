﻿namespace geography_coursework
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
            lblCounter = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblQuestion = new System.Windows.Forms.Label();
            lblTracker = new System.Windows.Forms.Label();
            lblDifficulty = new System.Windows.Forms.Label();
            lblResult = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
            lblCategory = new System.Windows.Forms.Label();
            lblScore = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnOptionA
            // 
            btnOptionA.BackColor = System.Drawing.Color.Lime;
            btnOptionA.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOptionA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOptionA.Location = new System.Drawing.Point(12, 175);
            btnOptionA.Name = "btnOptionA";
            btnOptionA.Size = new System.Drawing.Size(269, 117);
            btnOptionA.TabIndex = 0;
            btnOptionA.Text = "OptionA";
            btnOptionA.UseVisualStyleBackColor = false;
            btnOptionA.Click += btnOptionA_Click;
            // 
            // btnOptionB
            // 
            btnOptionB.BackColor = System.Drawing.Color.Lime;
            btnOptionB.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOptionB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOptionB.Location = new System.Drawing.Point(520, 175);
            btnOptionB.Name = "btnOptionB";
            btnOptionB.Size = new System.Drawing.Size(268, 117);
            btnOptionB.TabIndex = 1;
            btnOptionB.Text = "OptionB";
            btnOptionB.UseVisualStyleBackColor = false;
            btnOptionB.Click += btnOptionB_Click;
            // 
            // btnOptionC
            // 
            btnOptionC.BackColor = System.Drawing.Color.Lime;
            btnOptionC.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOptionC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOptionC.Location = new System.Drawing.Point(12, 321);
            btnOptionC.Name = "btnOptionC";
            btnOptionC.Size = new System.Drawing.Size(269, 117);
            btnOptionC.TabIndex = 2;
            btnOptionC.Text = "OptionC";
            btnOptionC.UseVisualStyleBackColor = false;
            btnOptionC.Click += btnOptionC_Click;
            // 
            // btnOptionD
            // 
            btnOptionD.BackColor = System.Drawing.Color.Lime;
            btnOptionD.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnOptionD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnOptionD.Location = new System.Drawing.Point(520, 321);
            btnOptionD.Name = "btnOptionD";
            btnOptionD.Size = new System.Drawing.Size(268, 117);
            btnOptionD.TabIndex = 3;
            btnOptionD.Text = "OptionD";
            btnOptionD.UseVisualStyleBackColor = false;
            btnOptionD.Click += btnOptionD_Click;
            // 
            // lblCounter
            // 
            lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCounter.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCounter.ForeColor = System.Drawing.Color.Green;
            lblCounter.Location = new System.Drawing.Point(581, 11);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new System.Drawing.Size(207, 45);
            lblCounter.TabIndex = 8;
            lblCounter.Text = "Time remaining:";
            lblCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            lblQuestion.BackColor = System.Drawing.Color.Transparent;
            lblQuestion.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblQuestion.ForeColor = System.Drawing.SystemColors.Control;
            lblQuestion.Location = new System.Drawing.Point(225, 9);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new System.Drawing.Size(350, 141);
            lblQuestion.TabIndex = 9;
            lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTracker
            // 
            lblTracker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblTracker.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTracker.ForeColor = System.Drawing.Color.Green;
            lblTracker.Location = new System.Drawing.Point(581, 68);
            lblTracker.Name = "lblTracker";
            lblTracker.Size = new System.Drawing.Size(207, 45);
            lblTracker.TabIndex = 11;
            lblTracker.Text = "Question:";
            lblTracker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDifficulty
            // 
            lblDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblDifficulty.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDifficulty.ForeColor = System.Drawing.Color.Green;
            lblDifficulty.Location = new System.Drawing.Point(12, 68);
            lblDifficulty.Name = "lblDifficulty";
            lblDifficulty.Size = new System.Drawing.Size(207, 45);
            lblDifficulty.TabIndex = 13;
            lblDifficulty.Text = "Difficulty:";
            lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            lblResult.BackColor = System.Drawing.Color.Transparent;
            lblResult.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblResult.Location = new System.Drawing.Point(344, 214);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(112, 38);
            lblResult.TabIndex = 14;
            lblResult.Text = "Result";
            lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSubmit.ForeColor = System.Drawing.Color.Green;
            btnSubmit.Location = new System.Drawing.Point(332, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(138, 50);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblCategory
            // 
            lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblCategory.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCategory.ForeColor = System.Drawing.Color.Green;
            lblCategory.Location = new System.Drawing.Point(12, 9);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new System.Drawing.Size(207, 45);
            lblCategory.TabIndex = 16;
            lblCategory.Text = "Category:";
            lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.BackColor = System.Drawing.Color.Transparent;
            lblScore.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblScore.Location = new System.Drawing.Point(344, 288);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(112, 38);
            lblScore.TabIndex = 17;
            lblScore.Text = "Score";
            lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuizPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.savannah_transition;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblScore);
            Controls.Add(lblCategory);
            Controls.Add(btnSubmit);
            Controls.Add(lblResult);
            Controls.Add(lblDifficulty);
            Controls.Add(lblTracker);
            Controls.Add(lblQuestion);
            Controls.Add(lblCounter);
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
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnQuizQuestions;
        private System.Windows.Forms.Label lblTracker;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblScore;
    }
}