using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    [Serializable()]
    public class Journey
    {
        public string StartingPoint { get; set; }
        public string Destination { get; set; }
        public string Accomodation { get; set; }
        public float Budget { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public List<string> ToPack { get; set; }
        public List<string> ToVisit { get; set; }
        public Journey() { }
        public Journey(string sp, string d, string a, float b, string f, string t)
        {
            StartingPoint = sp;
            Destination = d;
            Accomodation = a;
            Budget = b;
            From = f;
            To = t;
            ToPack = new List<string>();
            ToVisit = new List<string>();
        }
        public void AddItem(string item)
        {
            ToPack.Add(item);
        }
        public void AddPlace(string place)
        {
            ToVisit.Add(place);
        }

        
    }
}
