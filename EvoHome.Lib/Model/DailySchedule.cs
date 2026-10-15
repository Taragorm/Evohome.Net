using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Evohome.Lib
{
    public class DailySchedule
    {
        [JsonPropertyName("dayOfWeek")]
        public string DayOfWeek
        {
            get;
            set;
        }
        [JsonPropertyName("switchpoints")]
        public List<Switchpoint> Switchpoints
        {
            get;
            set;
        }

        internal double GetSetTemperature(TimeSpan timeOfDay)
        {
            var x = from s in Switchpoints orderby s.Time select s;
            Switchpoint sp = null;
            foreach (Switchpoint sw in x)
            {
                if ((sw.Time <= timeOfDay) && (sp == null || (sp.Time < sw.Time)))                
                    sp = sw;
            }
            if (sp== null)
                sp = x.Last();
            return sp.Temperature;
        }
    }
}