using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "46+555+555+5555";
        }

        public string Address()
        {
            return "Sweden";
        }
    }
}
