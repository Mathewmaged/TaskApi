using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.IServices;
using DataAccessLayer.Models;
using DataAccessLayer.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace UrlApis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class URLController : Controller
    {
        private readonly IUrl url;
        public URLController(IUrl _url)
        {
            url = _url;
        }
        [HttpGet]
        [Route("GetList")]
        public IEnumerable<Urls> GetList()
        {
            return url.GetList();
        }
        [HttpPost]
        [Route("addUrl")]
        public bool addUrl([FromBody]UrlVM urlVm)
        {
            return url.AddUrl(urlVm.url);
        }
    }
}