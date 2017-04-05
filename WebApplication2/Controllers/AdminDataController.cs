using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("[controller]")]
    public class AdminDataController : DashboardController
    {
        private IHiService _adminService;

        public AdminDataController(IHiService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public string Get()
        {
            return "I'm Admin Data Controller. " + _adminService.SayHi();
        }
    }
}
