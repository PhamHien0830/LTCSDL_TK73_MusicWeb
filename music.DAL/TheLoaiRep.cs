using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class TheLoaiRep : GenericRep<DBMusicContext, Theloai>
    {
        public override Theloai Read(String Ma)
        {
            var res = All.FirstOrDefault(b => b.MaTheLoai == Ma);
            return res;
        }
        public string Remove(string Ma)
        {
            var m = base.All.First(i => i.MaTheLoai == Ma);
            Context.Theloai.Remove(m);
            Context.SaveChanges();
            return m.MaTheLoai;
        }
    }
}

