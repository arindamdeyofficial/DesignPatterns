using AbstractFactory;
using ArrayOps;
using Factory;
using Microsoft.AspNetCore.Mvc;
using Observer;

namespace DesignPatternAndDS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DesignpatternController : ControllerBase
    {
        private readonly IFactoryPattern _factory;
        private readonly IAbstractFactoryPattern _abstractFactory;
        private readonly IObserverPattern _observer;
        private readonly IStackHelper<string> _stck;
        private readonly IQueueHelper<string> _queue;

        private readonly ILogger<DesignpatternController> _logger;

        public DesignpatternController(ILogger<DesignpatternController> logger
            , [FromServices] IFactoryPattern factory,
            [FromServices] IAbstractFactoryPattern abstractFactory,
            [FromServices] IObserverPattern observer,
            [FromServices] Func<int, IStackHelper<string>> stck,
            [FromServices] Func<int, IQueueHelper<string>> queue)
        {
            _logger = logger;
            _factory = factory;
            _abstractFactory = abstractFactory;
            _observer = observer;
            _stck = stck.Invoke(10);
            _queue = queue.Invoke(10);
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
        [HttpGet("~/api/[controller]/Observer")]
        public JsonResult Observer(int deviceType, int deviceModel)
        {
            return new JsonResult(_observer.CreateDevice(deviceType, deviceModel));
        }
        [HttpPost("~/api/[controller]/StackPush")]
        public JsonResult StackPush(string[] arr)
        {
            foreach (var item in arr)
            {
                _stck.Push(item);
            }
            _stck.Push("Pushed Item1");
            _stck.Push("Pushed Item2");
            _stck.Push("Pushed Item3");

            return new JsonResult(_stck.GetArray());
        }
        [HttpPost("~/api/[controller]/StackPop")]
        public JsonResult StackPop(string[] arr)
        {
            foreach (var item in arr)
            {
                _stck.Push(item);
            }
            _stck.Pop();

            return new JsonResult(_stck.GetArray());
        }

        [HttpPost("~/api/[controller]/Enqueue")]
        public JsonResult Enqueue(string[] arr)
        {
            foreach (var item in arr)
            {
                _queue.Enqueue(item);
            }
            _queue.Enqueue("Pushed Item1");
            _queue.Enqueue("Pushed Item2");
            _queue.Enqueue("Pushed Item3");

            return new JsonResult(_queue.GetArray());
        }
        [HttpPost("~/api/[controller]/DeQueue")]
        public JsonResult DeQueue(string[] arr)
        {
            foreach (var item in arr)
            {
                _queue.Enqueue(item);
            }
            _queue.DeQueue();

            return new JsonResult(_queue.GetArray());
        }
    }
}