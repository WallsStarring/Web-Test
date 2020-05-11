using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Web_Test.Models;

namespace Web_Test.Controllers
{
    [Route("apit/[controller]")]
    [ApiController]
    public class TransaccionesController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public TransaccionesController(NorthwindContext context)
        {
            _context = context;
        }

        // GET: apit/Transacciones //Order by 5
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Orders>>> GetOrders()
        {

            return await _context.Orders.Include(a => a.OrderDetails).OrderByDescending(x=>x.OrderId).Take(5).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Orders>> PostOrders(Orders orders)
        {
            using (var t = _context.Database.BeginTransaction()) {
                try
                {
                    var o = new Orders
                    {
                        OrderId = orders.OrderId,
                        CustomerId = orders.CustomerId,
                        EmployeeId = 1,
                        OrderDate = orders.OrderDate,
                        RequiredDate = orders.RequiredDate,
                        ShippedDate = orders.ShippedDate,
                        ShipVia = orders.ShipVia,
                        Freight = orders.Freight,
                        ShipName = orders.ShipName,
                        ShipAddress = "2817 Milton Dr.",
                        ShipCity = "Albuquerque",
                        ShipRegion = "NM",
                        ShipPostalCode = "87110",
                        ShipCountry = "USA",
                        Customer = null,
                        Employee = null,
                        ShipViaNavigation = null
                    };
                    _context.Orders.Add(o);
                    foreach (var item in orders.OrderDetails)
                    {
                        var od = new OrderDetails {
                             OrderId= item.OrderId,
                                ProductId=item.ProductId,
                                UnitPrice=item.UnitPrice,
                                Quantity=item.Quantity,
                                Discount=item.Discount,
                                Product=item.Product
                        };
                        _context.OrderDetails.Add(od);
                    }
                    //_context.OrderDetails.Add(orders.OrderDetails);
                    _context.SaveChanges();
                    t.Commit();
                }
                catch (Exception ex) {
                    t.Rollback();
                    return NotFound(ex.InnerException.Message);
                    
                }
            }
            return CreatedAtAction("GetOrders", new { id = orders.OrderId }, orders);
        }


    }
}
