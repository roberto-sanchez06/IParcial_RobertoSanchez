using Infraestructure;
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

        private HttpApiConection conection;
        public Form1()
        {
            conection = new HttpApiConection();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
