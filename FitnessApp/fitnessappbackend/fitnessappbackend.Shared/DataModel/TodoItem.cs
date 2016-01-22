using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace fitnessappbackend
{
    public class TodoItem
    {
        public string Id { get; set; }

        public string Exercise1Name { get; set; }
        public string Exercise2Name { get; set; }
        public string Exercise3Name { get; set; }

        public string Exercise1Reps { get; set; }
        public string Exercise2Reps { get; set; }
        public string Exercise3Reps { get; set; }

        public string Exercise1Weight { get; set; }
        public string Exercise2Weight { get; set; }
        public string Exercise3Weight { get; set; }


        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }
    }
}
