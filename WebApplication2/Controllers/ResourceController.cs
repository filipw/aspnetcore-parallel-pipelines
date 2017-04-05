using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    public class ResourceController : MyApiController
    {
        private IHiService _resourceService;

        public ResourceController(IHiService resourceService)
        {
            _resourceService = resourceService;
        }

        [HttpGet]
        public string Get()
        {
            return "I'm Resource Controller. " + _resourceService.SayHi();
        }
    }
}
