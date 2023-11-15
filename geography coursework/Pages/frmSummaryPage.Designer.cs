namespace geography_coursework
{
    partial class frmSummaryPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnReturnToHomePage = new System.Windows.Forms.Button();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // btnReturnToHomePage
            // 
            btnReturnToHomePage.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnReturnToHomePage.Location = new System.Drawing.Point(259, 12);
            btnReturnToHomePage.Name = "btnReturnToHomePage";
            btnReturnToHomePage.Size = new System.Drawing.Size(254, 36);
            btnReturnToHomePage.TabIndex = 9;
            btnReturnToHomePage.Text = "back to student home page";
            btnReturnToHomePage.UseVisualStyleBackColor = true;
            btnReturnToHomePage.Click += btnReturnToHomePage_Click;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart.Legends.Add(legend2);
            chart.Location = new System.Drawing.Point(171, 54);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart.Series.Add(series2);
            chart.Size = new System.Drawing.Size(438, 384);
            chart.TabIndex = 10;
            chart.Text = "chart1";
            // 
            // frmSummaryPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(chart);
            Controls.Add(btnReturnToHomePage);
            Name = "frmSummaryPage";
            Text = "Settings Page";
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}