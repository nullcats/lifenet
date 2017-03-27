using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.IO;
using System.Web;
using System.Web.UI;
using NullCatsAccelerometer.Models;
using NullCatsAccelerometer.classes;

namespace NullCatsAccelerometer.Controllers
{
    [RoutePrefix("api/nullcats")]
    public class NullCatsController : ApiController
    {
        public List<Incident> IncidentListFalse { get; set; }
        public List<Incident> IncidentListTrue { get; set; }
        public List<string> PhonesNumbers { get; set; }
        public static bool SimulatedRecord { get; set; }

        public NullCatsController()
        {
            IncidentListFalse = JsonConvert.DeserializeObject<List<Incident>>(File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/data/nullcats.json")));
            IncidentListTrue = JsonConvert.DeserializeObject<List<Incident>>(File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/data/nullcatstrue.json")));
            PhonesNumbers = new List<string>();
            PhonesNumbers.Add("2537971884");
            PhonesNumbers.Add("2063558267");
            PhonesNumbers.Add("2069138622");//
            PhonesNumbers.Add("2088719849");
        }

        //GET: api/NullCats
       [Route("GetJson")]
        public string GetJson()
        {
            var dataList = IncidentListTrue;

            return JsonConvert.SerializeObject(dataList);
        }

        // GET: http://localhost:55870/api/NullCats/CheckIncidentTrue
        [HttpGet]
        [Route("CheckIncidentTrue")]
        public bool CheckIncidentTrue(double latitude, double longitude)
        {
            // set up radius from accident

            var radiusLatN = latitude + .1;
            var radiusLatS = latitude - .1;
            var radiusLongW = longitude + .1;
            var radiusLongE = longitude - .1;

            foreach (var incident in IncidentListTrue)
            {
                if ((radiusLatN > incident.latitude && radiusLatS < incident.latitude &&
                    radiusLongW > incident.longitude && radiusLongE < incident.longitude) || SimulatedRecord)
                {
                    SimulatedRecord = false;
                    return true;
                }
                    
            }

            return false;
        }

        // GET: http://localhost:55870/api/NullCats/CheckIncidentFalse
        [Route("CheckIncidentFalse")]
        public bool CheckIncidentFalse(double latitude, double longitude)
        {
            return false;
        }

        // Post: http://localhost:55870/api/NullCats/SendMessage
        //ex: json object { name: "John Doe", link: "www.google.com" }
        [HttpPost]
        [Route("SendMessage")]
        public List<string> SendMessage(TwilioMessage data)
        {
            var msgBodyTemplate = "Looks like {0} has been in an accident. http://www.lifenet.com/88ae63";

            var msgBody = string.Format(msgBodyTemplate, data.name);

            foreach (var phoneNum in PhonesNumbers)
            {
                TwilioApi.SendTwilio(phoneNum, msgBody);
            }
            List<string> names = new List<string>()
            {
                "Ryan Rushton, ",
                "Karen Tucker, ",
                "Stan Smith, ",
                "Kevin Riley "
            };
            return names;
        }

        [HttpGet]
        [Route("Make911Call")]
        public void Make911Call()
        {
            SimulatedRecord = true;
        }
    }
}
