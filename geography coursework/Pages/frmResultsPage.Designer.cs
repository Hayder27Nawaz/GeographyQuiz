using System.Windows.Forms;

namespace geography_coursework.Pages
{
    partial class frmResultsPage
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
            lblScore = new Label();
            dgvResults = new DataGridView();
            Category = new DataGridViewTextBoxColumn();
            PercentageScore = new DataGridViewTextBoxColumn();
            btnStartNewQuiz = new Button();
            btnReviewAnswers = new Button();
            lblErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblScore.Location = new System.Drawing.Point(523, 34);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(95, 41);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score";
            // 
            // dgvResults
            // 
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Category, PercentageScore });
            dgvResults.Location = new System.Drawing.Point(17, 112);
            dgvResults.Margin = new Padding(4, 5, 4, 5);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 62;
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new System.Drawing.Size(1109, 303);
            dgvResults.TabIndex = 1;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.MinimumWidth = 8;
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // PercentageScore
            // 
            PercentageScore.HeaderText = "Score";
            PercentageScore.MinimumWidth = 8;
            PercentageScore.Name = "PercentageScore";
            PercentageScore.ReadOnly = true;
            // 
            // btnStartNewQuiz
            // 
            btnStartNewQuiz.Location = new System.Drawing.Point(858, 490);
            btnStartNewQuiz.Margin = new Padding(4, 5, 4, 5);
            btnStartNewQuiz.Name = "btnStartNewQuiz";
            btnStartNewQuiz.Size = new System.Drawing.Size(268, 190);
            btnStartNewQuiz.TabIndex = 2;
            btnStartNewQuiz.Text = "New";
            btnStartNewQuiz.UseVisualStyleBackColor = true;
            btnStartNewQuiz.Click += btnStartNewQuiz_Click;
            // 
            // btnReviewAnswers
            // 
            btnReviewAnswers.Location = new System.Drawing.Point(17, 490);
            btnReviewAnswers.Margin = new Padding(4, 5, 4, 5);
            btnReviewAnswers.Name = "btnReviewAnswers";
            btnReviewAnswers.Size = new System.Drawing.Size(268, 190);
            btnReviewAnswers.TabIndex = 3;
            btnReviewAnswers.Text = "Review Answers";
            btnReviewAnswers.UseVisualStyleBackColor = true;
            btnReviewAnswers.Click += btnReviewAnswers_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            lblErrorMessage.Location = new System.Drawing.Point(523, 567);
            lblErrorMessage.Margin = new Padding(4, 0, 4, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(72, 32);
            lblErrorMessage.TabIndex = 4;
            lblErrorMessage.Text = "Error";
            // 
            // frmResultsPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnReviewAnswers);
            Controls.Add(btnStartNewQuiz);
            Controls.Add(dgvResults);
            Controls.Add(lblScore);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmResultsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Results";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private DataGridView dgvResults;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn PercentageScore;
        private Button btnStartNewQuiz;
        private Button btnReviewAnswers;
        private Label lblErrorMessage;
    }
}