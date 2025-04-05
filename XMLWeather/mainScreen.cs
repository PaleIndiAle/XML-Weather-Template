using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class mainScreen : UserControl
    {
        public static string cityName = "Stratford,CA";

        public mainScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }
        public void DisplayCurrent()
        {
            cityLabel.Text = $"{Form1.days[0].location}";
            dateLabel.Text = $"{Form1.days[0].date}";
            maxLabel.Text = $"{Form1.days[0].tempHigh}*C";
            minLabel.Text = $"{Form1.days[0].tempLow}*C";
            currentLabel.Text = $"{Form1.days[0].currentTemp}*C";
            conditionLabel.Text = $"{Form1.days[0].condition}";

            dateLabel2.Text = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            dateLabel3.Text = DateTime.Now.AddDays(2).DayOfWeek.ToString();
            dateLabel4.Text = DateTime.Now.AddDays(3).DayOfWeek.ToString();
            dateLabel5.Text = DateTime.Now.AddDays(4).DayOfWeek.ToString();
            dateLabel6.Text = DateTime.Now.AddDays(5).DayOfWeek.ToString();

            conditionLabel2.Text = $"{Form1.days[1].condition}";
            conditionLabel3.Text = $"{Form1.days[2].condition}";
            conditionLabel4.Text = $"{Form1.days[3].condition}";
            conditionLabel5.Text = $"{Form1.days[4].condition}";
            conditionLabel6.Text = $"{Form1.days[5].condition}";

            highestTempLabel.Text = $"{Form1.days[1].tempHigh}*C";
            highestTempLabel1.Text = $"{Form1.days[2].tempHigh}*C";
            highestTempLabel2.Text = $"{Form1.days[3].tempHigh}*C";
            highestTempLabel3.Text = $"{Form1.days[4].tempHigh}*C";
            highestTempLabel4.Text = $"{Form1.days[5].tempHigh}*C";

            lowestTempLabel.Text = $"{Form1.days[1].tempLow}*C";
            lowestTempLabel1.Text = $"{Form1.days[2].tempLow}*C";
            lowestTempLabel2.Text = $"{Form1.days[3].tempLow}*C";
            lowestTempLabel3.Text = $"{Form1.days[4].tempLow}*C";
            lowestTempLabel4.Text = $"{Form1.days[5].tempLow}*C";
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            searchBox.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                cityName = $"{searchBox.Text}";
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
                DisplayCurrent();

                Refresh();
            }
            catch
            {
                searchBox.Text = "Error, try 'Stratford,CA' ";
            }
        }
    }
}
