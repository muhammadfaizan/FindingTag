using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Threading;
using System.Windows.Media;

namespace FindingTag
{
    public partial class LandScape : PhoneApplicationPage
    {
        int count, timeCount;
        DispatcherTimer dispatcherTimer;
        public LandScape()
        {
            InitializeComponent();
            Logic.Score = 0;
            count = 0;
        }
        Random R = new Random();


        void countDown()
        {
            timeCount = 60;
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1000);
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        }

        void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (count == 0)
            {
                dispatcherTimer.Stop();
                NavigationService.Navigate(new Uri("/Result.xaml",UriKind.Relative));

            }
            Time.Text = "Remaining Time : " + timeCount;
            timeCount--;
        }
        void location()
        {
            int X1 = R.Next(3, 320);
            int Y1 = R.Next(3, 470);
            int X2 = R.Next(3, 320);
            int Y2 = R.Next(3, 470);
            int X3 = R.Next(3, 320);
            int Y3 = R.Next(3, 470);
            int X4 = R.Next(3, 320);
            int Y4 = R.Next(3, 470);
            int X5 = R.Next(3, 320);
            int Y5 = R.Next(3, 470);
            int X6 = R.Next(3, 320);
            int Y6 = R.Next(3, 470);
            int X7 = R.Next(3, 320);
            int Y7 = R.Next(3, 470);
            int X8 = R.Next(3, 320);
            int Y8 = R.Next(3, 470);

            I1.Margin = new Thickness(X1, Y1, 0, 0);
            I2.Margin = new Thickness(X2, Y2,0, 0);
            I3.Margin = new Thickness(X3, Y3, 0, 0);
            I4.Margin = new Thickness(X4, Y4, 0, 0);
            I5.Margin = new Thickness(X5, Y5, 0, 0);
            I6.Margin = new Thickness(X6, Y6, 0, 0);
            I7.Margin = new Thickness(X7, Y7, 0, 0);
            I8.Margin = new Thickness(X8, Y8, 0, 0);
        }

        private void I1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I1.Visibility = Visibility.Collapsed;
            _01.Visibility = Visibility.Collapsed;
            soundStart("Button.mp3");
            countI();
        }

        private void I2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I2.Visibility = Visibility.Collapsed;
            _02.Visibility = Visibility.Collapsed;
            countI();
            soundStart("Button.mp3");
        }

        private void I3_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I3.Visibility = Visibility.Collapsed;
            _03.Visibility = Visibility.Collapsed;
            countI();
            soundStart("Button.mp3");
        }

        private void I4_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I4.Visibility = Visibility.Collapsed;
            _04.Visibility = Visibility.Collapsed;
            soundStart("Button.mp3");
            countI();
        }

        private void I5_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I5.Visibility = Visibility.Collapsed;
            _05.Visibility = Visibility.Collapsed;
            countI();
            soundStart("Button.mp3");
        }

        private void I6_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I6.Visibility = Visibility.Collapsed;
            _06.Visibility = Visibility.Collapsed;
            countI();
            soundStart("Button.mp3");
        }

        private void I7_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I7.Visibility = Visibility.Collapsed;
            _07.Visibility = Visibility.Collapsed;
            countI();
            soundStart("Button.mp3");
        }

        private void I8_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            I8.Visibility = Visibility.Collapsed;
            _08.Visibility = Visibility.Collapsed;
            countI();
            soundStart("Button.mp3");
        }

        void countI()
        {
            count++;
            Logic.Score += 10;
            

            if (count == 8)
            {
                NavigationService.Navigate(new Uri("/Result.xaml", UriKind.Relative)); 
            }
        }

        void soundStart(string name)
        {
            mediaElement1.Source= new Uri("Audio/"+name,UriKind.Relative);
            mediaElement1.Volume = 0.8;
            mediaElement1.Play();
        }
    }
}