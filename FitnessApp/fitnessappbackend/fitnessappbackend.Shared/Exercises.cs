using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using Microsoft.WindowsAzure.MobileServices;

namespace fitnessappbackend
{
    public class Exercises
    {
        public int id { get; set; }
        //[DataMember(Name="Exercise1Name")]
        [JsonProperty("exercise1name")]
        public string Exercise1Name { get; set; }
       // [DataMember(Name= "Exercise2Name")]
        [JsonProperty("exercise2name")]
        public string Exercise2Name { get; set; }
       // [DataMember(Name= "Exercise3Name")]
        [JsonProperty("exercise3name")]
        public string Exercise3Name { get; set; }

       // [DataMember(Name = "Exercise1Reps")]
        [JsonProperty("exercise1reps")]
        public string Exercise1Reps { get; set; }
       // [DataMember(Name = "Exercise2Reps")]
         [JsonProperty("exercise2reps")]
        public string Exercise2Reps { get; set; }
        //[DataMember(Name = "Exercise3Reps")]
         [JsonProperty("exercise3reps")]
        public string Exercise3Reps { get; set; }

        //[DataMember(Name = "Exercise1Weight")]
         [JsonProperty("exercise1weight")]
        public string Exercise1Weight { get; set; }
       // [DataMember(Name = "Exercise2Weight")]
       // [JsonProperty("exercise2weight")]
        public string Exercise2Weight { get; set; }
       // [DataMember(Name = "Exercise3Weight")]
        [JsonProperty("exercise2weight")]
        public string Exercise3Weight { get; set; }

    }
}
