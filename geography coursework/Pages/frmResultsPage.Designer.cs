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
            lblScore = new System.Windows.Forms.Label();
            btnReturnToHomePage = new System.Windows.Forms.Button();
            tblCategoryStrengths = new System.Windows.Forms.DataGridView();
            tblCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tblScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblRevisionSuggestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)tblCategoryStrengths).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.Location = new System.Drawing.Point(318, 84);
            lblScore.Name = "lblScore";
            lblScore.Size = new System.Drawing.Size(65, 25);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score: ";
            lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturnToHomePage
            // 
            btnReturnToHomePage.Location = new System.Drawing.Point(277, 12);
            btnReturnToHomePage.Name = "btnReturnToHomePage";
            btnReturnToHomePage.Size = new System.Drawing.Size(254, 45);
            btnReturnToHomePage.TabIndex = 1;
            btnReturnToHomePage.Text = "back to student home page";
            btnReturnToHomePage.UseVisualStyleBackColor = true;
            btnReturnToHomePage.Click += button1_Click;
            // 
            // tblCategoryStrengths
            // 
            tblCategoryStrengths.AllowUserToOrderColumns = true;
            tblCategoryStrengths.ColumnHeadersHeight = 34;
            tblCategoryStrengths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { tblCategory, tblScore });
            tblCategoryStrengths.Location = new System.Drawing.Point(59, 145);
            tblCategoryStrengths.Name = "tblCategoryStrengths";
            tblCategoryStrengths.RowHeadersWidth = 62;
            tblCategoryStrengths.RowTemplate.Height = 33;
            tblCategoryStrengths.Size = new System.Drawing.Size(681, 201);
            tblCategoryStrengths.TabIndex = 2;
            // 
            // tblCategory
            // 
            tblCategory.HeaderText = "Category";
            tblCategory.MinimumWidth = 8;
            tblCategory.Name = "tblCategory";
            tblCategory.Width = 150;
            // 
            // tblScore
            // 
            tblScore.HeaderText = "Score";
            tblScore.MinimumWidth = 8;
            tblScore.Name = "tblScore";
            tblScore.Width = 150;
            // 
            // lblRevisionSuggestion
            // 
            lblRevisionSuggestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lblRevisionSuggestion.Location = new System.Drawing.Point(318, 384);
            lblRevisionSuggestion.Name = "lblRevisionSuggestion";
            lblRevisionSuggestion.Size = new System.Drawing.Size(65, 25);
            lblRevisionSuggestion.TabIndex = 3;
            lblRevisionSuggestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmResultsPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblRevisionSuggestion);
            Controls.Add(tblCategoryStrengths);
            Controls.Add(btnReturnToHomePage);
            Controls.Add(lblScore);
            Name = "frmResultsPage";
            Text = "frmResultsPage";
            ((System.ComponentModel.ISupportInitialize)tblCategoryStrengths).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.DataGridView tblCategoryStrengths;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblScore;
        private System.Windows.Forms.Label lblRevisionSuggestion;
    }
}