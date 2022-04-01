using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backbackend.Models
{
   public class Settings
{
   [Key]
     public int Id {get; set; }
    // [JsonProperty("summ")]
    public int? Summ { get; set; }

    // [JsonProperty("day")]
    public decimal? Day { get; set; }
    
    // [JsonProperty("title")]
    public string? Title { get; set; }
    
   // [JsonProperty("percentday")]
    public decimal? PercentDay { get; set; }

    public decimal? PercentMonth { get; set; }

    public decimal? PercentYear { get; set; }

}
}