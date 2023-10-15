
namespace geography_coursework
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.listTopics = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(114, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "PICK YOUR SUBJECT!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Subjectchooser);
            // 
            // listTopics
            // 
            this.listTopics.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listTopics.ForeColor = System.Drawing.Color.ForestGreen;
            this.listTopics.FormattingEnabled = true;
            this.listTopics.ItemHeight = 29;
            this.listTopics.Items.AddRange(new object[] {
            "3.1.1 Section A: The challenge of natural hazards",
            "3.1.2 Section B: The living world",
            "3.1.3 Section C: Physical landscapes in the UK",
            "3.2.1 Section A: Urban issues and challenges",
            "3.2.2 Section B: The changing economic world",
            "3.2.3 Section C: The challenge of resource management"});
            this.listTopics.Location = new System.Drawing.Point(101, 194);
            this.listTopics.Name = "listTopics";
            this.listTopics.Size = new System.Drawing.Size(598, 178);
            this.listTopics.TabIndex = 4;
            this.listTopics.Click += new System.EventHandler(this.TopicSelected);
            this.listTopics.SelectedIndexChanged += new System.EventHandler(this.TopicSelected);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::geography_coursework.Properties.Resources.savannah_transition;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTopics);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TopicSelected);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTopics;
    }
}