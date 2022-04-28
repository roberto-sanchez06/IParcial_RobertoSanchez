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
    public partial class WeatherDescription : UserControl
    {
        public string ImageLocation { get; set; }
        private Weather weather1;
        public WeatherDescription(Weather weather)
        {
            InitializeComponent();
            this.weather1 = weather;
        }

        private void WeatherDescription_Load(object sender, EventArgs e)
        {
            lblCity.Text = weather1.TimeZone;
            lblDescription.Text = weather1.Description;
            lblMain.Text = weather1.Main;
            pictureBox1.ImageLocation = ImageLocation;
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(weather1.Dt).ToLocalTime();
            lblDt.Text = day.ToShortDateString();
            lblTemp.Text = weather1.Temp.ToString() + " C";
        }
    }
}
