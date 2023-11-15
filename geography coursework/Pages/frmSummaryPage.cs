using geography_coursework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace geography_coursework
{
    public partial class frmSummaryPage : Form
    {
        private readonly DataStoreService _dataService;

        private const string CorrectSeries = "Correct";
        private const string IncorrectSeries = "Incorrect";

        private Dictionary<string, int> _lookup = new()
        {
            { "Premier League", 0 },
            { "Championship", 1 },
            { "League One", 2 },
            { "League Two", 3 },
        };

        public frmSummaryPage()
        {
            _dataService = new DataStoreService();

            InitializeComponent();

            BindChartData();
        }

        private void BindChartData()
        {
            var leagueResults = _dataService.GetChartDetails();

            chart.Titles.Clear();
            chart.Series.Clear();

            chart.Titles.Add("Answers per league (0=Prem, 1=Champ, 2=League One, 3=League Two)");

            chart.Series.Add(AddSeries(CorrectSeries, Color.Green));
            chart.Series.Add(AddSeries(IncorrectSeries, Color.Red));

            foreach (var result in leagueResults)
            {
                chart.Series[CorrectSeries].Points.Add(new DataPoint(_lookup[result.League], result.Correct));
                chart.Series[IncorrectSeries].Points.Add(new DataPoint(_lookup[result.League], result.Incorrect));
            }
        }

        private Series AddSeries(string name, Color color)
        {
            return new Series
            {
                Name = name,
                ChartType = SeriesChartType.StackedColumn,
                Color = color,
                IsValueShownAsLabel = true
            };
        }

        private void btnReturnToHomePage_Click(object sender, EventArgs e)
        {
            frmHomePage newForm = new frmHomePage();
            newForm.Show();
            this.Hide();
        }
    }
}
