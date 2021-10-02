//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using ChinessResturantAPIs.Models;

//namespace ChinessResturantAPIs.Controllers
//{
//    public class UpdateController : ApiController
//    {

//        DBEntities db = new DBEntities();

//        //add post
//        //
//        public string Post(Order order)
//        {

//            db.Orders.Add(order);
//            db.SaveChanges();
//            return "order added";

//        }

//        //get all product
//        //api/Update
//        public IEnumerable<Order> Get()
//        {

//            return db.Orders.ToList();

//        }

//        //Get singele data
//        //api/Update/ord1
//        public Order Get(string OrdeRreference)
//        {

//            Order order = db.Orders.Find(OrdeRreference);
//            return order;

//        }

//        //Update Record
//        ////[HttpPut]
//        ////public string Put(string OrdeRreference, [FromBody] Order order)
//        ////{


//        ////    var product_ = db.Orders.Find(OrdeRreference);
//        ////    product_.Status = order.Status;

//        ////    db.Entry(product_).State = System.Data.Entity.EntityState.Modified;
//        ////    db.SaveChanges();
//        ////    return "updated ";


//        ////}
//        //api udpdate 
//        //http://localhost:10887/api/Update
//////       {

//////"OrdeRreference":"ord1",
//////"Status":"newone"


//////}
//    public IHttpActionResult Put(Order order)
//        {
//            if (!ModelState.IsValid)
//                return BadRequest("Not a valid model");

//            using (var ctx = new DBEntities())
//            {
//                var existingStudent = ctx.Orders.Where(s => s.OrdeRreference == order.OrdeRreference)
//                                                        .FirstOrDefault<Order>();

//                if (existingStudent != null)
//                {
//                    existingStudent.Status = order.Status;
//                    //existingStudent.LastName = student.LastName;

//                    ctx.SaveChanges();
//                }
//                else
//                {
//                    return NotFound();
//                }
//            }

//            return Ok();
//        }


//    }








//}
