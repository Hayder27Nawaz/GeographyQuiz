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
            btnViewHighscores = new System.Windows.Forms.Button();
            btnViewSummary = new System.Windows.Forms.Button();
            lblGeoQuizTitle = new System.Windows.Forms.Label();
            btnStartSimpleQuiz = new System.Windows.Forms.Button();
            btnStartComplexQuiz = new System.Windows.Forms.Button();
            btnStartCustomQuiz = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnViewHighscores
            // 
            btnViewHighscores.BackgroundImage = Properties.Resources.Geography_homepage_image;
            btnViewHighscores.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnViewHighscores.ForeColor = System.Drawing.SystemColors.Control;
            btnViewHighscores.Location = new System.Drawing.Point(269, 312);
            btnViewHighscores.Name = "btnViewHighscores";
            btnViewHighscores.Size = new System.Drawing.Size(281, 76);
            btnViewHighscores.TabIndex = 2;
            btnViewHighscores.Text = "View Highscore";
            btnViewHighscores.UseVisualStyleBackColor = true;
            btnViewHighscores.Click += btnViewHighscores_Click_1;
            // 
            // btnViewSummary
            // 
            btnViewSummary.BackColor = System.Drawing.Color.Lime;
            btnViewSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnViewSummary.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnViewSummary.ForeColor = System.Drawing.SystemColors.Control;
            btnViewSummary.Location = new System.Drawing.Point(269, 394);
            btnViewSummary.Name = "btnViewSummary";
            btnViewSummary.Size = new System.Drawing.Size(281, 44);
            btnViewSummary.TabIndex = 3;
            btnViewSummary.Text = "View Summary";
            btnViewSummary.UseVisualStyleBackColor = false;
            btnViewSummary.Click += btnViewSummary_Click_1;
            // 
            // lblGeoQuizTitle
            // 
            lblGeoQuizTitle.AutoSize = true;
            lblGeoQuizTitle.BackColor = System.Drawing.Color.Transparent;
            lblGeoQuizTitle.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGeoQuizTitle.ForeColor = System.Drawing.SystemColors.Window;
            lblGeoQuizTitle.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            lblGeoQuizTitle.Location = new System.Drawing.Point(310, 59);
            lblGeoQuizTitle.Name = "lblGeoQuizTitle";
            lblGeoQuizTitle.Size = new System.Drawing.Size(195, 53);
            lblGeoQuizTitle.TabIndex = 4;
            lblGeoQuizTitle.Text = "GeoQuiz";
            lblGeoQuizTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartSimpleQuiz
            // 
            btnStartSimpleQuiz.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStartSimpleQuiz.ForeColor = System.Drawing.Color.Green;
            btnStartSimpleQuiz.Location = new System.Drawing.Point(39, 130);
            btnStartSimpleQuiz.Name = "btnStartSimpleQuiz";
            btnStartSimpleQuiz.Size = new System.Drawing.Size(230, 165);
            btnStartSimpleQuiz.TabIndex = 5;
            btnStartSimpleQuiz.Text = "Simple";
            btnStartSimpleQuiz.UseVisualStyleBackColor = true;
            btnStartSimpleQuiz.Click += btnStartSimpleQuiz_Click;
            // 
            // btnStartComplexQuiz
            // 
            btnStartComplexQuiz.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStartComplexQuiz.ForeColor = System.Drawing.Color.Green;
            btnStartComplexQuiz.Location = new System.Drawing.Point(293, 130);
            btnStartComplexQuiz.Name = "btnStartComplexQuiz";
            btnStartComplexQuiz.Size = new System.Drawing.Size(230, 165);
            btnStartComplexQuiz.TabIndex = 6;
            btnStartComplexQuiz.Text = "Complex";
            btnStartComplexQuiz.UseVisualStyleBackColor = true;
            btnStartComplexQuiz.Click += btnStartComplexQuiz_Click;
            // 
            // btnStartCustomQuiz
            // 
            btnStartCustomQuiz.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnStartCustomQuiz.ForeColor = System.Drawing.Color.Green;
            btnStartCustomQuiz.Location = new System.Drawing.Point(549, 130);
            btnStartCustomQuiz.Name = "btnStartCustomQuiz";
            btnStartCustomQuiz.Size = new System.Drawing.Size(230, 165);
            btnStartCustomQuiz.TabIndex = 7;
            btnStartCustomQuiz.Text = "Custom";
            btnStartCustomQuiz.UseVisualStyleBackColor = true;
            btnStartCustomQuiz.Click += btnStartCustomQuiz_Click;
            // 
            // txtName
            // 
            txtName.BackColor = System.Drawing.SystemColors.Control;
            txtName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.ForeColor = System.Drawing.Color.Green;
            txtName.Location = new System.Drawing.Point(269, 25);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(281, 34);
            txtName.TabIndex = 8;
            txtName.Text = "Enter Name";
            txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmHomePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.geoquiz_homepage_21;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtName);
            Controls.Add(btnStartCustomQuiz);
            Controls.Add(btnStartComplexQuiz);
            Controls.Add(btnStartSimpleQuiz);
            Controls.Add(lblGeoQuizTitle);
            Controls.Add(btnViewSummary);
            Controls.Add(btnViewHighscores);
            Name = "frmHomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnViewHighscores;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Label lblGeoQuizTitle;
        private System.Windows.Forms.Button btnStartSimpleQuiz;
        private System.Windows.Forms.Button btnStartComplexQuiz;
        private System.Windows.Forms.Button btnStartCustomQuiz;
        private System.Windows.Forms.TextBox txtName;
    }
}