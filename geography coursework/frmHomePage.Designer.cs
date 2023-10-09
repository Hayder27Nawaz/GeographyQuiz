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
            this.btnLogSignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogSignIn
            // 
            this.btnLogSignIn.Location = new System.Drawing.Point(310, 116);
            this.btnLogSignIn.Name = "btnLogSignIn";
            this.btnLogSignIn.Size = new System.Drawing.Size(112, 34);
            this.btnLogSignIn.TabIndex = 0;
            this.btnLogSignIn.Text = "Log/Sign in";
            this.btnLogSignIn.UseVisualStyleBackColor = true;
            this.btnLogSignIn.Click += new System.EventHandler(this.btnLogSignIn_Click);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogSignIn);
            this.Name = "frmHomePage";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogSignIn;
    }
}