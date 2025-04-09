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
using System.Media;

namespace XMLWeather
{
    public partial class mainScreen : UserControl
    {
        public static string cityName = "Stratford,CA";
        public static List<PictureBox> picList = new List<PictureBox>();
        public mainScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }
        public void DisplayCurrent()
        {
            picList.Add(weatherPicture);
            picList.Add(weatherPicture2);
            picList.Add(weatherPicture3);
            picList.Add(weatherPicture4);
            picList.Add(weatherPicture5);
            picList.Add(weatherPicture6);

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

            if (Form1.days[0].conditionID >= 200 && Form1.days[0].conditionID <= 232)
            {
                this.BackColor = Color.Gray;
            }
            else if (Form1.days[0].conditionID >= 300 && Form1.days[0].conditionID <= 321 || Form1.days[0].conditionID >= 520 && Form1.days[0].conditionID <= 531)
            {
                this.BackColor = Color.LightBlue;
            }
            else if (Form1.days[0].conditionID >= 500 && Form1.days[0].conditionID <= 504)
            {
                this.BackColor = Color.Blue;
            }
            else if (Form1.days[0].conditionID == 511 || Form1.days[0].conditionID >= 600 && Form1.days[0].conditionID <= 622)
            {
                this.BackColor = Color.WhiteSmoke;
            }
            else if (Form1.days[0].conditionID >= 701 && Form1.days[0].conditionID <= 781)
            {
                this.BackColor = Color.DimGray;
            }
            else if (Form1.days[0].conditionID == 800)
            {
                this.BackColor = Color.White;
            }
            else if (Form1.days[0].conditionID == 801)
            {
                this.BackColor = Color.LightSlateGray;
            }
            else if (Form1.days[0].conditionID == 802)
            {
                this.BackColor = Color.SlateGray;
            }
            else if (Form1.days[0].conditionID >= 803 && Form1.days[0].conditionID <= 804)
            {
                this.BackColor = Color.DarkSlateGray;
            }

            for (int i = 0; i < Form1.days.Count -1; i++)
            {
                if (Form1.days[i].conditionID >= 200 && Form1.days[i].conditionID <= 232)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._11d;
                }
                else if (Form1.days[i].conditionID >= 300 && Form1.days[i].conditionID <= 321 || Form1.days[i].conditionID >= 520 && Form1.days[i].conditionID <= 531)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._09d;
                }
                else if (Form1.days[i].conditionID >= 500 && Form1.days[i].conditionID <= 504)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._10d;
                }
                else if (Form1.days[i].conditionID == 511 || Form1.days[i].conditionID >= 600 && Form1.days[i].conditionID <= 622)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._13d;
                }
                else if (Form1.days[i].conditionID >= 701 && Form1.days[i].conditionID <= 781)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._50d;
                }
                else if (Form1.days[i].conditionID == 800)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._01d;
                }
                else if (Form1.days[i].conditionID == 801)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._02d;
                }
                else if (Form1.days[i].conditionID == 802)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._03d;
                }
                else if (Form1.days[i].conditionID >= 803 && Form1.days[i].conditionID <= 804)
                {
                    picList[i].Image = XMLWeather.Properties.Resources._04d;
                }
            }
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
