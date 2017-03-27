using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NullCatsAccelerometer.Models
{
    public class Incident
    {
        public string call_number { get; set; }
        public string unit_id { get; set; }
        public string incident_number { get; set; }
        public string call_type { get; set; }
        public string call_date { get; set; }
        public string watch_date { get; set; }
        public string received_timestamp { get; set; }
        public string entry_timestamp { get; set; }
        public string dispatch_timestamp { get; set; }
        public string response_timestamp { get; set; }
        public string on_scene_timestamp { get; set; }
        public string transport_timestamp { get; set; }
        public string hospital_timestamp { get; set; }
        public string call_final_disposition { get; set; }
        public string available_timestamp { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipcode_of_incident { get; set; }
        public string battalion { get; set; }
        public string station_area { get; set; }
        public string box { get; set; }
        public string original_priority { get; set; }
        public string priority { get; set; }
        public string final_priority { get; set; }
        public string als_unit { get; set; }
        public string call_type_group { get; set; }
        public string number_of_alarms { get; set; }
        public string unit_type { get; set; }
        public string unit_sequence_in_call_dispatch { get; set; }
        public string fire_prevention_district { get; set; }
        public string supervisor_district { get; set; }
        public string neighborhood_district { get; set; }
        public string location { get; set; }
        public string row_id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}