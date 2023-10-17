
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
            buttonD = new System.Windows.Forms.Button();
            buttonC = new System.Windows.Forms.Button();
            buttonB = new System.Windows.Forms.Button();
            buttonA = new System.Windows.Forms.Button();
            questionlabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // buttonD
            // 
            buttonD.BackColor = System.Drawing.Color.Gold;
            buttonD.Cursor = System.Windows.Forms.Cursors.PanSE;
            buttonD.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            buttonD.Location = new System.Drawing.Point(677, 535);
            buttonD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonD.Name = "buttonD";
            buttonD.Size = new System.Drawing.Size(449, 167);
            buttonD.TabIndex = 0;
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = false;
            buttonD.Click += button1_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = System.Drawing.Color.Gold;
            buttonC.Cursor = System.Windows.Forms.Cursors.PanSW;
            buttonC.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            buttonC.Location = new System.Drawing.Point(17, 535);
            buttonC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonC.Name = "buttonC";
            buttonC.Size = new System.Drawing.Size(449, 167);
            buttonC.TabIndex = 1;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = false;
            // 
            // buttonB
            // 
            buttonB.BackColor = System.Drawing.Color.Gold;
            buttonB.Cursor = System.Windows.Forms.Cursors.PanNE;
            buttonB.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            buttonB.Location = new System.Drawing.Point(677, 358);
            buttonB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonB.Name = "buttonB";
            buttonB.Size = new System.Drawing.Size(449, 167);
            buttonB.TabIndex = 2;
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = false;
            // 
            // buttonA
            // 
            buttonA.BackColor = System.Drawing.Color.Gold;
            buttonA.Cursor = System.Windows.Forms.Cursors.PanNW;
            buttonA.Font = new System.Drawing.Font("Comic Sans MS", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            buttonA.Location = new System.Drawing.Point(17, 358);
            buttonA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonA.Name = "buttonA";
            buttonA.Size = new System.Drawing.Size(449, 167);
            buttonA.TabIndex = 3;
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = false;
            // 
            // questionlabel
            // 
            questionlabel.AutoSize = true;
            questionlabel.BackColor = System.Drawing.Color.Lime;
            questionlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            questionlabel.Cursor = System.Windows.Forms.Cursors.HSplit;
            questionlabel.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            questionlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            questionlabel.Location = new System.Drawing.Point(260, 70);
            questionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            questionlabel.Name = "questionlabel";
            questionlabel.Size = new System.Drawing.Size(645, 203);
            questionlabel.TabIndex = 5;
            questionlabel.Text = "question";
            questionlabel.Click += questionlabel_Click;
            // 
            // QuizPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(1143, 750);
            Controls.Add(questionlabel);
            Controls.Add(buttonA);
            Controls.Add(buttonB);
            Controls.Add(buttonC);
            Controls.Add(buttonD);
            Cursor = System.Windows.Forms.Cursors.NoMove2D;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "QuizPage";
            Text = "QuizPage";
            ResumeLayout(false);
            PerformLayout();
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