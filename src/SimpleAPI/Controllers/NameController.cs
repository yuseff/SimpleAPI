using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> GetAction() => new string[] {"this", "is", "hard", "Coded"};

        [Route("Hello")]
        [HttpGet]
        public string GetHello()
        {
            return "Hello World!";
        }

        [Route("Goodbye")]
        [HttpGet("{player:int?}")]
        public string GetBye(int? player)
        {
            if(player == null)
            {
                return "Goodbye everyone!";
            }
            else
            {
                return "Goodbye " + player;
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAction(
            [FromQuery] bool primeOnly = false)
        {
            if(primeOnly)
                return new string[] { "0", "1", "3", "5" };
            else
                return new string[] { "0", "1", "2", "3", "4", "5" };
        }

        [Route("Protected")]
        public string Protected()
        {
            return "Only if you have a valid token!";
        }

#if false
        // GET api/name/who
        [HttpGet("{player:int}")]
        public ActionResult<string> GetPlayerNo(int player)
        {
            return "Player: " + player;
            /*
            var s = this.Request.QueryString.Value;
            if(player == "me")
                return "Doodey!";
            else if(s == "me")
                return "Duty";

            return "Hoody!";
            */
        }
#else
        // GET api/name/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var s = this.Request.QueryString.Value;
            if(s.Contains("me"))
                return s;

            // https://www.usatoday.com/story/sports/2017/04/17/top-athletes-uniform-numbers/100339394/
            switch (id)
            {
                case 1:
                    return "Yao Ming";
                case 2:
                    return "Derek Jeter";
                case 3:
                    return "Babe Ruth";
                case 4:
                    return "Lou Gehrig";
                case 5:
                    return "Joe DiMaggio";
                case 6:
                    return "Julius Erving";
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
                case 19:
                    return "Brian Trottier";
                case 22:
                    return "Mike Bossy";
                case 24:
                    return "Willie Mays";
                case 33:
                    return "Kareem Abdul-Jabbar";
                case 37:
                    return "Casey Stengel";
                case 41:
                    return "Tom Seaver";
                case 42:
                    return "Jackie Robinson";
                case 44:
                    return "Reggie Jackson";
                case 49:
                    return "Ron Guidry";
                case 56:
                    return "Lawrence Taylor";
                case 66:
                    return "Mario Lemieux";
                case 68:
                    return "Jaromir Jagr";
                case 69:
                    return "Ronnie The Limo Driver";
                case 72:
                    return "Carlton Fisk";
                case 99:
                    return "Wayne Gretzky";
                default:
                    return $"No mapping for uniform number {id}";
            }
        }
#endif

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
