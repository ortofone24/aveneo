using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aveneo.API.Data;
using aveneo.API.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aveneo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessEntityController : ControllerBase
    {
        private readonly DataContext _context;

        private readonly IHttpContextAccessor _httpContext;

        public BusinessEntityController(DataContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

       
        [HttpGet("{searchQuery}")]
        public async Task<IActionResult> Get(string searchQuery)
        {
            var result = await _context.BusinessEntities
                                  .FirstOrDefaultAsync(x =>
                                        x.KRS.Equals(searchQuery) ||
                                        x.NIP.Equals(searchQuery) ||
                                        x.REGON.Equals(searchQuery));

            var resultHttpUrl = _httpContext.HttpContext.Request.Path.ToString();
            var resultHeaders = _httpContext.HttpContext.Request.Headers.ToList();

            var newHttpHeader = new HttpHeaders
            {
                Accept = resultHeaders[0].Value,
                AcceptEncoding = resultHeaders[1].Value,
                AcceptLanguage = resultHeaders[2].Value,
                Connection = resultHeaders[3].Value,
                Host = resultHeaders[4].Value,
                Referer = resultHeaders[5].Value,
                UserAgent = resultHeaders[6].Value,
                Origin = resultHeaders[7].Value,
                Dnt = resultHeaders[8].Value,
                SecFetchSite = resultHeaders[9].Value,
                SecFetchMode = resultHeaders[10].Value,
                Url = resultHttpUrl
            };

            //await _context.HttpHeaders.AddAsync(newHttpHeader);
            await _context.SaveChangesAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}