namespace geography_coursework
{
    partial class frmPreviousQuizResults
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
            btnReturnToHomePage = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnReturnToHomePage
            // 
            btnReturnToHomePage.Location = new System.Drawing.Point(258, 12);
            btnReturnToHomePage.Name = "btnReturnToHomePage";
            btnReturnToHomePage.Size = new System.Drawing.Size(254, 45);
            btnReturnToHomePage.TabIndex = 8;
            btnReturnToHomePage.Text = "back to student home page";
            btnReturnToHomePage.UseVisualStyleBackColor = true;
            btnReturnToHomePage.Click += btnReturnToHomePage_Click;
            // 
            // frmPreviousQuizResults
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnReturnToHomePage);
            Name = "frmPreviousQuizResults";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnReturnToHomePage;
    }
}