
using System;

namespace geography_coursework
{
    partial class QuizPage
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
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.questionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.Color.Gold;
            this.buttonD.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.buttonD.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonD.Location = new System.Drawing.Point(677, 535);
            this.buttonD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(449, 167);
            this.buttonD.TabIndex = 0;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Gold;
            this.buttonC.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.buttonC.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonC.Location = new System.Drawing.Point(17, 535);
            this.buttonC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(449, 167);
            this.buttonC.TabIndex = 1;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonB
            // 
            this.buttonB.BackColor = System.Drawing.Color.Gold;
            this.buttonB.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.buttonB.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonB.Location = new System.Drawing.Point(677, 358);
            this.buttonB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(449, 167);
            this.buttonB.TabIndex = 2;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = false;
            //this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.Gold;
            this.buttonA.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.buttonA.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonA.Location = new System.Drawing.Point(17, 358);
            this.buttonA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(449, 167);
            this.buttonA.TabIndex = 3;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = false;
            //this.buttonA.Click += new System.EventHandler(this.button4_Click);
            // 
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.BackColor = System.Drawing.Color.Lime;
            this.questionlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questionlabel.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.questionlabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.questionlabel.Location = new System.Drawing.Point(260, 70);
            this.questionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(645, 203);
            this.questionlabel.TabIndex = 5;
            this.questionlabel.Text = "question";
            //this.questionlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::geography_coursework.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.questionlabel);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonD);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QuizPage";
            this.Text = "QuizPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Label questionlabel;
    }
}