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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lblScore.BackColor = System.Drawing.Color.Transparent;
            lblScore.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblScore.Location = new System.Drawing.Point(353, 21);
            lblScore.Margin = new Padding(4, 0, 4, 0);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(107, 40);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score";
            // 
            // dgvResults
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Category, PercentageScore });
            dgvResults.Location = new System.Drawing.Point(13, 83);
            dgvResults.Margin = new Padding(4, 5, 4, 5);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 62;
            dgvResults.RowTemplate.Height = 25;
            dgvResults.Size = new System.Drawing.Size(774, 197);
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
            btnStartNewQuiz.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStartNewQuiz.ForeColor = System.Drawing.Color.Green;
            btnStartNewQuiz.Location = new System.Drawing.Point(571, 312);
            btnStartNewQuiz.Margin = new Padding(4, 5, 4, 5);
            btnStartNewQuiz.Name = "btnStartNewQuiz";
            btnStartNewQuiz.Size = new System.Drawing.Size(216, 112);
            btnStartNewQuiz.TabIndex = 2;
            btnStartNewQuiz.Text = "New";
            btnStartNewQuiz.UseVisualStyleBackColor = true;
            btnStartNewQuiz.Click += btnStartNewQuiz_Click;
            // 
            // btnReviewAnswers
            // 
            btnReviewAnswers.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReviewAnswers.ForeColor = System.Drawing.Color.Green;
            btnReviewAnswers.Location = new System.Drawing.Point(13, 312);
            btnReviewAnswers.Margin = new Padding(4, 5, 4, 5);
            btnReviewAnswers.Name = "btnReviewAnswers";
            btnReviewAnswers.Size = new System.Drawing.Size(216, 112);
            btnReviewAnswers.TabIndex = 3;
            btnReviewAnswers.Text = "Review Answers";
            btnReviewAnswers.UseVisualStyleBackColor = true;
            btnReviewAnswers.Click += btnReviewAnswers_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            lblErrorMessage.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblErrorMessage.Location = new System.Drawing.Point(370, 351);
            lblErrorMessage.Margin = new Padding(4, 0, 4, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(80, 31);
            lblErrorMessage.TabIndex = 4;
            lblErrorMessage.Text = "Error";
            // 
            // frmResultsPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lime;
            BackgroundImage = Properties.Resources.geoquiz_homepage_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 450);
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