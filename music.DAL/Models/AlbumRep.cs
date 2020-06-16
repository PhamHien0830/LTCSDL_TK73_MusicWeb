using System;
using System.Collections.Generic;
using System.Text;
using music.Common.DAL;
using System.Linq;

namespace music.DAL.Models
{
    using Models;
    public class AlbumRep : GenericRep<DBMusicContext, Album>
    {
        public override Album Read(String Ma)
        {
            var res = All.FirstOrDefault(b => b.MaAB == Ma);
            return res;
        }
        public string Remove(string Ma)
        {
            var m = base.All.First(i => i.MaAB == Ma);
            Context.Album.Remove(m);
            Context.SaveChanges();
            return m.MaAB;
        }
    }
}