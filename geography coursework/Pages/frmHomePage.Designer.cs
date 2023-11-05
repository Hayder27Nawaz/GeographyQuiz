namespace geography_coursework
{
    partial class frmHomePage
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
            lblCategoryChoice = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnStartRevising
            // 
            btnStartRevising.BackColor = System.Drawing.Color.Lime;
            btnStartRevising.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnStartRevising.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStartRevising.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnStartRevising.Location = new System.Drawing.Point(269, 146);
            btnStartRevising.Name = "btnStartRevising";
            btnStartRevising.Size = new System.Drawing.Size(281, 57);
            btnStartRevising.TabIndex = 0;
            btnStartRevising.Text = "Start Revising";
            btnStartRevising.UseVisualStyleBackColor = false;
            btnStartRevising.Click += btnStartRevising_Click;
            // 
            // btnLastRevisionTest
            // 
            btnLastRevisionTest.BackColor = System.Drawing.Color.Cyan;
            btnLastRevisionTest.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLastRevisionTest.ForeColor = System.Drawing.SystemColors.HighlightText;
            btnLastRevisionTest.Location = new System.Drawing.Point(240, 209);
            btnLastRevisionTest.Name = "btnLastRevisionTest";
            btnLastRevisionTest.Size = new System.Drawing.Size(338, 40);
            btnLastRevisionTest.TabIndex = 1;
            btnLastRevisionTest.Text = "Continue Last Revision Session";
            btnLastRevisionTest.UseVisualStyleBackColor = false;
            btnLastRevisionTest.Click += btnLastRevisionTest_Click;
            // 
            // btnPreviousQuizResults
            // 
            btnPreviousQuizResults.BackgroundImage = Properties.Resources.Geography_homepage_image;
            btnPreviousQuizResults.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPreviousQuizResults.ForeColor = System.Drawing.SystemColors.Control;
            btnPreviousQuizResults.Location = new System.Drawing.Point(269, 288);
            btnPreviousQuizResults.Name = "btnPreviousQuizResults";
            btnPreviousQuizResults.Size = new System.Drawing.Size(281, 76);
            btnPreviousQuizResults.TabIndex = 2;
            btnPreviousQuizResults.Text = "Previous Quiz Scores";
            btnPreviousQuizResults.UseVisualStyleBackColor = true;
            btnPreviousQuizResults.Click += btnPreviousTestResults_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = System.Drawing.Color.Cyan;
            btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSettings.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            btnSettings.Location = new System.Drawing.Point(269, 370);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(281, 44);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // lblCategoryChoice
            // 
            lblCategoryChoice.AutoSize = true;
            lblCategoryChoice.BackColor = System.Drawing.Color.Transparent;
            lblCategoryChoice.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCategoryChoice.ForeColor = System.Drawing.SystemColors.Window;
            lblCategoryChoice.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            lblCategoryChoice.Location = new System.Drawing.Point(309, 52);
            lblCategoryChoice.Name = "lblCategoryChoice";
            lblCategoryChoice.Size = new System.Drawing.Size(195, 53);
            lblCategoryChoice.TabIndex = 4;
            lblCategoryChoice.Text = "GeoQuiz";
            lblCategoryChoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmStudentHomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.geoquiz_homepage_21;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblCategoryChoice);
            Controls.Add(btnSettings);
            Controls.Add(btnPreviousQuizResults);
            Controls.Add(btnLastRevisionTest);
            Controls.Add(btnStartRevising);
            Name = "frmStudentHomePage";
            Text = "Student Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStartRevising;
        private System.Windows.Forms.Button btnLastRevisionTest;
        private System.Windows.Forms.Button btnPreviousQuizResults;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblCategoryChoice;
    }
}