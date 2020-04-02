using System.Collections.Generic;

namespace API.Data.Models
{
    public class Forge
    {
        public int ID { get; set; }
        public long Rid { get; set; }
        public int Iid { get; set; }
        public string Life { get; set; }
        public long Time { get; set; }
        
        public Forge(long rid, int iid, string life, long time)
        {
            this.Rid = rid;
            this.Iid = iid;
            this.Life = life;
            this.Time = time;
        }

        public virtual ICollection<Forge> Forges { get; set; }
    }
}