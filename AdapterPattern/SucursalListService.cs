using System.Collections.Generic;

namespace AdapterPattern
{
    public class SucursalListService : ISucursalListService
    {
        public List<Sucursal> GetSucursalList()
        {
            return new List<Sucursal>()
            {
                new Sucursal() { Id = 1, Name = "Sucursal 1", Total = 100.52 },
                new Sucursal() { Id = 2, Name = "Sucursal 2", Total = 10000.3 },
                new Sucursal() { Id = 3, Name = "Sucursal 3", Total = 1565.654 }
            };
        }
    }
}
