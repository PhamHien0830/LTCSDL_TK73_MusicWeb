using System;
using System.Collections.Generic;
using System.Text;
using music.Common.Rsp;
using music.Common.BLL;
using music.DAL;
using music.DAL.Models;
namespace Music.BLL
{

    public class AlbumSvc : GenericSvc<AlbumRep, Album>
    {
        public override SingleRsp Read(string MaID)
        {
            var res = new SingleRsp();
            var m = _rep.Read(MaID);
            res.Data = m;
            return res;
        }
        //public override SingleRsp 

        // Remove 
        public SingleRsp DeleteAlbum(string Ma)
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
    }
}
