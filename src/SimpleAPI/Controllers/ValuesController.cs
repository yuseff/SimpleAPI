﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Baseball", "Football", "Basketball", "Hockey" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            switch (id)
            {
                case 1:
                    return "Billy Martin";
                case 2:
                    return "Derek Jeter";
                case 3:
                    return "Babe Ruth";
                case 4:
                    return "Lou Gehrig";
                case 5:
                    return "Joe DiMaggio";
                case 7:
                    return "Mickey Mantle";
                case 8:
                    return "Yogi Berra";
                case 9:
                    return "Craig Nettles";
                case 10:
                    return "Walt Frazier";
                case 12:
                    return "Joe Namath";
                case 24:
                    return "Willie Mays";
                case 33:
                    return "Patrick Ewing";
                case 37:
                    return "Casey Stengel";
                case 41:
                    return "Tom Seaver";
                case 42:
                    return "Jackie Robinson";
                case 44:
                    return "Reggie Jackson";
                case 66:
                    return "Mario Lemieux";
                case 69:
                    return "Ronnie The Limo Driver";
                case 99:
                    return "Wayne Gretzky";
                default:
                    return $"No mapping for number {id}";
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
