using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApi2.Repository.Abstract;
using MyWebApi2.Entitites;
using System.Web.Http;
using System.Net.Http;
using System.Net;

namespace MyWebApi2.Controllers
{
    [ApiController]
    [Route("api/istasyon-liste")]
    public class StationsController : ControllerBase
    {
        private readonly IStationRepository _context;
        public StationsController(IStationRepository context)
        {
            _context = context;
        }

        [HttpPost]
        public StationResponse Post([FromBody] Station station)
        {
            try
            {
                var stations = _context.GetStationListByFilter(station).ToList();
                return new StationResponse()
                {
                    Code = 201,
                    Data = stations
                };
                //return StatusCode("code":200, "data": stations);
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun bir HTTP cevabı döndürün
                //return StatusCode(500, ex);
                return new StationResponse() { Code = 400, Data = { } };
            }
        }
    }
}