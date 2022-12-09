using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace NewKapcha.Pages
{
    public partial class CapchaPage : Page
    {
        int currentRandom = 0;
        int currentTry = 0;
        int firstTryTimer = 10;
        int secondTryTimer = 30;
        int waiting = 0;

        public CapchaPage()
        {
            InitializeComponent();

            Core.Capchas.Add(new CapchaImages(1, "https://imgur.com/qAqQvuI.png", "Ax4d98"));
            Core.Capchas.Add(new CapchaImages(2, "https://imgur.com/aBToNHy.png", "23df345"));
            Core.Capchas.Add(new CapchaImages(3, "https://imgur.com/vE5Hjjl.png", "d44f"));

            SetTimer();
            UpdateCapcha();
        }

        private void ConfirmBTN_Click(object sender, RoutedEventArgs e)
        {
            if(CapchaBox.Text == Core.Capchas[currentRandom].CapchaText)
            {
                Core.mainWindow.MainFrame.Navigate(new Pages.UserPage());
            }
            else
            {
                CapchaBox.Text = "";
                MessageBox.Show("Проверьте капчу");
                currentTry++;
                currentRandom = 0;
                UpdateCapcha();
            }
        }

        void UpdateCapcha()
        {
            if(currentTry == 0)
            {
                waiting = 0;
            }
            else if(currentTry == 1)
            {
                waiting = firstTryTimer;
            }
            else
            {
                waiting = secondTryTimer;
            }
            Random rnd = new Random();
            currentRandom = rnd.Next(1, 3);

            ImagePlace.Source = new BitmapImage(new Uri(Core.Capchas[currentRandom].Link, UriKind.Absolute));

            ConfirmBTN.IsEnabled = false;
        }

        void SetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimerTick;
            timer.Start();
        }

        void TimerTick(object sender, EventArgs e)
        {
            if(waiting == 0)
            {
                CapchaTimerLabel.Content = "0";
                ConfirmBTN.IsEnabled = true;
            }
            else
            {
                CapchaTimerLabel.Content = waiting--;
                ConfirmBTN.IsEnabled = false;
            }
        }
    }
}
