using System.Collections.Generic;

namespace API.Data.Models
{
    public class Code
    {
        public int ID { get; set; }
        public long Rid { get; set; }
        public string Cod { get; set; }
        public bool Success { get; set; }
        public long Time { get; set; }
        
        public Code(long rid, string cod, bool success, long time)
        {
            this.Rid = rid;
            this.Cod = cod;
            this.Success = success;
            this.Time = time;
        }


        public virtual ICollection<Code> Codes { get; set; }
    }
}