using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPRobertoSanchez
{
    public partial class Form1 : Form
    {
        private IApiConnectionService apiConnection;
        private IWeatherService weatherService;
        private IWeatherHistoryService weatherHistoryService;
        public Form1(IApiConnectionService apiConnection, IWeatherService weatherService, IWeatherHistoryService weatherHistoryService)
        {
            InitializeComponent();
            this.apiConnection = apiConnection;
            this.weatherService = weatherService;
            this.weatherHistoryService = weatherHistoryService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCiudad.Text))
                {
                    throw new ArgumentException("No escribió el nombre de ninguna ciudad");
                }

                flowLayoutPanel1.Controls.Clear();
                for (int i = 0; i < 5; i++)
                {
                    DateTime dt = DateTime.Now.AddDays(-i);
                    long unix = ((DateTimeOffset)dt).ToUnixTimeSeconds();
                    //MessageBox.Show(unix.ToString());
                    WeatherConsult weatherhistory = apiConnection.GetWeather(txtCiudad.Text, unix);
                    //Weather w = weatherhistory.hourly.First().Weather[0];
                    Weather w = weatherhistory.current.Weather[0];
                    w.Temp = weatherhistory.current.Temp;
                    w.Dt = weatherhistory.current.Dt;
                    w.TimeZone = weatherhistory.Timezone;
                    weatherService.Add(w);

                    weatherHistoryService.Add(weatherhistory);
                    llenarFlp(w);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
        private void llenarFlp(Weather weather)
        {
            WeatherDescription weatherDescription = new WeatherDescription(weather);
            weatherDescription.ImageLocation = apiConnection.GetImage(weather);
            flowLayoutPanel1.Controls.Add(weatherDescription);
        }
        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Weather> weathers = weatherService.GetAll();
            foreach (Weather weather in weathers)
            {
                llenarFlp(weather);
            }
        }
    }
}
