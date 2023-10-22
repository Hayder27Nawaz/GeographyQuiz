namespace geography_coursework
{
    partial class frmCategorySelect
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
            lblCategoryChoice = new System.Windows.Forms.Label();
            listTopics = new System.Windows.Forms.ListBox();
            btnReturnToHomePage = new System.Windows.Forms.Button();
            btnStartQuiz = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblCategoryChoice
            // 
            lblCategoryChoice.AutoSize = true;
            lblCategoryChoice.Location = new System.Drawing.Point(308, 87);
            lblCategoryChoice.Name = "lblCategoryChoice";
            lblCategoryChoice.Size = new System.Drawing.Size(173, 25);
            lblCategoryChoice.TabIndex = 0;
            lblCategoryChoice.Text = "Select your category";
            // 
            // listTopics
            // 
            listTopics.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            listTopics.ForeColor = System.Drawing.Color.ForestGreen;
            listTopics.FormattingEnabled = true;
            listTopics.ItemHeight = 34;
            listTopics.Items.AddRange(new object[] { "3.1.1 Section A: The challenge of natural hazards", "3.1.2 Section B: The living world", "3.1.3 Section C: Physical landscapes in the UK", "3.2.1 Section A: Urban issues and challenges", "3.2.2 Section B: The changing economic world", "3.2.3 Section C: The challenge of resource management" });
            listTopics.Location = new System.Drawing.Point(61, 158);
            listTopics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listTopics.Name = "listTopics";
            listTopics.Size = new System.Drawing.Size(675, 208);
            listTopics.TabIndex = 5;
            listTopics.SelectedIndexChanged += listTopics_SelectedIndexChanged;
            // 
            // btnReturnToHomePage
            // 
            btnReturnToHomePage.Location = new System.Drawing.Point(265, 12);
            btnReturnToHomePage.Name = "btnReturnToHomePage";
            btnReturnToHomePage.Size = new System.Drawing.Size(254, 45);
            btnReturnToHomePage.TabIndex = 10;
            btnReturnToHomePage.Text = "back to student home page";
            btnReturnToHomePage.UseVisualStyleBackColor = true;
            // 
            // btnStartQuiz
            // 
            btnStartQuiz.Location = new System.Drawing.Point(326, 383);
            btnStartQuiz.Name = "btnStartQuiz";
            btnStartQuiz.Size = new System.Drawing.Size(141, 40);
            btnStartQuiz.TabIndex = 11;
            btnStartQuiz.Text = "Start";
            btnStartQuiz.UseVisualStyleBackColor = true;
            btnStartQuiz.Click += btnStartQuiz_Click;
            // 
            // frmCategorySelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnStartQuiz);
            Controls.Add(btnReturnToHomePage);
            Controls.Add(listTopics);
            Controls.Add(lblCategoryChoice);
            Name = "frmCategorySelect";
            Text = "Categories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCategoryChoice;
        private System.Windows.Forms.ListBox listTopics;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}