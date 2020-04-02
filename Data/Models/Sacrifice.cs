using System.Collections.Generic;

namespace API.Data.Models
{
    public class Sacrifice
    {
        public int ID { get; set; }
        public long Rid { get; set; }
        public string Slife { get; set; }
        public string Sac { get; set; }
        public long Time { get; set; }
        
        public Sacrifice(long rid, string slife, string sac, long time)
        {
            this.Rid = rid;
            this.Slife = slife;
            this.Sac = sac;
            this.Time = time;
        }

        public virtual ICollection<Sacrifice> Sacrifices { get; set; }
    }
}