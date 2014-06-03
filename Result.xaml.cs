using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace FindingTag
{
    public partial class Result : PhoneApplicationPage
    {
        public Result()
        {
            InitializeComponent();
            ScoreBox.Text = "Your Score is" + Logic.Score.ToString();
        }
    }
}