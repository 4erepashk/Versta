using System;
using System.ComponentModel.DataAnnotations;

namespace versApp.Date.Models
{
    public class Order
    {
        
        public int id { get; set; }
        
        public string CitySender { get; set; }
        
        public string AddressSender { get; set; }
        
        public string CityRecipient { get; set; }
        
        public string AddressRecipient { get; set; }
        
        public double Weigth { get; set; }
        
        public DateTime Date { get; set; }

    }
}
