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
        public string Description { get; set; }
        public string Main { get; set; }
        public string City { get; set; }
        public string ImageLocation { get; set; }
        public WeatherDescription()
        {
            InitializeComponent();
        }

        private void WeatherDescription_Load(object sender, EventArgs e)
        {
            lblCity.Text = City;
            lblDescription.Text = Description;
            lblMain.Text = Main;
            pictureBox1.ImageLocation = ImageLocation;
        }
    }
}
