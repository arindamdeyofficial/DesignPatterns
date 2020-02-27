using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory;
using Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DesignpatternController : ControllerBase
    {
        private readonly IFactoryPattern _factory;
        private readonly IAbstractFactoryPattern _abstractFactory;
        public DesignpatternController(
          [FromServices]IFactoryPattern factory,
            [FromServices]IAbstractFactoryPattern abstractFactory)
        {
            _factory = factory;
            _abstractFactory = abstractFactory;
        }

        [HttpGet("~/api/[controller]/Factory")]
        public JsonResult Factory(int device)
        {
            return new JsonResult(_factory.CreateDevice(device));
        }
        [HttpGet("~/api/[controller]/AbstractFactory")]
        public JsonResult AbstractFactory(int deviceType, int deviceModel)
        {
            return new JsonResult(_abstractFactory.CreateDevice(deviceType, deviceModel));
        }
    }
}