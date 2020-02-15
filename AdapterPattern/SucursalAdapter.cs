using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdapterPattern
{
    public class SucursalAdapter : ISucursalListService
    {
        private readonly ISucursalJsonService _sucursalJsonService;
        public SucursalAdapter(ISucursalJsonService sucursalJsonService)
        {
            _sucursalJsonService = sucursalJsonService;
        }

        public List<Sucursal> GetSucursalList()
        {
            string json = _sucursalJsonService.GetSucursalJson();
            return JsonConvert.DeserializeObject<List<Sucursal>>(json);
        }
    }
}
