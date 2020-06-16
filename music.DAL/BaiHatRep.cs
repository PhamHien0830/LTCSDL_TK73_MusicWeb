using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL
{
    using Models;
    public class BaiHatRep : GenericRep<DBMusicContext, Baihat>
    {
        public override Baihat Read(String Mabh)
        {
            var res = All.FirstOrDefault(b => b.MaBaiHat == Mabh);
            return res;
        }
        public string Remove(string Ma)
        {
            var m = base.All.First(i => i.MaBaiHat == Ma);
            Context.Baihat.Remove(m);
            Context.SaveChanges();
            return m.MaBaiHat;
        }
    }

}
