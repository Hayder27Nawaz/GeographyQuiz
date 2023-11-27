using System.Drawing;
using System.Windows.Forms;

namespace geography_coursework.Pages
{
    partial class frmCustomSettingsPage
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
            clbCategories = new CheckedListBox();
            lblSelectCategoryMessage = new Label();
            lblSelectTimerMessage = new Label();
            btnTimer10 = new Button();
            btnTimer20 = new Button();
            btnTimerUnlimited = new Button();
            btnQuestions10 = new Button();
            lblSelectNumberOfQuestionsMessage = new Label();
            btnQuestions20 = new Button();
            btnQuestions50 = new Button();
            btnStart = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // clbCategories
            // 
            clbCategories.CheckOnClick = true;
            clbCategories.FormattingEnabled = true;
            clbCategories.Items.AddRange(new object[] { "Premier League", "Championship", "League One", "League Two" });
            clbCategories.Location = new Point(12, 37);
            clbCategories.Name = "clbCategories";
            clbCategories.Size = new Size(776, 76);
            clbCategories.TabIndex = 1;
            // 
            // lblSelectCategoryMessage
            // 
            lblSelectCategoryMessage.AutoSize = true;
            lblSelectCategoryMessage.Location = new Point(12, 9);
            lblSelectCategoryMessage.Name = "lblSelectCategoryMessage";
            lblSelectCategoryMessage.Size = new Size(98, 15);
            lblSelectCategoryMessage.TabIndex = 2;
            lblSelectCategoryMessage.Text = "Select categories:";
            // 
            // lblSelectTimerMessage
            // 
            lblSelectTimerMessage.AutoSize = true;
            lblSelectTimerMessage.Location = new Point(12, 147);
            lblSelectTimerMessage.Name = "lblSelectTimerMessage";
            lblSelectTimerMessage.Size = new Size(116, 15);
            lblSelectTimerMessage.TabIndex = 3;
            lblSelectTimerMessage.Text = "Select timer settings:";
            // 
            // btnTimer10
            // 
            btnTimer10.Location = new Point(12, 165);
            btnTimer10.Name = "btnTimer10";
            btnTimer10.Size = new Size(244, 90);
            btnTimer10.TabIndex = 4;
            btnTimer10.Text = "10";
            btnTimer10.UseVisualStyleBackColor = true;
            btnTimer10.Click += btnTimer10_Click;
            // 
            // btnTimer20
            // 
            btnTimer20.Location = new Point(262, 165);
            btnTimer20.Name = "btnTimer20";
            btnTimer20.Size = new Size(249, 90);
            btnTimer20.TabIndex = 5;
            btnTimer20.Text = "20";
            btnTimer20.UseVisualStyleBackColor = true;
            btnTimer20.Click += btnTimer20_Click;
            // 
            // btnTimerUnlimited
            // 
            btnTimerUnlimited.Location = new Point(517, 165);
            btnTimerUnlimited.Name = "btnTimerUnlimited";
            btnTimerUnlimited.Size = new Size(271, 90);
            btnTimerUnlimited.TabIndex = 6;
            btnTimerUnlimited.Text = "Unlimited";
            btnTimerUnlimited.UseVisualStyleBackColor = true;
            btnTimerUnlimited.Click += btnTimerUnlimited_Click;
            // 
            // btnQuestions10
            // 
            btnQuestions10.Location = new Point(12, 289);
            btnQuestions10.Name = "btnQuestions10";
            btnQuestions10.Size = new Size(244, 90);
            btnQuestions10.TabIndex = 7;
            btnQuestions10.Text = "10";
            btnQuestions10.UseVisualStyleBackColor = true;
            btnQuestions10.Click += btnQuestions10_Click;
            // 
            // lblSelectNumberOfQuestionsMessage
            // 
            lblSelectNumberOfQuestionsMessage.AutoSize = true;
            lblSelectNumberOfQuestionsMessage.Location = new Point(12, 271);
            lblSelectNumberOfQuestionsMessage.Name = "lblSelectNumberOfQuestionsMessage";
            lblSelectNumberOfQuestionsMessage.Size = new Size(154, 15);
            lblSelectNumberOfQuestionsMessage.TabIndex = 8;
            lblSelectNumberOfQuestionsMessage.Text = "Select number of questions:";
            // 
            // btnQuestions20
            // 
            btnQuestions20.Location = new Point(262, 289);
            btnQuestions20.Name = "btnQuestions20";
            btnQuestions20.Size = new Size(249, 90);
            btnQuestions20.TabIndex = 9;
            btnQuestions20.Text = "20";
            btnQuestions20.UseVisualStyleBackColor = true;
            btnQuestions20.Click += btnQuestions20_Click;
            // 
            // btnQuestions50
            // 
            btnQuestions50.Location = new Point(517, 289);
            btnQuestions50.Name = "btnQuestions50";
            btnQuestions50.Size = new Size(271, 90);
            btnQuestions50.TabIndex = 10;
            btnQuestions50.Text = "30";
            btnQuestions50.UseVisualStyleBackColor = true;
            btnQuestions50.Click += btnQuestions50_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 192, 0);
            btnStart.Location = new Point(392, 385);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(396, 53);
            btnStart.TabIndex = 11;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Red;
            btnBack.Location = new Point(12, 385);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(374, 53);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frmCustomSettingsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnStart);
            Controls.Add(btnQuestions50);
            Controls.Add(btnQuestions20);
            Controls.Add(lblSelectNumberOfQuestionsMessage);
            Controls.Add(btnQuestions10);
            Controls.Add(btnTimerUnlimited);
            Controls.Add(btnTimer20);
            Controls.Add(btnTimer10);
            Controls.Add(lblSelectTimerMessage);
            Controls.Add(lblSelectCategoryMessage);
            Controls.Add(clbCategories);
            Name = "frmCustomSettingsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clbCategories;
        private Label lblSelectCategoryMessage;
        private Label lblSelectTimerMessage;
        private Button btnTimer10;
        private Button btnTimer20;
        private Button btnTimerUnlimited;
        private Button btnQuestions10;
        private Label lblSelectNumberOfQuestionsMessage;
        private Button btnQuestions20;
        private Button btnQuestions50;
        private Button btnStart;
        private Button btnBack;
    }
}