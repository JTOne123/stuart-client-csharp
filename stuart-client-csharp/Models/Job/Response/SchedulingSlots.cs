﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace StuartDelivery.Models.Job.Response
{
    public class SchedulingSlots
    {
        [JsonProperty(PropertyName = "date")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTimeOffset Date { get; set; }

        [JsonProperty(PropertyName = "zone")]
        public Zone Zone { get; set; }

        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        public IEnumerable<Slot> Slots { get; set; }
    }
}