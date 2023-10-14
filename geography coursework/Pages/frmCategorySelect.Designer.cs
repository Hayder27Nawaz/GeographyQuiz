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
            this.label1 = new System.Windows.Forms.Label();
            this.listTopics = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your category";
            // 
            // listTopics
            // 
            this.listTopics.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.listTopics.ForeColor = System.Drawing.Color.ForestGreen;
            this.listTopics.FormattingEnabled = true;
            this.listTopics.ItemHeight = 34;
            this.listTopics.Items.AddRange(new object[] {
            "3.1.1 Section A: The challenge of natural hazards",
            "3.1.2 Section B: The living world",
            "3.1.3 Section C: Physical landscapes in the UK",
            "3.2.1 Section A: Urban issues and challenges",
            "3.2.2 Section B: The changing economic world",
            "3.2.3 Section C: The challenge of resource management"});
            this.listTopics.Location = new System.Drawing.Point(61, 167);
            this.listTopics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listTopics.Name = "listTopics";
            this.listTopics.Size = new System.Drawing.Size(675, 208);
            this.listTopics.TabIndex = 5;
            // 
            // frmCategorySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listTopics);
            this.Controls.Add(this.label1);
            this.Name = "frmCategorySelect";
            this.Text = "Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTopics;
    }
}