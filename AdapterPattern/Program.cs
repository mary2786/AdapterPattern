using Microsoft.Extensions.DependencyInjection;
using System;

namespace AdapterPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Con el primer servicio que indica el ejercicio
            /*IServiceProvider serviceProvider = new ServiceCollection()
           .AddSingleton<ISucursalListService, SucursalListService>()
           .AddSingleton<ISucursalService, SucursalService>()
           .BuildServiceProvider();*/

            //Con el adaptador para utilizar el segundo servicio que indica el ejercicio
            IServiceProvider serviceProvider = new ServiceCollection()
           .AddSingleton<ISucursalJsonService, SucursalJsonService>()
           .AddSingleton<ISucursalListService, SucursalAdapter>()
           .AddSingleton<ISucursalService, SucursalService>()
           .BuildServiceProvider();

            ISucursalService sucursalService = serviceProvider.GetService<ISucursalService>();
            sucursalService.PrintSucursales();
        }
    }
}
