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
            this.btnStartRevising = new System.Windows.Forms.Button();
            this.btnLastRevisionTest = new System.Windows.Forms.Button();
            this.btnPreviousTestResults = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartRevising
            // 
            this.btnStartRevising.Location = new System.Drawing.Point(269, 72);
            this.btnStartRevising.Name = "btnStartRevising";
            this.btnStartRevising.Size = new System.Drawing.Size(281, 57);
            this.btnStartRevising.TabIndex = 0;
            this.btnStartRevising.Text = "Start Revising";
            this.btnStartRevising.UseVisualStyleBackColor = true;
            this.btnStartRevising.Click += new System.EventHandler(this.QuizStart);
            // 
            // btnLastRevisionTest
            // 
            this.btnLastRevisionTest.Location = new System.Drawing.Point(243, 135);
            this.btnLastRevisionTest.Name = "btnLastRevisionTest";
            this.btnLastRevisionTest.Size = new System.Drawing.Size(338, 40);
            this.btnLastRevisionTest.TabIndex = 1;
            this.btnLastRevisionTest.Text = "Continue Last Revision Session";
            this.btnLastRevisionTest.UseVisualStyleBackColor = true;
            this.btnLastRevisionTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPreviousTestResults
            // 
            this.btnPreviousTestResults.Location = new System.Drawing.Point(269, 237);
            this.btnPreviousTestResults.Name = "btnPreviousTestResults";
            this.btnPreviousTestResults.Size = new System.Drawing.Size(281, 72);
            this.btnPreviousTestResults.TabIndex = 2;
            this.btnPreviousTestResults.Text = "Previous Test Scores";
            this.btnPreviousTestResults.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(269, 315);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(281, 44);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // frmStudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPreviousTestResults);
            this.Controls.Add(this.btnLastRevisionTest);
            this.Controls.Add(this.btnStartRevising);
            this.Name = "frmStudentHomePage";
            this.Text = "Student Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartRevising;
        private System.Windows.Forms.Button btnLastRevisionTest;
        private System.Windows.Forms.Button btnPreviousTestResults;
        private System.Windows.Forms.Button btnSettings;
    }
}