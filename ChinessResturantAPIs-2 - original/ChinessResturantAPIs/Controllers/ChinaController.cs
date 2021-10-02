using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ChinessResturantAPIs.Models;

namespace ChinessResturantAPIs.Controllers
{     //GEt command to get the data 
    public class ChinaController : ApiController
    {
        //http://localhost:10887/api/China?orderid=ord1
        public IHttpActionResult GetAllStudents()
        {

            IList<DragonDataViewMode> orders = null;

            using (var ctx = new ChiDragonDbEntities())
            {
                
                orders = ctx.Orders.Include("StudentAddress").Select(s => new DragonDataViewMode()
                    {
                      
                    OrdeRreference = s.OrdeRreference,
                        OrderThrough = s.OrderThrough,
                        OrderType = s.OrderType,
                        Status = s.Status,
                        OrderDate =  s.OrderDate
           
                    }).ToList<DragonDataViewMode>();
            }

            if (orders.Count == 0)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        //...............................udate command............to update the button


        public IHttpActionResult Put(DragonDataViewMode oridno)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new ChiDragonDbEntities())
            {
                var existingstatus = ctx.Orders.Where(s => s.OrdeRreference == oridno.OrdeRreference)
                                                        .FirstOrDefault<Order>();

                if (existingstatus != null)
                {
                    existingstatus.Status= oridno.Status;
                   

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }






    }
    
}
