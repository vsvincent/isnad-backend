using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HadithController : ControllerBase
    {
        private readonly ILogger<HadithController> _logger;
        private readonly IHadithService _hadithService;
        public HadithController(ILogger<HadithController> logger, IHadithService hadithService)
        {
            _logger = logger;
            _hadithService = hadithService;
        }

        [HttpPost(Name = "AddHadith")]
        public async Task<IActionResult> Post(Hadith hadith)
        {
            _hadithService.AddHadith(hadith);
            return Ok();
        }
    }
}