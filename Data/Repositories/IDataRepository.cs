using API.Data.Models;

namespace API.Data.Repositories
{
    public interface IDataRepository
    {
        void AddRebirth(Rebirth rb);
        void AddSacrifice(Sacrifice sac);
        void AddEnchant(Enchant enchant);
        void AddForge(Forge forge);
        void AddCode(Code code);
        bool CheckPcode(string Code, long Rid, string Life);
    }
}