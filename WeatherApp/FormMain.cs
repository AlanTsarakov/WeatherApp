using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;

namespace WeatherApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            WeatherService weatherService = new WeatherService("ключ");
            var weather = weatherService.GetWeather(textBoxCity.Text);
            labelWeatherInfo.Text = weather.Name + " " + weather.Main.Temp + " " + weather.Weather[0].Description;
        }
    }
}
