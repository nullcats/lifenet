using Newtonsoft.Json;
using NullCatsAccelerometer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NullCatsAccelerometer.Controllers
{
    public class MojiController : ApiController
    {
        public Moji Moji { get; set; }

        public MojiController()
        {
            Moji = JsonConvert.DeserializeObject<Moji>(File.ReadAllText(System.Web.HttpContext.Current.Server.MapPath("~/data/mojiEvents.json")));

        }

        // GET: api/Moji
        public bool Get()
        {
            var foo = Moji.VehicleStates.Select(s => s.Vehicle).Where(w => w.HarshEventState.Value == true && w.HarshEventState.EventType == "Accident").FirstOrDefault();

            if (foo.HarshEventState.Value)
                return true;

            return false;
        }

        // GET: api/Moji/5
        //public bool Get(double latitude, double longitude)
        //{
        //    // set up radius from accident
        //    var radiusLat = latitude + .01;
        //    var radiusLong = longitude + .01;

        //    // call recordset until 
        //    foreach (var record in recordset)
        //    {
        //        if (radiusLat < record.latitude && longitude < record.longitude)
        //            return true;
        //    }

        //    return false;
        //}

        // POST: api/Moji
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Moji/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Moji/5
        public void Delete(int id)
        {
        }
    }
}
