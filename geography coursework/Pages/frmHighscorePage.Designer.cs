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
            this.dgvHighscores = new System.Windows.Forms.DataGridView();
            this.btnReturnToHome = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHighscores
            // 
            this.dgvHighscores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHighscores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHighscores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Type,
            this.Score,
            this.Date});
            this.dgvHighscores.Location = new System.Drawing.Point(12, 12);
            this.dgvHighscores.Name = "dgvHighscores";
            this.dgvHighscores.RowTemplate.Height = 25;
            this.dgvHighscores.Size = new System.Drawing.Size(776, 374);
            this.dgvHighscores.TabIndex = 0;
            this.dgvHighscores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHighscores_CellDoubleClick);
            // 
            // btnReturnToHome
            // 
            this.btnReturnToHome.Location = new System.Drawing.Point(614, 392);
            this.btnReturnToHome.Name = "btnReturnToHome";
            this.btnReturnToHome.Size = new System.Drawing.Size(174, 46);
            this.btnReturnToHome.TabIndex = 1;
            this.btnReturnToHome.Text = "Back";
            this.btnReturnToHome.UseVisualStyleBackColor = true;
            this.btnReturnToHome.Click += new System.EventHandler(this.btnReturnToHome_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(12, 403);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(117, 21);
            this.lblErrorMessage.TabIndex = 2;
            this.lblErrorMessage.Text = "Error Message";
            // 
            // Id
            // 
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Name";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // frmHighscorePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnReturnToHome);
            this.Controls.Add(this.dgvHighscores);
            this.Name = "frmHighscorePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHighscores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}