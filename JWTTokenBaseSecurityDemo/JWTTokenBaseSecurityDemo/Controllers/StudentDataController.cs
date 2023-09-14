using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JWTTokenBaseSecurityDemo.Models;

namespace JWTTokenBaseSecurityDemo.Controllers
{
      [Authorize]
    public class StudentDataController : ApiController
    {
        ApiConsumeDemoEntities db;
       public StudentDataController()
       {
           db=new ApiConsumeDemoEntities();
       }
       [HttpGet]
       [Route("api/Student")]
       public List<Student> GetAllStudent()
       {
           return db.Students.ToList();
       }

    }
}
