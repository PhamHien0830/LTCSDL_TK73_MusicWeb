using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class QuanTriVienRep : GenericRep<DBMusicContext, Playlist>
    {
        public override Playlist Read(String Ma)
        {
            var res = All.FirstOrDefault(b => b.MaQuanTri == Ma);
            return res;
        }
        public string Remove(string Ma)
        {
            var m = base.All.First(i => i.MaQuanTri == Ma);
            Context.Quantrivien.Remove(m);
            Context.SaveChanges();
            return m.MaQuanTri;
        }
    }
}

