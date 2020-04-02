using System.Collections.Generic;

namespace API.Data.Models
{
    public class Rebirth
    {
        public int ID { get; set; }
        public long Rid { get; set; }
        public string Clife { get; set; }
        public string Nlife { get; set; }
        public long Time { get; set; }
        public int Skipped { get; set; }

        public Rebirth(long rid, string clife, string nlife, long time, int skipped)
        {
            this.Rid = rid;
            this.Clife = clife;
            this.Nlife = nlife;
            this.Time = time;
            this.Skipped = skipped;
        }

        public virtual ICollection<Rebirth> Rebirths { get; set; }
    }
}