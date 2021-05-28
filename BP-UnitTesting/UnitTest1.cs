using System.Collections.Generic;
using BP_Webshop.Models;
using BP_Webshop.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BP_UnitTesting
{
    //[TestClass]
    public class UnitTest1
    {
        private static GenericCRUDMethods<Order> _dbService = new GenericCRUDMethods<Order>();
        private static GenericCRUDMethods<Bracelet> _dbService2 = new GenericCRUDMethods<Bracelet>();
        private static BraceletService _braceletService = new BraceletService(_dbService2);
        private static GenericCRUDMethods<Necklace> _dbService3 = new GenericCRUDMethods<Necklace>();
        private static NecklaceService _necklaceService = new NecklaceService(_dbService3);
        private static GenericCRUDMethods<Earring> _dbService4 = new GenericCRUDMethods<Earring>();
        private static EarringService _earringService = new EarringService(_dbService4);
        private static GenericCRUDMethods<HeadJewelry> _dbService5 = new GenericCRUDMethods<HeadJewelry>();
        private static HeadJewService _headJewService = new HeadJewService(_dbService5);
        private static GenericCRUDMethods<Ring> _dbService6 = new GenericCRUDMethods<Ring>();
        private static RingService _ringService = new RingService(_dbService6);
        private static JewelryService _jewelryService = new JewelryService(_braceletService, _necklaceService, _earringService, _headJewService, _ringService);
        private static GenericCRUDMethods<OrderLine> _dbService7 = new GenericCRUDMethods<OrderLine>();
        private static OrderLineService _orderLineService = new OrderLineService(_dbService7);
        private static OrderService _orderService = new OrderService(_dbService, _jewelryService, _orderLineService);

        //[TestInitialize]
        public void BeforeTest()
        {
            
            _jewelryService.Jewelries = new List<Jewelry>()
            {
                new Bracelet( 1, "Kangan",
                    "traditionally rigid bracelet which are usually made of metal, wood, glass or plastic", "Silver",
                    650, 5, 4, 3, "Image.jpg",0),
                new Earring( 2, "Tops",
                    "Luxury design can decorate your look and you will be confident with this earring. Material: Alloy,Rhinestone,Faux Pearl",
                    "Metal", 450, 10, 2, "Image2.png", 0)
            };
        }

        //[TestMethod]
        //public void TestTotalPriceWithoutTax()
        //{
        //    decimal expectedValue = _jewelryService.Jewelries[0].Price + _jewelryService.Jewelries[1].Price;
        //    decimal actualValue = _orderService.TotalPriceWithoutTax();
        //    Assert.AreEqual(expectedValue, actualValue);
        //}


    }
}
