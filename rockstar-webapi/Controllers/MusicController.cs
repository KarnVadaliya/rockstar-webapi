using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace rockstar_webapi.Controllers
{
    [ApiController]
    public class MusicController : ControllerBase
    {
        private Music myMusic = new Music();

        private readonly ILogger<MusicController> _logger;

        public MusicController(ILogger<MusicController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("[controller]")]
        public String Get()
        {
            return "<h1>My Jukebox!</h1>";
        }

        [HttpGet]
        [Route("[controller]/Demons")]
        public String GetDemons()
        {
            return myMusic.Demons;
        }

        [HttpGet]
        [Route("[controller]/InYourEyes")]
        public String GetInYourEyes()
        {
            return myMusic.InYourEyes;
        }

    }
}
