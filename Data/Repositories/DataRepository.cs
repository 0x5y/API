using API.Data.Models;
using System.Linq;

namespace API.Data.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly DataBaseContext db;
        private int ChangeCount;

        public DataRepository(DataBaseContext _db)
        {
            db = _db;
        }
        
        private void Save()
        {
            ChangeCount++;
            if (ChangeCount >= 1)
            {
                db.SaveChanges();
            }
        }

        public void AddRebirth(Rebirth rb)
        {
            db.Rebirths.Add(rb);
            Save();
        }
        public void AddSacrifice(Sacrifice sac)
        {
            db.Sacrifices.Add(sac);
            Save();
        }
        public void AddEnchant(Enchant enchant)
        {
            db.Enchants.Add(enchant);
            Save();
        }
        public void AddForge(Forge forge)
        {
            db.Forges.Add(forge);
            Save();
        }
        public void AddCode(Code code)
        {
            db.Codes.Add(code);
            Save();
        }

        public bool CheckPcode(string Code, long Rid, string Life)
        {
            var Quser = db.Users.Where(f => f.Pcode == Code).ToList();
            if (Quser.Count == 0) { return false; }

            var user = Quser[0];
            return false;
        }
    }
}