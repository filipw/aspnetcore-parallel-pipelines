namespace WebApplication2.Controllers
{
    public class ResourceService : IHiService
    {
        public string SayHi()
        {
            return "Hi from Resource Service";
        }
    }
}
