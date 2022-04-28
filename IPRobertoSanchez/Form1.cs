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
        public Form1(IApiConnectionService apiConnection, IWeatherService weatherService)
        {
            InitializeComponent();
            this.apiConnection = apiConnection;
            this.weatherService = weatherService;
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
                for (int i = 0; i < 5; i++)
                {
                    DateTime dt = DateTime.Now.AddDays(-i);
                    long unix = ((DateTimeOffset)dt).ToUnixTimeSeconds();
                    //MessageBox.Show(unix.ToString());
                    WeatherHistory weatherhistory = apiConnection.GetWeather(txtCiudad.Text, unix);
                    //Weather w = weatherhistory.hourly[6].Weather[0];
                    Weather w = weatherhistory.hourly.First().Weather[0];
                    w.TimeZone = weatherhistory.Timezone;
                    weatherService.Add(w);
                    MessageBox.Show("Exito");
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
            WeatherDescription weatherDescription = new WeatherDescription();
            weatherDescription.City = weather.TimeZone;
            weatherDescription.Main = weather.Main;
            weatherDescription.Description = weather.Description;
            weatherDescription.ImageLocation = apiConnection.GetImage(weather);
            flowLayoutPanel1.Controls.Add(weatherDescription);
        }
        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
