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
