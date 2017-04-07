using System;
namespace VolunteerApi.Models
{
    public class Listing
    {
        public int Id {get; set;}
        public string EventName {get; set;}
        public string ProducerName {get; set;}
        public string Category{get;set;}
        public DateTime eventTime{get;set;} 
        public DateTime ExpireDate{get; set;}
    }
}