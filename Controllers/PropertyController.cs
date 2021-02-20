using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using realestate.Data;
using realestate.Models;

namespace realestate.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly RealestateContext realestateContext;

        public PropertyController(RealestateContext realestateContext)
        { 
            this.realestateContext = realestateContext;
        }

        [HttpGet]
        public IEnumerable<Property> Get()
        {
            realestateContext.Properties.Add(new Property()
                {
                    Price = 10
                }
            );

            realestateContext.SaveChanges();

            return realestateContext.Properties;
        }
        
    }
}