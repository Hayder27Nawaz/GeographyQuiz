using geography_coursework.Models;
using geography_coursework.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace geography_coursework
{
    public partial class frmQuizSetUp : Form
    {
        private string _categoryName;

        public frmQuizSetUp(string categoryName)
        {
            InitializeComponent();
            _categoryName = categoryName;
            
            List<QuizQuestion> quizQuestions = new FileService().GetQuestions();
        }

    }
}
