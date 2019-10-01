using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;

namespace ParseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParseController : ControllerBase
    {
        // POST api/parse
        [HttpPost]
        public void Post([FromBody] XmlDTO xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml.ToString());

            //return new JsonResult(JsonConvert.SerializeXmlNode(doc));
        }

        // GET api/parse
        [HttpGet]
        public string Get()
        {
            return "Teste";
        }


    }

    public class XmlDTO
    {
        private string cep;
    }


}