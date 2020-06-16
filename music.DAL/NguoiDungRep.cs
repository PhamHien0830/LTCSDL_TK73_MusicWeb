using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class NguoiDungRep : GenericRep<DBMusicContext, Nguoidung>
    {
        public override Nguoidung Read(String Ma)
        {
            var res = All.FirstOrDefault(b => b.MaUser == Ma);
            return res;
        }
        public string Remove(string Ma)
        {
            var m = base.All.First(i => i.MaUser == Ma);
            Context.Nguoidung.Remove(m);
            Context.SaveChanges();
            return m.MaUser;
        }
    }
}