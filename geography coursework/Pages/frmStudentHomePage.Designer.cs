namespace geography_coursework
{
    partial class frmStudentHomePage
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
            btnStartRevising = new System.Windows.Forms.Button();
            btnLastRevisionTest = new System.Windows.Forms.Button();
            btnPreviousQuizResults = new System.Windows.Forms.Button();
            btnSettings = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnStartRevising
            // 
            btnStartRevising.Location = new System.Drawing.Point(269, 72);
            btnStartRevising.Name = "btnStartRevising";
            btnStartRevising.Size = new System.Drawing.Size(281, 57);
            btnStartRevising.TabIndex = 0;
            btnStartRevising.Text = "Start Revising";
            btnStartRevising.UseVisualStyleBackColor = true;
            btnStartRevising.Click += btnStartRevising_Click;
            // 
            // btnLastRevisionTest
            // 
            btnLastRevisionTest.Location = new System.Drawing.Point(243, 135);
            btnLastRevisionTest.Name = "btnLastRevisionTest";
            btnLastRevisionTest.Size = new System.Drawing.Size(338, 40);
            btnLastRevisionTest.TabIndex = 1;
            btnLastRevisionTest.Text = "Continue Last Revision Session";
            btnLastRevisionTest.UseVisualStyleBackColor = true;
            btnLastRevisionTest.Click += btnLastRevisionTest_Click;
            // 
            // btnPreviousQuizResults
            // 
            btnPreviousQuizResults.Location = new System.Drawing.Point(269, 237);
            btnPreviousQuizResults.Name = "btnPreviousQuizResults";
            btnPreviousQuizResults.Size = new System.Drawing.Size(281, 72);
            btnPreviousQuizResults.TabIndex = 2;
            btnPreviousQuizResults.Text = "Previous Quiz Scores";
            btnPreviousQuizResults.UseVisualStyleBackColor = true;
            btnPreviousQuizResults.Click += btnPreviousTestResults_Click;
            // 
            // btnSettings
            // 
            btnSettings.Location = new System.Drawing.Point(269, 315);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(281, 44);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // frmStudentHomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnSettings);
            Controls.Add(btnPreviousQuizResults);
            Controls.Add(btnLastRevisionTest);
            Controls.Add(btnStartRevising);
            Name = "frmStudentHomePage";
            Text = "Student Home Page";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnStartRevising;
        private System.Windows.Forms.Button btnLastRevisionTest;
        private System.Windows.Forms.Button btnPreviousQuizResults;
        private System.Windows.Forms.Button btnSettings;
    }
}