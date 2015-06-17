using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;

namespace BusinessTier
{
    public class Service
    {

        public List<GeraeteTyp> getAlleGeraeteTypen()
        {
            IDataTransfer dt = new DatenTransfer();
            return dt.GetAllDeviceType();
        }
        public List<Geraet> getAlleGeraeteFromTeraeteTyp(int geraeteTyp)
        {
            
            IDataTransfer dt = new DatenTransfer();
            List<Geraet> liG = dt.GetAllDevices();
            List<Geraet> selList = new List<Geraet>();
            foreach(Geraet g in liG)
            {
                if(g.TypId == geraeteTyp)
                {
                    selList.Add(g);
                }
            }
            return selList;
        }
    }
}
