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
            this.lblTimePerQuestion = new System.Windows.Forms.Label();
            this.btn15seconds = new System.Windows.Forms.Button();
            this.btn30seconds = new System.Windows.Forms.Button();
            this.btn45seconds = new System.Windows.Forms.Button();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.btn15questions = new System.Windows.Forms.Button();
            this.btn30questions = new System.Windows.Forms.Button();
            this.btn45questions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTimePerQuestion
            // 
            this.lblTimePerQuestion.AutoSize = true;
            this.lblTimePerQuestion.Location = new System.Drawing.Point(35, 35);
            this.lblTimePerQuestion.Name = "lblTimePerQuestion";
            this.lblTimePerQuestion.Size = new System.Drawing.Size(361, 25);
            this.lblTimePerQuestion.TabIndex = 0;
            this.lblTimePerQuestion.Text = "Choose your time per question (in seconds):";
            // 
            // btn15seconds
            // 
            this.btn15seconds.Location = new System.Drawing.Point(50, 102);
            this.btn15seconds.Name = "btn15seconds";
            this.btn15seconds.Size = new System.Drawing.Size(152, 103);
            this.btn15seconds.TabIndex = 1;
            this.btn15seconds.Text = "15 seconds";
            this.btn15seconds.UseVisualStyleBackColor = true;
            // 
            // btn30seconds
            // 
            this.btn30seconds.Location = new System.Drawing.Point(325, 102);
            this.btn30seconds.Name = "btn30seconds";
            this.btn30seconds.Size = new System.Drawing.Size(152, 103);
            this.btn30seconds.TabIndex = 2;
            this.btn30seconds.Text = "30 seconds";
            this.btn30seconds.UseVisualStyleBackColor = true;
            // 
            // btn45seconds
            // 
            this.btn45seconds.Location = new System.Drawing.Point(596, 102);
            this.btn45seconds.Name = "btn45seconds";
            this.btn45seconds.Size = new System.Drawing.Size(152, 103);
            this.btn45seconds.TabIndex = 3;
            this.btn45seconds.Text = "45 seconds";
            this.btn45seconds.UseVisualStyleBackColor = true;
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(35, 252);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(247, 25);
            this.lblNumberOfQuestions.TabIndex = 4;
            this.lblNumberOfQuestions.Text = "Choose number of questions:";
            // 
            // btn15questions
            // 
            this.btn15questions.Location = new System.Drawing.Point(50, 315);
            this.btn15questions.Name = "btn15questions";
            this.btn15questions.Size = new System.Drawing.Size(152, 103);
            this.btn15questions.TabIndex = 5;
            this.btn15questions.Text = "15 questions";
            this.btn15questions.UseVisualStyleBackColor = true;
            // 
            // btn30questions
            // 
            this.btn30questions.Location = new System.Drawing.Point(325, 315);
            this.btn30questions.Name = "btn30questions";
            this.btn30questions.Size = new System.Drawing.Size(152, 103);
            this.btn30questions.TabIndex = 6;
            this.btn30questions.Text = "30 questions";
            this.btn30questions.UseVisualStyleBackColor = true;
            // 
            // btn45questions
            // 
            this.btn45questions.Location = new System.Drawing.Point(596, 315);
            this.btn45questions.Name = "btn45questions";
            this.btn45questions.Size = new System.Drawing.Size(152, 103);
            this.btn45questions.TabIndex = 7;
            this.btn45questions.Text = "45 questions";
            this.btn45questions.UseVisualStyleBackColor = true;
            // 
            // frmQuizSetUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn45questions);
            this.Controls.Add(this.btn30questions);
            this.Controls.Add(this.btn15questions);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.btn45seconds);
            this.Controls.Add(this.btn30seconds);
            this.Controls.Add(this.btn15seconds);
            this.Controls.Add(this.lblTimePerQuestion);
            this.Name = "frmQuizSetUp";
            this.Text = "Quiz Set Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimePerQuestion;
        private System.Windows.Forms.Button btn15seconds;
        private System.Windows.Forms.Button btn30seconds;
        private System.Windows.Forms.Button btn45seconds;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Button btn15questions;
        private System.Windows.Forms.Button btn30questions;
        private System.Windows.Forms.Button btn45questions;
    }
}