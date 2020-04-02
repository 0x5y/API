using System;
using System.Text.Json;
using API.Data.Models;
using API.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using API.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;
        private readonly IDataRepository dataRepository;

        public ApiController(ILogger<ApiController> logger, IDataRepository _dataRepository)
        {
            _logger = logger;
            dataRepository = _dataRepository;
        }
        
        [HttpPost]
        [Route("/api/logging/")]
        public string Postasdf([FromBody] string content)
        {
            Console.WriteLine(content);
            //dataRepository.AddRebirth(JsonConvert.DeserializeObject<Rebirth>(content));
            Console.WriteLine("worked");
            // if (content is null)
            // {
            //     return "bad";
            // }
            return "good";
        }

        [HttpPost]
        [Route("/api/logging/rebirth/{rid}")]
        public void RebirthController(long rid, string clife, string nlife, long time, int skipped)
        {
            dataRepository.AddRebirth(new Rebirth(rid, clife, nlife, time, skipped));
        }
        
        [HttpPost]
        [Route("/api/logging/sacrifice/{rid}")]
        public void SacrificeController(long rid, string slife, string sac, long time)
        {
            dataRepository.AddSacrifice(new Sacrifice(rid, slife, sac, time));
        }
        
        [HttpPost]
        [Route("/api/logging/enchant/{rid}")]
        public void EnchantController(long rid, int iid, string life, long time)
        {
            dataRepository.AddEnchant(new Enchant(rid, iid, life, time));
        }
        
        [HttpPost]
        [Route("/api/logging/forge/{rid}")]
        public void ForgeController(long rid, int iid, string life, long time)
        {
            dataRepository.AddForge(new Forge(rid, iid, life, time));
        }
        
        [HttpPost]
        [Route("/api/logging/code/{rid}")]
        public void CodeController(long rid, string cod, bool success, long time)
        {
            dataRepository.AddCode(new Code(rid, cod, success, time));
        }

        [HttpPost]
        [Route("/api/pcode/check/{code}")]
        public bool PcodeController(string code, long rid, string life)
        {
            return dataRepository.CheckPcode(code, rid, life);
        }

        // [HttpGet]
        // [Route("/api/logging/{LogType}")]
        // public string Postasdf(string LogType, long rid, string clife, string nlife, long time, int skipped)
        // {
        //     dataRepository.AddRebirth(JsonConvert.DeserializeObject<Rebirth>(content));
        //      switch (LogType)
        //      {
        //          case "rebirth":
        //              dataRepository.AddRebirth(JsonConvert.DeserializeObject<Rebirth>(content));
        //              return "hi thererebirth";
        //              break;
        //          case "sacrifice":
        //              break;
        //          case "enchant":
        //              break;
        //          case "forge":
        //              break;
        //          case "code":
        //              break;
        //          case "pcode":
        //              break;
        //      }
        //      return "hi there";
        // }
    }
}