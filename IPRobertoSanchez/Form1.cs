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
        public Form1(IApiConnectionService apiConnection)
        {
            InitializeComponent();
            this.apiConnection = apiConnection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2022,4,22);
            long unix = ((DateTimeOffset)dt).ToUnixTimeSeconds();
            MessageBox.Show(unix.ToString());

            WeatherForecast wf = apiConnection.GetWeather("Managua", unix);

            if (wf != null)
            {
                MessageBox.Show("Exitoso");
            }
            MessageBox.Show("Test");

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
