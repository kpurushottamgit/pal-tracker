using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        private WelcomeMessage _message;

        public WelcomeController(WelcomeMessage message)
        {
            _message = message;
        }
       
        [HttpGet]
        public string SayHello() => _message.Message;
    }
}