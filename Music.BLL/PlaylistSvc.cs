using System;
using System.Collections.Generic;
using System.Text;
using music.Common.Rsp;
using music.Common.BLL;
using music.DAL;
using music.DAL.Models;
namespace Music.BLL
{

    public class PlaylistSvc : GenericSvc<PlaylistRep, Playlist>
    {
        public override SingleRsp Read(string Ma)
        {
            var res = new SingleRsp();
            var m = _rep.Read(Ma);
            res.Data = m;
            return res;
        }
        //public override SingleRsp 

        // Remove 
        public SingleRsp DeletePlaylist(string Ma)
        {
            var res = new SingleRsp();
            try
            {
                res.Data = _rep.Remove(Ma);
            }
            catch (Exception ex)
            {
                res.SetError(ex.StackTrace);
            }
            return res;
        }

        public object DeletePlayList(string maPlayList)
        {
            throw new NotImplementedException();
        }
    }
}
