using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BP_Webshop.Models;

namespace BP_Webshop.Services
{
    public class OrderLineService
    {
        public List<OrderLine> OrderLineList { get; set; }

        public GenericCRUDMethods<OrderLine> DbService { get; set; }

        public OrderLineService(GenericCRUDMethods<OrderLine> dbService)
        {
            DbService = dbService;
            OrderLineList = DbService.GetObjectsAsync().Result.ToList();

        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return OrderLineList;
        }



    }
}

