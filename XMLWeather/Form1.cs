using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            mainScreen ms = new mainScreen();
            this.Controls.Add(ms);
        }

        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={mainScreen.cityName}&mode=xml&units=metric&cnt=8&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //create a day object
                Day d = new Day(); 

                //TODO: Find the time element and get the day attribute
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                //TODO: Find the temperature element and get the min and max attributes
                reader.ReadToFollowing("temperature");
                string lowtemp = reader.GetAttribute("min");
                double templow = Convert.ToDouble(lowtemp);
                d.tempLow = $"{templow.ToString("#")}";

                string hightemp = reader.GetAttribute("max");
                double temphigh = Convert.ToDouble(hightemp);
                d.tempHigh = $"{temphigh.ToString("#")}";

                //TODO: Find the cloud condition
                reader.ReadToFollowing("clouds");
                d.condition = reader.GetAttribute("value");

                //TODO: Add day to list of days
                days.Add(d);
            }
        }
        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={mainScreen.cityName}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            string current = reader.GetAttribute("value");
            double currenttemp = Convert.ToDouble(current);
            days[0].currentTemp = $"{currenttemp.ToString("#")}";
        }
    }
}
