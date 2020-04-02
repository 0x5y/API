using System;
using System.Collections.Generic;

namespace Bot.Data
{
    public class User
    {
        public int ID { get; set; }
        public long Did { get; set; }
        public string Username { get; set; }
        public string Pcode { get; set; }
        public long Rid { get; set; }
        public bool Boost { get; set; }
        public int Level { get; set; }
        public string Life { get; set; }
        public long Ltime { get; set; }

        public User() {}
        public User(long did, string username, string pcode, bool boost)
        {
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            this.Did = did;
            this.Username = username;
            this.Pcode = pcode;
            this.Rid = 1;
            this.Boost = boost;
            this.Level = 0;
            this.Life = "";
            this.Ltime = (int)t.TotalSeconds;
        }

        public virtual ICollection<User> Users { get; set; }
    }
}