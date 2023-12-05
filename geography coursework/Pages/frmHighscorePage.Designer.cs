using System.Windows.Forms;

namespace geography_coursework
{
    partial class frmHighscorePage
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
            dgvHighscores = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            btnReturnToHome = new Button();
            lblErrorMessage = new Label();
            btnReturnToHomePage = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHighscores).BeginInit();
            SuspendLayout();
            // 
            // dgvHighscores
            // 
            dgvHighscores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHighscores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHighscores.Columns.AddRange(new DataGridViewColumn[] { Id, Username, Type, Score, Date });
            dgvHighscores.Location = new System.Drawing.Point(13, 56);
            dgvHighscores.Margin = new Padding(4, 5, 4, 5);
            dgvHighscores.Name = "dgvHighscores";
            dgvHighscores.RowHeadersWidth = 62;
            dgvHighscores.RowTemplate.Height = 25;
            dgvHighscores.Size = new System.Drawing.Size(774, 380);
            dgvHighscores.TabIndex = 0;
            dgvHighscores.CellDoubleClick += dgvHighscores_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "#";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Username
            // 
            Username.HeaderText = "Name";
            Username.MinimumWidth = 8;
            Username.Name = "Username";
            Username.ReadOnly = true;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 8;
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.MinimumWidth = 8;
            Score.Name = "Score";
            Score.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // btnReturnToHome
            // 
            btnReturnToHome.Location = new System.Drawing.Point(877, 653);
            btnReturnToHome.Margin = new Padding(4, 5, 4, 5);
            btnReturnToHome.Name = "btnReturnToHome";
            btnReturnToHome.Size = new System.Drawing.Size(249, 77);
            btnReturnToHome.TabIndex = 1;
            btnReturnToHome.Text = "Back";
            btnReturnToHome.UseVisualStyleBackColor = true;
            btnReturnToHome.Click += btnReturnToHome_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            lblErrorMessage.Location = new System.Drawing.Point(17, 672);
            lblErrorMessage.Margin = new Padding(4, 0, 4, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new System.Drawing.Size(178, 32);
            lblErrorMessage.TabIndex = 2;
            lblErrorMessage.Text = "Error Message";
            // 
            // btnReturnToHomePage
            // 
            btnReturnToHomePage.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReturnToHomePage.ForeColor = System.Drawing.Color.Green;
            btnReturnToHomePage.Location = new System.Drawing.Point(259, 12);
            btnReturnToHomePage.Name = "btnReturnToHomePage";
            btnReturnToHomePage.Size = new System.Drawing.Size(254, 36);
            btnReturnToHomePage.TabIndex = 10;
            btnReturnToHomePage.Text = "back to student home page";
            btnReturnToHomePage.UseVisualStyleBackColor = true;
            btnReturnToHomePage.Click += btnReturnToHomePage_Click;
            // 
            // frmHighscorePage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Lime;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnReturnToHomePage);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnReturnToHome);
            Controls.Add(dgvHighscores);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHighscorePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Highscores";
            ((System.ComponentModel.ISupportInitialize)dgvHighscores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHighscores;
        private Button btnReturnToHome;
        private Label lblErrorMessage;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Date;
        private Button btnReturnToHomePage;
    }
}