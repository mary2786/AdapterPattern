using System;

namespace AdapterPattern
{
    public class SucursalService : ISucursalService
    {
        private readonly ISucursalListService _sucursalListService;
        public SucursalService(ISucursalListService sucursalListService)
        {
            _sucursalListService = sucursalListService;
        }

        public void PrintSucursales()
        {
            foreach (Sucursal sucursal in _sucursalListService.GetSucursalList())
            {
                Console.WriteLine("Id: {0}, Nombre: {1}, Total: {2}", sucursal.Id, sucursal.Name, sucursal.Total);
            }
        }
    }
}
