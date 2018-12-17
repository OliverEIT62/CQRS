using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiPeepConnect.Models.ReadModels;
using Microsoft.AspNetCore.Mvc;

namespace ApiPeepConnect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IQueryFactoryHandler _querys;
        public ValuesController(IQueryFactoryHandler querys)
        {
            _querys = querys;
        }

        [HttpGet]
        public UserMatchProfileEntity Get()
        {
            int id = 1;
            var query = new SingelUserMatchProfile(id);
            var handler = _querys.Build(query);
            return handler.Get();
        }

    }
}
