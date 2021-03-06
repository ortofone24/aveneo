﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using aveneo.API.Attributes;
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
                
        public BusinessEntityController(DataContext context)
        {
            _context = context;
        }
        
        [HttpGet("{searchQuery}")]
        [HttpHeaders]
        public async Task<IActionResult> Get(string searchQuery)
        {
            var result = await _context.BusinessEntities
                                  .FirstOrDefaultAsync(x =>
                                        x.KRS.Equals(searchQuery) ||
                                        x.NIP.Equals(searchQuery) ||
                                        x.REGON.Equals(searchQuery));
               
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}