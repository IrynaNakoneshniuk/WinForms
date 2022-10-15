using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Invoice
{
    public class Check
    {
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "Brand")]
        public string Brand { get; set; }
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime dateTime { get; set; }
        [JsonProperty(PropertyName ="IsFixed")]
        public string IsFixes { get; set; }
        public Check(string name, string brand, DateTime dateTime, string isFixes)
        {
            Name = name;
            Brand = brand;
            this.dateTime = dateTime;
            IsFixes = isFixes;
        }
        public Check()
        {
            Name = null;
            Brand = null;
            dateTime =DateTime.Now;
            IsFixes = null;
        }

        public override string ToString()
        {
            return $"{Name},  {Brand},  {dateTime},  {IsFixes}";
        }
    }
}
