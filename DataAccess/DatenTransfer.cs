using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DatenTransfer: IDataTransfer
    {
        public bool ConnectToDb()
        {
            return true;
        }

        public List<BusinessObjects.GeraeteTyp> GetAllDeviceType()
        {
            List<GeraeteTyp> liGT = new List<GeraeteTyp>();
            liGT.Add(new GeraeteTyp { GeraeteTypID = 1, GeraeteBezeichnung = "Hammer", MietPreis = 56.34m });
            liGT.Add(new GeraeteTyp { GeraeteTypID = 2, GeraeteBezeichnung = "Bohrer", MietPreis = 34.45m });
            liGT.Add(new GeraeteTyp { GeraeteTypID = 3, GeraeteBezeichnung = "Rüttler", MietPreis = 44.34m });

            return liGT;
        }

        public List<Geraet> GetAllDevices()
        {
            List<Geraet> liG = new List<Geraet>();
            liG.Add(new Geraet(100, "2008", "2008", 1));
            liG.Add(new Geraet(200, "2010", "2008", 2));
            liG.Add(new Geraet(300, "2015", "2015", 2));
            liG.Add(new Geraet(400, "2011", "2008", 3));
            return liG;
        }

        public bool CloseConnection()
        {
            return true;
        }
    }
}
