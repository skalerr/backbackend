using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace backbackend.Models
{
    public class UserData
    {
        public int Id {get; set; }
        [JsonPropertyName("requestnumber")]

        public string? RequestNumber{get; set; }
        [JsonPropertyName("inputtel")]              


        public string? InputTel { get; set; }
        [JsonPropertyName("inputname")]

        public string? InputName { get; set; }
        [JsonPropertyName("inputemail")]

        public string? InputEmail { get; set; }
        [JsonPropertyName("vmodelsumm")]

        public int? VmodelSumm { get; set; }
        [JsonPropertyName("vmodelday")]

        public int? VmodelDay { get; set; }

        // public DateTime datenow {get; set; } = new DateTime();
        public string? datenow { get; set; } 


    }
}