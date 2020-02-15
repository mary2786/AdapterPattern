using System.Collections.Generic;

namespace AdapterPattern
{
    public interface ISucursalListService
    {
        List<Sucursal> GetSucursalList();
    }
}