
namespace coursework_geography_quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CONTINUE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CONTINUE
            // 
            this.CONTINUE.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CONTINUE.ForeColor = System.Drawing.SystemColors.Window;
            this.CONTINUE.Location = new System.Drawing.Point(229, 258);
            this.CONTINUE.Name = "CONTINUE";
            this.CONTINUE.Size = new System.Drawing.Size(326, 133);
            this.CONTINUE.TabIndex = 0;
            this.CONTINUE.Text = "CONTINUE";
            this.CONTINUE.UseVisualStyleBackColor = true;
            this.CONTINUE.Click += new System.EventHandler(this.CONTINUE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CONTINUE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CONTINUE;
    }
}

