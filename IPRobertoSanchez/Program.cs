using AppCore.Interfaces;
using AppCore.Services;
using Autofac;
using Domain.interfaces;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPRobertoSanchez
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterType<ApiConnection>().As<IApiConnection>();
            builder.RegisterType<ApiConnectionService>().As<IApiConnectionService>();
            var container = builder.Build();

            Application.Run(new Form1(container.Resolve<IApiConnectionService>()));
        }
    }
}
